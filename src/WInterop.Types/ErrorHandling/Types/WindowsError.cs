﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WInterop.ErrorHandling.Types
{
    /// <summary>
    /// Windows error defines.
    /// </summary>
    public enum WindowsError : uint
    {
        // From winerror.h
        // https://msdn.microsoft.com/en-us/library/windows/desktop/ms681382.aspx
        NO_ERROR = 0,
        ERROR_SUCCESS = 0,
        NERR_Success = 0,
        ERROR_INVALID_FUNCTION = 1,
        ERROR_FILE_NOT_FOUND = 2,
        ERROR_PATH_NOT_FOUND = 3,
        ERROR_TOO_MANY_OPEN_FILES = 4,
        ERROR_ACCESS_DENIED = 5,
        ERROR_INVALID_HANDLE = 6,
        ERROR_ARENA_TRASHED = 7,
        ERROR_NOT_ENOUGH_MEMORY = 8,
        ERROR_INVALID_BLOCK = 9,
        ERROR_BAD_ENVIRONMENT = 10,
        ERROR_BAD_FORMAT = 11,
        ERROR_INVALID_ACCESS = 12,
        ERROR_INVALID_DATA = 13,
        ERROR_OUTOFMEMORY = 14,
        ERROR_INVALID_DRIVE = 15,
        ERROR_CURRENT_DIRECTORY = 16,
        ERROR_NOT_SAME_DEVICE = 17,
        ERROR_NO_MORE_FILES = 18,
        ERROR_WRITE_PROTECT = 19,
        ERROR_BAD_UNIT = 20,
        ERROR_NOT_READY = 21,
        ERROR_BAD_COMMAND = 22,
        ERROR_CRC = 23,
        ERROR_BAD_LENGTH = 24,
        ERROR_SEEK = 25,
        ERROR_NOT_DOS_DISK = 26,
        ERROR_SECTOR_NOT_FOUND = 27,
        ERROR_OUT_OF_PAPER = 28,
        ERROR_WRITE_FAULT = 29,
        ERROR_READ_FAULT = 30,
        ERROR_GEN_FAILURE = 31,
        ERROR_SHARING_VIOLATION = 32,
        ERROR_LOCK_VIOLATION = 33,
        ERROR_WRONG_DISK = 34,
        ERROR_SHARING_BUFFER_EXCEEDED = 36,
        ERROR_HANDLE_EOF = 38,
        ERROR_HANDLE_DISK_FULL = 39,
        ERROR_NOT_SUPPORTED = 50,
        ERROR_REM_NOT_LIST = 51,
        ERROR_DUP_NAME = 52,
        ERROR_BAD_NETPATH = 53,
        ERROR_NETWORK_BUSY = 54,
        ERROR_DEV_NOT_EXIST = 55,
        ERROR_TOO_MANY_CMDS = 56,
        ERROR_ADAP_HDW_ERR = 57,
        ERROR_BAD_NET_RESP = 58,
        ERROR_UNEXP_NET_ERR = 59,
        ERROR_BAD_REM_ADAP = 60,
        ERROR_PRINTQ_FULL = 61,
        ERROR_NO_SPOOL_SPACE = 62,
        ERROR_PRINT_CANCELLED = 63,
        ERROR_NETNAME_DELETED = 64,
        ERROR_NETWORK_ACCESS_DENIED = 65,
        ERROR_BAD_DEV_TYPE = 66,
        ERROR_BAD_NET_NAME = 67,
        ERROR_TOO_MANY_NAMES = 68,
        ERROR_TOO_MANY_SESS = 69,
        ERROR_SHARING_PAUSED = 70,
        ERROR_REQ_NOT_ACCEP = 71,
        ERROR_REDIR_PAUSED = 72,
        ERROR_FILE_EXISTS = 80,
        ERROR_CANNOT_MAKE = 82,
        ERROR_FAIL_I24 = 83,
        ERROR_OUT_OF_STRUCTURES = 84,
        ERROR_ALREADY_ASSIGNED = 85,
        ERROR_INVALID_PASSWORD = 86,
        ERROR_INVALID_PARAMETER = 87,
        ERROR_NET_WRITE_FAULT = 88,
        ERROR_NO_PROC_SLOTS = 89,
        ERROR_TOO_MANY_SEMAPHORES = 100,
        ERROR_EXCL_SEM_ALREADY_OWNED = 101,
        ERROR_SEM_IS_SET = 102,
        ERROR_TOO_MANY_SEM_REQUESTS = 103,
        ERROR_INVALID_AT_INTERRUPT_TIME = 104,
        ERROR_SEM_OWNER_DIED = 105,
        ERROR_SEM_USER_LIMIT = 106,
        ERROR_DISK_CHANGE = 107,
        ERROR_DRIVE_LOCKED = 108,
        ERROR_BROKEN_PIPE = 109,
        ERROR_OPEN_FAILED = 110,
        ERROR_BUFFER_OVERFLOW = 111,
        ERROR_DISK_FULL = 112,
        ERROR_NO_MORE_SEARCH_HANDLES = 113,
        ERROR_INVALID_TARGET_HANDLE = 114,
        ERROR_INVALID_CATEGORY = 117,
        ERROR_INVALID_VERIFY_SWITCH = 118,
        ERROR_BAD_DRIVER_LEVEL = 119,
        ERROR_CALL_NOT_IMPLEMENTED = 120,
        ERROR_SEM_TIMEOUT = 121,
        ERROR_INSUFFICIENT_BUFFER = 122,
        ERROR_INVALID_NAME = 123,
        ERROR_INVALID_LEVEL = 124,
        ERROR_NO_VOLUME_LABEL = 125,
        ERROR_MOD_NOT_FOUND = 126,
        ERROR_PROC_NOT_FOUND = 127,
        ERROR_WAIT_NO_CHILDREN = 128,
        ERROR_CHILD_NOT_COMPLETE = 129,
        ERROR_DIRECT_ACCESS_HANDLE = 130,
        ERROR_NEGATIVE_SEEK = 131,
        ERROR_SEEK_ON_DEVICE = 132,
        ERROR_IS_JOIN_TARGET = 133,
        ERROR_IS_JOINED = 134,
        ERROR_IS_SUBSTED = 135,
        ERROR_NOT_JOINED = 136,
        ERROR_NOT_SUBSTED = 137,
        ERROR_JOIN_TO_JOIN = 138,
        ERROR_SUBST_TO_SUBST = 139,
        ERROR_JOIN_TO_SUBST = 140,
        ERROR_SUBST_TO_JOIN = 141,
        ERROR_BUSY_DRIVE = 142,
        ERROR_SAME_DRIVE = 143,
        ERROR_DIR_NOT_ROOT = 144,
        ERROR_DIR_NOT_EMPTY = 145,
        ERROR_IS_SUBST_PATH = 146,
        ERROR_IS_JOIN_PATH = 147,
        ERROR_PATH_BUSY = 148,
        ERROR_IS_SUBST_TARGET = 149,
        ERROR_SYSTEM_TRACE = 150,
        ERROR_INVALID_EVENT_COUNT = 151,
        ERROR_TOO_MANY_MUXWAITERS = 152,
        ERROR_INVALID_LIST_FORMAT = 153,
        ERROR_LABEL_TOO_LONG = 154,
        ERROR_TOO_MANY_TCBS = 155,
        ERROR_SIGNAL_REFUSED = 156,
        ERROR_DISCARDED = 157,
        ERROR_NOT_LOCKED = 158,
        ERROR_BAD_THREADID_ADDR = 159,
        ERROR_BAD_ARGUMENTS = 160,
        ERROR_BAD_PATHNAME = 161,
        ERROR_ALREADY_EXISTS = 183,
        ERROR_INVALID_FLAG_NUMBER = 186,
        ERROR_ENVVAR_NOT_FOUND = 203,
        ERROR_FILENAME_EXCED_RANGE = 206,
        ERROR_MORE_DATA = 234,
        ERROR_NO_MORE_ITEMS = 259,
        ERROR_MR_MID_NOT_FOUND = 317,
        ERROR_OPERATION_ABORTED = 995,
        ERROR_NO_TOKEN = 1008,
        ERROR_NOT_FOUND = 1168,
        ERROR_CANCELLED = 1223,
        ERROR_REQUEST_ABORTED = 1235,
        ERROR_CONNECTION_ABORTED = 1236,
        ERROR_PRIVILEGE_NOT_HELD = 1314,
        ERROR_NONE_MAPPED = 1332,
        ERROR_DISK_CORRUPT = 1393,
        ERROR_CLASS_ALREADY_EXISTS = 1410,
        ERROR_CLASS_DOES_NOT_EXIST = 1411,
        ERROR_CLASS_HAS_WINDOWS = 1412,
        ERROR_INVALID_INDEX = 1413,
        ERROR_INVALID_ICON_HANDLE = 1414,

        // From lmerr.h
        NERR_BASE = 2100,
        NERR_BufTooSmall = NERR_BASE + 23,
        NERR_InvalidComputer = NERR_BASE + 251,

        ERROR_REQUEST_PAUSED = 3050,

        ERROR_NOT_APPCONTAINER = 4250,
        ERROR_APPCONTAINER_REQUIRED = 4251,
        ERROR_NOT_SUPPORTED_IN_APPCONTAINER = 4252,

        APPMODEL_ERROR_NO_APPLICATION = 15703,

        FVE_E_LOCKED_VOLUME = 0x80310000,
    }
}
