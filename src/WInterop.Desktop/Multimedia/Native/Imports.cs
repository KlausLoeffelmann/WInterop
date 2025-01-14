﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;
using WInterop.Modules;

namespace WInterop.Multimedia.Native
{
    /// <summary>
    ///  Direct usage of Imports isn't recommended. Use the wrappers that do the heavy lifting for you.
    /// </summary>
    public static partial class Imports
    {
        [DllImport(Libraries.Winmm, ExactSpelling = true)]
        public static extern bool PlaySoundW(
            IntPtr pszSound,
            ModuleInstance hmod,
            PlaySoundOptions fdwSound);
    }
}