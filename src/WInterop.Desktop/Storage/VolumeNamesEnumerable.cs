﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using WInterop.Errors;
using WInterop.Storage.Native;
using WInterop.Support.Buffers;

namespace WInterop.Storage
{
    /// <summary>
    ///  Encapsulates a finding volume names.
    /// </summary>
    public sealed class VolumeNamesEnumerable : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator() => new VolumeNamesEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class VolumeNamesEnumerator : IEnumerator<string>
        {
            private FindVolumeHandle? _findHandle;
            private bool _lastEntryFound;
            private StringBuffer? _buffer;

            public VolumeNamesEnumerator()
            {
                _buffer = StringBuffer.Cache.Acquire();
                Current = string.Empty;
                Reset();
            }

            public string Current { get; private set; }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (_lastEntryFound) return false;

                Current = _findHandle is null
                    ? FindFirstVolume()
                    : FindNextVolume();

                return !_lastEntryFound;
            }

            private string FindFirstVolume()
            {
                if (_buffer is null)
                    throw new ObjectDisposedException(nameof(VolumeNamesEnumerator));

                _findHandle = StorageImports.FindFirstVolumeW(
                    _buffer,
                    _buffer.CharCapacity);

                if (_findHandle.IsInvalid)
                {
                    WindowsError error = Error.GetLastError();
                    if (error == WindowsError.ERROR_FILENAME_EXCED_RANGE)
                    {
                        _buffer.EnsureCharCapacity(_buffer.CharCapacity + 64);
                        return FindFirstVolume();
                    }

                    throw error.GetException();
                }

                _buffer.SetLengthToFirstNull();
                return _buffer.ToString();
            }

            private string FindNextVolume()
            {
                Debug.Assert(!(_findHandle is null));

                if (_buffer is null)
                    throw new ObjectDisposedException(nameof(VolumeNamesEnumerator));

                if (!StorageImports.FindNextVolumeW(_findHandle, _buffer, _buffer.CharCapacity))
                {
                    WindowsError error = Error.GetLastError();
                    switch (error)
                    {
                        case WindowsError.ERROR_FILENAME_EXCED_RANGE:
                            _buffer.EnsureCharCapacity(_buffer.CharCapacity + 64);
                            return FindNextVolume();
                        case WindowsError.ERROR_NO_MORE_FILES:
                            _lastEntryFound = true;
                            return string.Empty;
                        default:
                            throw error.GetException();
                    }
                }

                _buffer.SetLengthToFirstNull();
                return _buffer.ToString();
            }

            public void Reset()
            {
                CloseHandle();
                _lastEntryFound = false;
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            private void Dispose(bool disposing)
            {
                if (disposing)
                {
                    CloseHandle();
                }

                StringBuffer? buffer = Interlocked.Exchange(ref _buffer, null);
                if (buffer != null)
                    StringBuffer.Cache.Release(buffer);
            }

            private void CloseHandle()
            {
                _findHandle?.Dispose();
                _findHandle = null;
            }

            ~VolumeNamesEnumerator()
            {
                Dispose(disposing: false);
            }
        }
    }
}