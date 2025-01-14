﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

namespace WInterop.Cryptography
{
    // https://msdn.microsoft.com/en-us/library/windows/desktop/aa376056.aspx
    public delegate bool CertEnumPhysicalStoreCallback(
        IntPtr pvSystemStore,
        uint dwFlags,
        IntPtr pwszStoreName,
        IntPtr pStoreInfo,
        IntPtr pvReserved,
        IntPtr pvArg);
}