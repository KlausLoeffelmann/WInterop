﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using WInterop.Gdi.Native;
using WInterop.Windows;

namespace WInterop.Gdi
{
    public class Metafile : IDisposable
    {
        private readonly HENHMETAFILE _hemf;

        public Metafile(HENHMETAFILE hemf) => _hemf = hemf;

        public static implicit operator HENHMETAFILE(Metafile metafile) => metafile._hemf;

        public unsafe void Enumerate(
            EnumerateMetafileCallback callback,
            nint callbackParameter = default)
        {
            GdiImports.EnumEnhMetaFile(
                default,
                _hemf,
                (
                    HDC hdc,
                    HGDIOBJ* lpht,
                    ENHMETARECORD* lpmr,
                    int nHandles,
                    LParam data) =>
                {
                    MetafileRecord record = new MetafileRecord(lpmr);
                    return callback(ref record, callbackParameter);
                },
                callbackParameter,
                null);
        }

        public void Dispose()
        {
            GdiImports.DeleteEnhMetaFile(_hemf);
        }
    }
}