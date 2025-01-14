﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

namespace WInterop.Storage.Native
{
    // https://msdn.microsoft.com/en-us/library/windows/desktop/hh449411.aspx
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public ref struct COPYFILE2_EXTENDED_PARAMETERS
    {
        public uint dwSize;
        public CopyFileFlags dwCopyFlags;
        public unsafe IntBoolean* pfCancel;
        public IntPtr pProgressRoutine;
        public IntPtr pvCallbackContext;
    }
}