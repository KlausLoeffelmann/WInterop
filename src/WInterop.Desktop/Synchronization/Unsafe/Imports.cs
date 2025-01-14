﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;
using WInterop.Handles;
using WInterop.Security.Native;

namespace WInterop.Synchronization.Native
{
    /// <summary>
    ///  Direct usage of Imports isn't recommended. Use the wrappers that do the heavy lifting for you.
    /// </summary>
    public static partial class Imports
    {
        // https://docs.microsoft.com/windows/win32/api/synchapi/nf-synchapi-createeventw
        [DllImport(Libraries.Kernel32, ExactSpelling = true)]
        public static unsafe extern EventHandle CreateEventW(
            SECURITY_ATTRIBUTES* lpEventAttributes,
            bool bManualReset,
            bool bInitialState,
            string lpName);
    }
}