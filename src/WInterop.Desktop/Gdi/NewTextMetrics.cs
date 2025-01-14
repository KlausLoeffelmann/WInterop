﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;

namespace WInterop.Gdi
{
    /// <summary>
    ///  [NEWTEXTMETRIC]
    /// </summary>
    /// <msdn>https://msdn.microsoft.com/en-us/library/dd162741.aspx</msdn>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct NewTextMetrics
    {
        public int Height;
        public int Ascent;
        public int Descent;
        public int InternalLeading;
        public int ExternalLeading;
        public int AverageCharWidth;
        public int MaxCharWidth;
        public int Weight;
        public int Overhang;
        public int DigitizedAspectX;
        public int DigitizedAspectY;
        public char FirstChar;
        public char LastChar;
        public char DefaultChar;
        public char BreakChar;
        public ByteBoolean Italic;
        public ByteBoolean Underlined;
        public ByteBoolean StruckOut;
        public PitchAndFamily PitchAndFamily;
        public CharacterSet CharacterSet;
        public TextMetricFlags Flags;
        public uint SizeEM;
        public uint CellHeight;
        public uint AverageWidth;
    }
}