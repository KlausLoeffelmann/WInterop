﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace WInterop.Windows
{
    // https://msdn.microsoft.com/en-us/library/windows/desktop/ms644949.aspx
    public delegate void SendAsyncProcedure(
        WindowHandle hwnd,
        MessageType uMsg,
        UIntPtr dwData,
        LResult result);
}