﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using FluentAssertions;
using Tests.Support;
using WInterop.Storage;
using WInterop.Support;
using Xunit;

namespace DesktopTests.File
{
    public class CreateDirectTests
    {
        [Fact]
        public void CreateRelativeToDirectoryHandle()
        {
            using (var cleaner = new TestFileCleaner())
            {
                string fileName = System.IO.Path.GetRandomFileName();
                using (var directory = Storage.CreateDirectoryHandle(cleaner.TempFolder))
                {
                    directory.IsInvalid.Should().BeFalse();

                    using (var file = Storage.CreateFileRelative(fileName, directory, CreateDisposition.Create))
                    {
                        file.IsInvalid.Should().BeFalse();
                    }

                    Storage.FileExists(Paths.Combine(cleaner.TempFolder, fileName)).Should().BeTrue();
                }
            }
        }

        [Fact]
        public void CreateFileDirect()
        {
            using (var cleaner = new TestFileCleaner())
            {
                using (var file = Storage.CreateFileDirect(@"\??\" + cleaner.GetTestPath(), CreateDisposition.Create))
                {
                    file.IsInvalid.Should().BeFalse();
                }
            }
        }

        [Fact]
        public void OpenFileDirect()
        {
            using (var cleaner = new TestFileCleaner())
            {
                string path = cleaner.CreateTestFile(nameof(OpenFileDirect));
                using (var file = Storage.CreateFileDirect(@"\??\" + path, CreateDisposition.Open))
                {
                    file.IsInvalid.Should().BeFalse();
                }
            }
        }

        [Fact]
        public void OpenFileDirect_WithSpan()
        {
            using (var cleaner = new TestFileCleaner())
            {
                string path = @"\??\" + cleaner.CreateTestFile(nameof(OpenFileDirect_WithSpan));
                string wrongPath =  path + "foo";
                using (var file = Storage.CreateFileDirect(wrongPath.AsSpan().Slice(0, path.Length), CreateDisposition.Open))
                {
                    file.IsInvalid.Should().BeFalse();
                }
            }
        }

        [Fact]
        public void OpenDirectoryDirect()
        {
            using (var cleaner = new TestFileCleaner())
            {
                using (var directory = Storage.CreateDirectoryHandle(cleaner.TempFolder))
                {
                    directory.IsInvalid.Should().BeFalse("can open the root directory");

                    string name = System.IO.Path.GetRandomFileName();
                    string path = Paths.Combine(cleaner.TempFolder, name);
                    Storage.CreateDirectory(path);

                    using (var subdir = Storage.CreateDirectoryHandle(directory, name))
                    {
                        subdir.IsInvalid.Should().BeFalse("can open subdir from handle");
                    }
                }
            }
        }

        [Fact]
        public void CreateDirectoryDirect()
        {
            using (var cleaner = new TestFileCleaner())
            {
                using (var directory = Storage.CreateDirectoryHandle(cleaner.TempFolder))
                {
                    directory.IsInvalid.Should().BeFalse();

                    string name = System.IO.Path.GetRandomFileName();
                    using (var subdir = Storage.CreateDirectory(directory, name))
                    {
                        subdir.IsInvalid.Should().BeFalse();
                        Storage.DirectoryExists(Paths.Combine(cleaner.TempFolder, name)).Should().BeTrue();
                    }
                }
            }
        }
    }
}