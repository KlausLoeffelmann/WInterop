﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

// This file is based on System.IO.PatternMatcher from CoreFX:
//
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using WInterop.Support;

namespace WInterop.Storage
{
    public static class DosMatcher
    {
        public static unsafe bool MatchPattern(string expression, ReadOnlySpan<char> name, bool ignoreCase = true)
        {
            // The idea behind the algorithm is pretty simple. We keep track of all possible locations
            // in the regular expression that are matching the name. When the name has been exhausted,
            // if one of the locations in the expression is also just exhausted, the name is in the
            // language defined by the regular expression.

            if (string.IsNullOrEmpty(expression) || name.Length == 0)
                return false;

            if (expression[0] == '*')
            {
                // Just * matches everything
                if (expression.Length == 1)
                    return true;

                if (!Paths.ContainsWildcards(expression, 1))
                {
                    // Handle the special case of a single  starting *, which essentially means "ends with"

                    // If the name doesn't have enough characters to match the remaining expression, it can't be a match.
                    if (name.Length < expression.Length - 1)
                        return false;

                    // See if we end with the expression (minus the *, of course)
                    return name.EndsWith(expression.AsSpan().Slice(1), ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
                }
            }

            Span<int> temp;

            int nameOffset = 0;
            int expressionOffset;

            int priorMatch;
            int currentMatch;
            int priorMatchCount;
            int matchCount = 1;

            char nameChar = '\0';
            char expressionChar;

            int* priorStack = stackalloc int[16];
            int* currentStack = stackalloc int[16];
            Span<int> priorMatches = new Span<int>(priorStack, 16);
            Span<int> currentMatches = new Span<int>(currentStack, 16);

            int maxState = expression.Length * 2;
            int currentState;
            bool nameFinished = false;

            while (!nameFinished)
            {
                if (nameOffset < name.Length)
                {
                    // Not at the end of the name. Grab the current character and move the offset forward.
                    nameChar = name[nameOffset++];
                }
                else
                {
                    // At the end of the name. If the expression is exhausted, exit.
                    if (priorMatches[matchCount - 1] == maxState)
                        break;

                    nameFinished = true;
                }

                // Now, for each of the previous stored expression matches, see what
                // we can do with this name character.
                priorMatch = 0;
                currentMatch = 0;
                priorMatchCount = 0;

                while (priorMatch < matchCount)
                {
                    // We have to carry on our expression analysis as far as possible for each
                    // character of name, so we loop here until the expression stops matching.

                    expressionOffset = (priorMatches[priorMatch++] + 1) / 2;

                    while (expressionOffset < expression.Length)
                    {
                        currentState = expressionOffset * 2;
                        expressionChar = expression[expressionOffset];

                        // We may be about to exhaust the local space for matches,
                        // so we have to reallocate if this is the case.
                        if (currentMatch >= currentMatches.Length - 2)
                        {
                            int newSize = currentMatches.Length * 2;
                            temp = new Span<int>(new int[newSize]);
                            currentMatches.CopyTo(temp);
                            currentMatches = temp;

                            temp = new Span<int>(new int[newSize]);
                            priorMatches.CopyTo(temp);
                            priorMatches = temp;
                        }

                        if (expressionChar == '*')
                        {
                            // '*' matches any character zero or more times.
                            goto MatchZeroOrMore;
                        }
                        else if (expressionChar == '<')
                        {
                            // '<' (DOS_STAR) matches any character except '.' zero or more times.

                            // If we are at a period, determine if we are allowed to
                            // consume it, i.e. make sure it is not the last one.

                            bool notLastPeriod = false;
                            if (!nameFinished && nameChar == '.')
                            {
                                for (int offset = nameOffset; offset < name.Length; offset++)
                                {
                                    if (name[offset] == '.')
                                    {
                                        notLastPeriod = true;
                                        break;
                                    }
                                }
                            }

                            if (nameFinished || nameChar != '.' || notLastPeriod)
                            {
                                goto MatchZeroOrMore;
                            }
                            else
                            {
                                // We are at a period.  We can only match zero
                                // characters (i.e. the epsilon transition).
                                goto MatchZero;
                            }
                        }
                        else
                        {
                            // The following expression characters all match by consuming
                            // a character, thus force the expression, and thus state forward.
                            currentState += 2;

                            if (expressionChar == '>')
                            {
                                // '>' (DOS_QM) is the most complicated. If the name is finished,
                                // we can match zero characters. If this name is a '.', we
                                // don't match, but look at the next expression.  Otherwise
                                // we match a single character.
                                if (nameFinished || nameChar == '.')
                                    goto NextExpressionCharacter;

                                currentMatches[currentMatch++] = currentState;
                                goto ExpressionFinished;
                            }
                            else if (expressionChar == '"')
                            {
                                // A '"' (DOS_DOT) can match either a period, or zero characters
                                // beyond the end of name.
                                if (nameFinished)
                                {
                                    goto NextExpressionCharacter;
                                }
                                else if (nameChar == '.')
                                {
                                    currentMatches[currentMatch++] = currentState;
                                }

                                goto ExpressionFinished;
                            }
                            else
                            {
                                // From this point on a name character is required to even
                                // continue, let alone make a match.
                                if (nameFinished) goto ExpressionFinished;

                                if (expressionChar == '?')
                                {
                                    // If this expression was a '?' we can match it once.
                                    currentMatches[currentMatch++] = currentState;
                                }
                                else if (ignoreCase
                                    ? char.ToUpperInvariant(expressionChar) == char.ToUpperInvariant(nameChar)
                                    : expressionChar == nameChar)
                                {
                                    // Matched a non-wildcard character
                                    currentMatches[currentMatch++] = currentState;
                                }

                                // The expression didn't match so move to the next prior match.
                                goto ExpressionFinished;
                            }
                        }

                        MatchZeroOrMore:
                            currentMatches[currentMatch++] = currentState;
                        MatchZero:
                            currentMatches[currentMatch++] = currentState + 1;
                        NextExpressionCharacter:
                            if (++expressionOffset == expression.Length)
                                currentMatches[currentMatch++] = maxState;
                    } // while (expressionOffset < expression.Length)

                    ExpressionFinished:

                    // Prevent duplication in the destination array.
                    //
                    // Each of the arrays is monotonically increasing and non-duplicating, thus we skip
                    // over any source element in the source array if we just added the same element to
                    // the destination array. This guarantees non-duplication in the destination array.

                    if ((priorMatch < matchCount) && (priorMatchCount < currentMatch))
                    {
                        while (priorMatchCount < currentMatch)
                        {
                            int previousLength = priorMatches.Length;
                            while ((priorMatch < previousLength) && (priorMatches[priorMatch] < currentMatches[priorMatchCount]))
                            {
                                priorMatch++;
                            }

                            priorMatchCount++;
                        }
                    }
                } // while (sourceCount < matchesCount)

                // If we found no matches in the just finished iteration,
                // it's time to bail.
                if (currentMatch == 0)
                    return false;

                // Swap the meaning the two arrays
                temp = priorMatches;
                priorMatches = currentMatches;
                currentMatches = temp;

                matchCount = currentMatch;
            } // while (!nameFinished)

            currentState = priorMatches[matchCount - 1];

            return currentState == maxState;
        }
    }
}