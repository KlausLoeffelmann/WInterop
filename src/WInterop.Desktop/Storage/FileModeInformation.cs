﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WInterop.Storage
{
    /// <summary>
    /// <a href="https://msdn.microsoft.com/en-us/library/windows/hardware/ff545809.aspx">FILE_MODE_INFORMATION</a> structure.
    ///  Used to get the access mode for a handle through NtQueryInformationFile with FileInformationClass.FileModeInformation.
    /// </summary>
    public readonly struct FileModeInformation
    {
        public readonly FileAccessModes Mode;
    }
}