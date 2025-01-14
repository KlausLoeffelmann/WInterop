﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using WInterop.Errors;
using WInterop.ProcessAndThreads.Native;
using WInterop.Support;
using WInterop.Support.Buffers;

namespace WInterop.ProcessAndThreads
{
    /// <summary>
    ///  These methods are only available from Windows desktop apps. Windows store apps cannot access them.
    /// </summary>
    public static partial class Processes
    {
        /// <summary>
        ///  Set the given enivronment variable.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown if name is null.</exception>
        public static void SetEnvironmentVariable(string name, string value)
        {
            if (name is null) throw new ArgumentNullException(nameof(name));

            Error.ThrowLastErrorIfFalse(
                ProcessAndThreadImports.SetEnvironmentVariableW(name, value),
                name);
        }

        /// <summary>
        ///  Get the given enivronment variable. Returns empty string if the variable isn't found.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown if name is null.</exception>
        public static unsafe string GetEnvironmentVariable(string name)
        {
            return name is null
                ? throw new ArgumentNullException(nameof(name))
                : PlatformInvoke.GrowableBufferInvoke(
                    (ref ValueBuffer<char> buffer) =>
                    {
                        fixed (char* n = name)
                        {
                            fixed (char* b = buffer)
                            {
                                return ProcessAndThreadImports.GetEnvironmentVariableW(n, b, buffer.Length);
                            }
                        }
                    },
                    detail: name,
                    shouldThrow: (WindowsError error) => error != WindowsError.ERROR_ENVVAR_NOT_FOUND);
        }

        /// <summary>
        ///  GetEnvironmentStrings split into key value pairs.
        /// </summary>
        public static IDictionary<string, string> GetEnvironmentVariables()
        {
            var variables = new Dictionary<string, string>();
            using (var buffer = ProcessAndThreadImports.GetEnvironmentStringsW())
            {
                if (buffer.IsInvalid) return variables;

                foreach (var entry in Strings.SplitNullTerminatedStringList(buffer.DangerousGetHandle()))
                {
                    // Hidden environment variables start with an equals, and can't be empty anyways, so
                    // we always look for the key/value equals separator from index 1.
                    int separator = entry.IndexOf('=', startIndex: 1);
                    if (separator == -1) throw new InvalidOperationException("There should never be a string given back from Windows without an equals sign");

                    string key = entry.Substring(startIndex: 0, length: separator);
                    string value = entry[(separator + 1)..];
                    variables.Add(key, value);
                }
            }

            return variables;
        }

        /// <summary>
        ///  Gets the raw set of environment strings as name/value pairs separated by an equals character.
        /// </summary>
        /// <remarks>Names can have an equals character as the first character. Be cautious when splitting or use GetEnvironmentVariables().</remarks>
        public static IEnumerable<string> GetEnvironmentStrings()
        {
            using var buffer = ProcessAndThreadImports.GetEnvironmentStringsW();
            return buffer.IsInvalid
                ? Enumerable.Empty<string>()
                : Strings.SplitNullTerminatedStringList(buffer.DangerousGetHandle());
        }

        /// <summary>
        ///  Gets the specified process memory counters.
        /// </summary>
        /// <param name="process">The process to get memory info for for or null for the current process.</param>
        public static unsafe ProcessMemoryCountersExtended GetProcessMemoryInfo(SafeProcessHandle? process = null)
        {
            Error.ThrowLastErrorIfFalse(
                ProcessAndThreadImports.K32GetProcessMemoryInfo(
                    process ?? GetCurrentProcess(),
                    out ProcessMemoryCountersExtended info,
                    (uint)sizeof(ProcessMemoryCountersExtended)));

            return info;
        }

        /// <summary>
        ///  Get the process id for the given process handle.
        /// </summary>
        public static uint GetProcessId(SafeProcessHandle processHandle)
        {
            return ProcessAndThreadImports.GetProcessId(processHandle);
        }

        /// <summary>
        ///  Get the handle for the current process.
        ///  Note that this handle is only relevant in the current process- it
        ///  can't be passed to other processes.
        /// </summary>
        public static ProcessHandle GetCurrentProcess() => ProcessAndThreadImports.GetCurrentProcess();

        /// <summary>
        ///  Get the handle for the current process.
        /// </summary>
        public static uint GetCurrentProcessId() => ProcessAndThreadImports.GetCurrentProcessId();

        /// <summary>
        ///  Open a handle to the specified process by id.
        /// </summary>
        public static SafeProcessHandle OpenProcess(uint processId, ProcessAccessRights desiredAccess, bool inheritHandle = false)
        {
            SafeProcessHandle handle = ProcessAndThreadImports.OpenProcess(desiredAccess, inheritHandle, processId);
            if (handle.IsInvalid)
                Error.ThrowLastError();
            return handle;
        }
    }
}