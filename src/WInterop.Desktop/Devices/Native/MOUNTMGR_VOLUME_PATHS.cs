﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

namespace WInterop.Devices.Native
{
    // Defined in mountmgr.h
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MOUNTMGR_VOLUME_PATHS
    {
        public uint MultiSzLength;
        private char _MultiSz;
        public ReadOnlySpan<char> MultiSz => TrailingArray<char>.GetBufferInBytes(in _MultiSz, MultiSzLength);
    }
}