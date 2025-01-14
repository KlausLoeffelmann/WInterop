﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WInterop.Storage
{
    /// <summary>
    ///  Used to get information on a named pipe that is associated with the end of the pipe
    ///  that is being queried. [FILE_PIPE_LOCAL_INFORMATION]
    /// </summary>
    /// <remarks>
    /// <see cref="https://msdn.microsoft.com/en-us/library/windows/hardware/ff728846.aspx"/>
    /// <see cref="https://msdn.microsoft.com/en-us/library/cc232083.aspx"/>
    /// </remarks>
    public readonly struct PipeLocalInformation
    {
        /// <summary>
        ///  Type of the named pipe (stream or message).
        /// </summary>
        public readonly PipeType NamedPipeType;

        /// <summary>
        ///  The pipe configuration (inbound, outbound, or full-duplex).
        /// </summary>
        public readonly PipeConfiguration NamedPipeConfiguration;

        /// <summary>
        ///  The maximum number of instances that can be createed for
        ///  the pipe. Specified by the first instance.
        /// </summary>
        public readonly uint MaximumInstances;

        /// <summary>
        ///  The current number of instances.
        /// </summary>
        public readonly uint CurrentInstances;

        /// <summary>
        ///  Inbound quota, in bytes.
        /// </summary>
        public readonly uint InboundQuota;

        /// <summary>
        ///  Amount of data available, in bytes, to be read.
        /// </summary>
        public readonly uint ReadDataAvailable;

        /// <summary>
        ///  Outbound quota, in bytes.
        /// </summary>
        public readonly uint OutboundQuota;

        /// <summary>
        ///  Write quota, in bytes.
        /// </summary>
        public readonly uint WriteQuotaAvailable;

        /// <summary>
        ///  Current state of the pipe.
        /// </summary>
        public readonly PipeState NamedPipeState;

        /// <summary>
        ///  Which end of the pipe.
        /// </summary>
        public readonly PipeEnd NamedPipeEnd;
    }
}