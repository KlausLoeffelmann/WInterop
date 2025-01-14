﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WInterop.Errors;
using WInterop.Gdi;
using WInterop.Gdi.Native;
using WInterop.Modules;

namespace WInterop.Windows.Native
{
    /// <summary>
    ///  Direct usage of Imports isn't recommended. Use the wrappers that do the heavy lifting for you.
    /// </summary>
    public static partial class WindowsImports
    {
        // https://msdn.microsoft.com/library/windows/desktop/ms633515.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern HWND GetWindow(
            HWND hWnd,
            GetWindowOption uCmd);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowtextw
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static unsafe extern int GetWindowTextW(
            HWND hWnd,
            char* lpString,
            int nMaxCount);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowtextw
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern bool SetWindowTextW(
            HWND hWnd,
            string lpString);

        // https://msdn.microsoft.com/library/windows/desktop/ms633517.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern uint GetWindowModuleFileNameW(
            HWND hwnd,
            SafeHandle lpszFileName,
            uint cchFileNameMax);

        // https://msdn.microsoft.com/library/windows/desktop/ms633522.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern uint GetWindowThreadProcessId(
            HWND hWnd,
            out uint lpdwProcessId);

        // https://msdn.microsoft.com/library/windows/desktop/ms633584.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern int GetWindowLongW(
            HWND hWnd,
            WindowLong nIndex);

        // https://msdn.microsoft.com/library/windows/desktop/ms633585.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern long GetWindowLongPtrW(
            HWND hWnd,
            WindowLong nIndex);

        // https://msdn.microsoft.com/library/windows/desktop/ms633591.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern int SetWindowLongW(
            HWND hWnd,
            WindowLong nIndex,
            int dwNewLong);

        // https://msdn.microsoft.com/library/windows/desktop/ms644898.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern long SetWindowLongPtrW(
            HWND hWnd,
            WindowLong nIndex,
            long dwNewLong);

        // https://msdn.microsoft.com/library/windows/desktop/ms633580.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern int GetClassLongW(
            HWND hWnd,
            ClassLong nIndex);

        // https://msdn.microsoft.com/library/windows/desktop/ms633581.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern long GetClassLongPtrW(
            HWND hWnd,
            ClassLong nIndex);

        // https://msdn.microsoft.com/library/windows/desktop/ms633588.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern int SetClassLongW(
            HWND hWnd,
            ClassLong nIndex,
            int dwNewLong);

        // https://msdn.microsoft.com/library/windows/desktop/ms633589.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern long SetClassLongPtrW(
            HWND hWnd,
            ClassLong nIndex,
            long dwNewLong);

        // https://msdn.microsoft.com/library/windows/desktop/ms633509.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern HWND GetNextWindow(
            HWND hWnd,
            GetWindowOption uCmd);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getparent
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern HWND GetParent(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms633502.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HWND GetAncestor(
            HWND hWnd,
            GetWindowOption gaFlags);

        // https://msdn.microsoft.com/library/windows/desktop/ms633514.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern HWND GetTopWindow(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms632673.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool BringWindowToTop(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms633545.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetWindowPos(
            HWND hWnd,
            HWND hWndInsertAfter,
            int X,
            int Y,
            int cx,
            int cy,
            WindowPositionFlags uFlags);

        // https://msdn.microsoft.com/library/windows/desktop/ms632672.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern DeferWindowPositionHandle BeginDeferWindowPos(
            int nNumWindows);

        // https://msdn.microsoft.com/library/windows/desktop/ms632681.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern DeferWindowPositionHandle DeferWindowPos(
            DeferWindowPositionHandle hWinPosInfo,
            HWND hWnd,
            HWND hWndInsertAfter,
            int X,
            int Y,
            int cx,
            int cy,
            WindowPositionFlags uFlags);

        // https://msdn.microsoft.com/library/windows/desktop/ms633440.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool EndDeferWindowPos(
            DeferWindowPositionHandle hWinPosInfo);

        // https://msdn.microsoft.com/library/windows/desktop/ms633518.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool GetWindowPlacement(
            HWND hwnd,
            ref WINDOWPLACEMENT lpwndpl);

        // https://msdn.microsoft.com/library/windows/desktop/ms633544.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetWindowPlacement(
            HWND hwnd,
            ref WINDOWPLACEMENT lpwndpl);

        // https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getwindowrect
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool GetWindowRect(
            HWND hWnd,
            ref Rect lpRect);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-movewindow
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool MoveWindow(
            HWND hWnd,
            int X,
            int Y,
            int nWidth,
            int nHeight,
            bool bRepaint);

        // https://msdn.microsoft.com/library/windows/desktop/ms646292.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HWND GetActiveWindow();

        // https://msdn.microsoft.com/library/windows/desktop/ms646311.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern HWND SetActiveWindow(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms632669.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool AnimateWindow(
            HWND hwnd,
            uint dwTime,
            WindowAnimationType dwFlags);

        // https://msdn.microsoft.com/library/windows/desktop/ms633548.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool ShowWindow(
            HWND hWnd,
            ShowWindowCommand nCmdShow);

        // https://msdn.microsoft.com/library/windows/desktop/ms633549.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool ShowWindowAsync(
            HWND hWnd,
            ShowWindowCommand nCmdShow);

        // https://msdn.microsoft.com/library/windows/desktop/ms633505.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HWND GetForegroundWindow();

        // https://msdn.microsoft.com/library/windows/desktop/ms632668.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool AllowSetForegroundWindow(
            uint dwProcessId);

        // https://msdn.microsoft.com/library/windows/desktop/ms633539.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool SetForegroundWindow(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms633532.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool LockSetForegroundWindow(
            LockCode uLockCode);

        // https://msdn.microsoft.com/library/windows/desktop/ms633512.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HWND GetShellWindow();

        // https://msdn.microsoft.com/library/windows/desktop/ms633504.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HWND GetDesktopWindow();

        // https://msdn.microsoft.com/library/windows/desktop/ms633528.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool IsWindow(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms633526.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool IsHungAppWindow(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms633527.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool IsIconic(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms633531.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool IsZoomed(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms633529.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool IsWindowUnicode(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms633530.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool IsWindowVisible(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms646303.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool IsWindowEnabled(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms646291.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool EnableWindow(
            HWND hWnd,
            bool bEnable);

        // https://msdn.microsoft.com/library/windows/desktop/ms633524.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool IsChild(
            HWND hWndParent,
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms632671.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern uint ArrangeIconicWindows(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms633525.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern int IsGUIThread(
            bool bConvert);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-registerclassw
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern Atom RegisterClassW(
            ref WNDCLASS lpWndClass);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-registerclassexw
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern Atom RegisterClassExW(
            ref WNDCLASSEX lpwcx);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-unregisterclassw
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool UnregisterClassW(
            IntPtr lpClassName,
            ModuleInstance hInstance);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getclassinfow
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern bool GetClassInfoW(
            ModuleInstance hInstance,
            IntPtr lpClassName,
            out WNDCLASS lpWndClass);

        // https://msdn.microsoft.com/library/windows/desktop/ms633579.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern bool GetClassInfoExW(
            ModuleInstance hinst,
            IntPtr lpszClass,
            out WNDCLASSEX lpwcx);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getclassnamew
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern unsafe int GetClassNameW(
            HWND hWnd,
            char* lpClassName,
            int nMaxCount);

        // https://msdn.microsoft.com/library/windows/desktop/ms632679.aspx
        // https://msdn.microsoft.com/library/windows/desktop/ms632680.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern unsafe HWND CreateWindowExW(
            ExtendedWindowStyles dwExStyle,
            char* lpClassName,
            string? lpWindowName,
            WindowStyles dwStyle,
            int x,
            int y,
            int nWidth,
            int nHeight,
            HWND hWndParent,
            HMENU hMenu,
            ModuleInstance hInstance,
            IntPtr lpParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms632682.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool DestroyWindow(
            HWND hWnd);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getsystemmetrics
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern int GetSystemMetrics(
            SystemMetric nIndex);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getsystemmetrics
        [SuppressGCTransition]
        [DllImport(Libraries.User32, EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetricsFast(
            SystemMetric nIndex);

        [SuppressGCTransition]
        [SkipLocalsInit]
        [DllImport(Libraries.User32, EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetricsFast2(
            SystemMetric nIndex);

        // https://msdn.microsoft.com/library/windows/desktop/ms724947.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern unsafe bool SystemParametersInfoW(
            SystemParameterType uiAction,
            uint uiParam,
            void* pvParam,
            SystemParameterOptions fWinIni);

        // https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getclientrect
        [SuppressGCTransition]
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static unsafe extern bool GetClientRect(
            HWND hWnd,
            Rect* lpRect);

        // Note that AdjustWindowRect simply calls this method with an extended style of 0.
        // https://msdn.microsoft.com/library/windows/desktop/ms632667.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool AdjustWindowRectEx(
            ref Rect lpRect,
            WindowStyles dwStyle,
            bool bMenu,
            ExtendedWindowStyles dwExStyle);

        // https://msdn.microsoft.com/library/windows/desktop/ms645507.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern CommandId MessageBoxExW(
            HWND hWnd,
            string lpText,
            string lpCaption,
            MessageBoxType uType,
            ushort wLanguageId);

        // https://msdn.microsoft.com/library/windows/desktop/ms644936.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern IntBoolean GetMessageW(
            out WindowMessage lpMsg,
            HWND hWnd,
            uint wMsgFilterMin,
            uint wMsgFilterMax);

        // https://msdn.microsoft.com/library/windows/desktop/ms644938.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern PointS GetMessagePos();

        // https://msdn.microsoft.com/library/windows/desktop/ms644939.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern int GetMessageTime();

        // https://msdn.microsoft.com/library/windows/desktop/ms644937.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern LParam GetMessageExtraInfo();

        // https://msdn.microsoft.com/library/windows/desktop/ms644954.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern LParam SetMessageExtraInfo(LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms644943.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool PeekMessageW(
            out WindowMessage lpMsg,
            HWND hWnd,
            uint wMsgFilterMin,
            uint wMsgFilterMax,
            PeekMessageOptions wRemoveMsg);

        // https://msdn.microsoft.com/library/windows/desktop/ms644940.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern uint GetQueueStatus(
            QueueStatus flags);

        // https://msdn.microsoft.com/library/windows/desktop/ms644950.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern LResult SendMessageW(
            HWND hWnd,
            MessageType Msg,
            WParam wParam,
            LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms644951.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SendMessageCallbackW(
            HWND hWnd,
            MessageType Msg,
            WParam wParam,
            LParam lParam,
            SendAsyncProcedure lpCallBack,
            UIntPtr dwData);

        // https://msdn.microsoft.com/library/windows/desktop/ms644952.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern LResult SendMessageTimeoutW(
            HWND hWnd,
            MessageType Msg,
            WParam wParam,
            LParam lParam,
            SendMessageTimeoutOptions fuFlags,
            uint uTimeout,
            out UIntPtr lpdwResult);

        // https://msdn.microsoft.com/library/windows/desktop/ms644953.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SendNotifyMessageW(
            HWND hWnd,
            MessageType Msg,
            WParam wParam,
            LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms644948.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool ReplyMessage(
            LResult lResult);

        // https://msdn.microsoft.com/library/windows/desktop/ms644942.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern MessageSources InSendMessageEx(
            IntPtr lpReserved);

        // https://msdn.microsoft.com/library/windows/desktop/ms644955.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool TranslateMessage(
            ref WindowMessage lpMsg);

        // https://msdn.microsoft.com/library/windows/desktop/ms644934.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool DispatchMessageW(
            ref WindowMessage lpMsg);

        // https://msdn.microsoft.com/library/windows/desktop/ms644947.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern uint RegisterWindowMessageW(
            string lpString);

        // https://msdn.microsoft.com/library/windows/desktop/ms633572.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern LResult DefWindowProcW(
            HWND hWnd,
            MessageType Msg,
            WParam wParam,
            LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms633571.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern LResult CallWindowProcW(
            WNDPROC lpPrevWndFunc,
            HWND hWnd,
            MessageType Msg,
            WParam wParam,
            LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms644944.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern bool PostMessageW(
            HWND hWnd,
            MessageType Msg,
            WParam wParam,
            LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms644946.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern bool PostThreadMessageW(
            uint idThread,
            MessageType Msg,
            WParam wParam,
            LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms644945.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern void PostQuitMessage(
            int nExitCode);

        // https://msdn.microsoft.com/library/windows/desktop/bb787585.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern int GetScrollPos(
            HWND hWnd,
            ScrollBar nBar);

        // https://msdn.microsoft.com/library/windows/desktop/bb787595.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool GetScrollInfo(
            HWND hwind,
            ScrollBar fnBar,
            [In] ref ScrollInfo lpsi);

        // https://msdn.microsoft.com/library/windows/desktop/bb787599.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetScrollRange(
            HWND hWnd,
            ScrollBar nBar,
            int nMinPos,
            int nMaxPos,
            bool bRedraw);

        // https://msdn.microsoft.com/library/windows/desktop/bb787597.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern int SetScrollPos(
            HWND hWnd,
            ScrollBar nBar,
            int nPos,
            bool bRedraw);

        // https://msdn.microsoft.com/library/windows/desktop/bb787595.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern int SetScrollInfo(
            HWND hwind,
            ScrollBar fnBar,
            [In] ref ScrollInfo lpsi,
            bool fRedraw);

        // https://msdn.microsoft.com/library/windows/desktop/bb787601.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool ShowScrollBar(
            HWND hWnd,
            ScrollBar wBar,
            bool bShow);

        // https://msdn.microsoft.com/library/windows/desktop/bb787593.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern unsafe int ScrollWindowEx(
            HWND hWnd,
            int dx,
            int dy,
            Rect* prcScroll,
            Rect* prcClip,
            IntPtr hrgnUpdate,
            Rect* prcUpdate,
            ScrollWindowFlags flags);

        // https://msdn.microsoft.com/library/windows/desktop/ms646293.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern short GetAsyncKeyState(
            [MarshalAs(UnmanagedType.I4)]
            VirtualKey vKey);

        // https://msdn.microsoft.com/library/windows/desktop/ms646294.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HWND GetFocus();

        // https://msdn.microsoft.com/library/windows/desktop/ms646312.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern HWND SetFocus(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms724336.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern int GetKeyboardType(
            int nTypeFlag);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getkeynametextw
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern unsafe int GetKeyNameTextW(
            int lParam,
            char* lpString,
            int cchSize);

        // https://msdn.microsoft.com/library/windows/desktop/ms646301.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern KeyState GetKeyState(
            [MarshalAs(UnmanagedType.I4)]
            VirtualKey vKey);

        // https://msdn.microsoft.com/library/windows/desktop/ms646302.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool GetLastInputInfo(
            ref LastInputInfo plii);

        // https://msdn.microsoft.com/library/windows/desktop/ms644935.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool GetInputState();

        // https://msdn.microsoft.com/library/windows/desktop/ms645441.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern HWND CreateDialogIndirectParamW(
            ModuleInstance hInstance,
            SafeHandle lpTemplate,
            HWND hWndParent,
            DialogProcedure lpDialogFunc,
            LParam lParamInit);

        // https://msdn.microsoft.com/library/windows/desktop/ms645445.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern HWND CreateDialogParamW(
            ModuleInstance hInstance,
            string lpTemplateName,
            HWND hWndParent,
            DialogProcedure lpDialogFunc,
            LParam dwInitParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms645450.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern LResult DefDlgProcW(
            HWND hDlg,
            MessageType Msg,
            WParam wParam,
            LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms645461.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr DialogBoxIndirectParamW(
            ModuleInstance hInstance,
            SafeHandle hDialogTemplate,
            HWND hWndParent,
            DialogProcedure lpDialogFunc,
            LParam dwInitParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms645465.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr DialogBoxParamW(
            ModuleInstance hInstance,
            string lpTemplateName,
            HWND hWndParent,
            DialogProcedure lpDialogFunc,
            LParam dwInitParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms645472.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool EndDialog(
            HWND hDlg,
            IntPtr nResult);

        // https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getdialogbaseunits
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern int GetDialogBaseUnits();

        // https://msdn.microsoft.com/library/windows/desktop/ms645478.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern int GetDlgCtrlID(
            HWND hwndCtl);

        // https://msdn.microsoft.com/library/windows/desktop/ms645481.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern HWND GetDlgItem(
            HWND hDlg,
            int nIDDlgItem);

        // https://msdn.microsoft.com/library/windows/desktop/ms645485.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern uint GetDlgItemInt(
            HWND hDlg,
            int nIDDlgItem,
            ref bool lpTranslated,
            bool bSigned);

        // https://msdn.microsoft.com/library/windows/desktop/ms645489.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern uint GetDlgItemTextW(
            HWND hDlg,
            int nIDDlgItem,
            SafeHandle lpString,
            int nMaxCount);

        // https://msdn.microsoft.com/library/windows/desktop/ms645492.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern HWND GetNextDlgGroupItem(
            HWND hDlg,
            HWND hCtl,
            bool bPrevious);

        // https://msdn.microsoft.com/library/windows/desktop/ms645495.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern HWND GetNextDlgTabItem(
            HWND hDlg,
            HWND hCtl,
            bool bPrevious);

        // https://msdn.microsoft.com/library/windows/desktop/ms645498.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool IsDialogMessageW(
            HWND hDlg,
            in WindowMessage lpMsg);

        // https://msdn.microsoft.com/library/windows/desktop/ms645502.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool MapDialogRect(
            HWND hDlg,
            ref Rect lpRect);

        // https://msdn.microsoft.com/library/windows/desktop/dn910915.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern string MB_GetString(
            uint wBtn);

        // https://msdn.microsoft.com/library/windows/desktop/ms645515.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern LResult SendDlgItemMessageW(
            HWND hDlg,
            int nIDDlgItem,
            MessageType Msg,
            WParam wParam,
            LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms645518.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetDlgItemInt(
            HWND hDlg,
            int nIDDlgItem,
            uint uValue,
            bool bSigned);

        // https://msdn.microsoft.com/library/windows/desktop/ms645521.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetDlgItemTextW(
            HWND hDlg,
            int nIDDlgItem,
            string lpString);

        // https://msdn.microsoft.com/library/windows/desktop/ms646256.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool DragDetect(
            HWND hwnd,
            Point pt);

        // https://msdn.microsoft.com/library/windows/desktop/ms646257.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HWND GetCapture();

        // https://msdn.microsoft.com/library/windows/desktop/ms646261.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool ReleaseCapture();

        // https://msdn.microsoft.com/library/windows/desktop/ms646262.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HWND SetCapture(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms646258.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern uint GetDoubleClickTime();

        // https://msdn.microsoft.com/library/windows/desktop/ms646263.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetDoubleClickTime(
            uint uInterval);

        // https://msdn.microsoft.com/library/windows/desktop/ms646264.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool SwapMouseButton(
            bool fSwap);

        // https://msdn.microsoft.com/library/windows/desktop/ms646259.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern int GetMouseMovePointsEx(
            uint cbSize,
            in MouseMovePoint lppt,
            MouseMovePoint[] lpptBuf,
            int nBufPoints,
            uint resolution);

        // https://msdn.microsoft.com/library/windows/desktop/ms646265.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool TrackMouseEvent(
            ref TrackMouseEvent lpEventTrack);

        // https://msdn.microsoft.com/library/windows/desktop/ms644906.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern TimerId SetTimer(
            HWND hWnd,
            TimerId nIDEvent,
            uint uElapse,
            TimerProcedure lpTimerFunc);

        // https://msdn.microsoft.com/library/windows/desktop/ms644903.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool KillTimer(
            HWND hWnd,
            TimerId uIDEvent);

        // https://msdn.microsoft.com/library/windows/desktop/hh405404.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern TimerId SetCoalescableTimer(
            HWND hWnd,
            TimerId nIdEvent,
            uint uElapse,
            TimerProcedure? lpTimerFunc,
            uint uToleranceDelay);

        // https://msdn.microsoft.com/library/windows/desktop/ms724371.aspx
        [SuppressGCTransition]
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern COLORREF GetSysColor(
            SystemColor nIndex);

        // https://msdn.microsoft.com/library/windows/desktop/bb761366.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int DlgDirListW(
            HWND hDlg,
            string lpPathSpec,
            int nIDListBox,
            int nIDStaticPath,
            FileTypes uFileType);

        // https://msdn.microsoft.com/library/windows/desktop/bb761368.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool DlgDirSelectExW(
            HWND hDlg,
            SafeHandle lpString,
            int nCount,
            int nIDListBox);

        // https://docs.microsoft.com/windows/win32/api/shlwapi/nc-shlwapi-dllgetversionproc
        [DllImport(Libraries.Comctl32, EntryPoint = "DllGetVersion")]
        public static extern HResult ComctlGetVersion(
            ref DllVersionInfo versionInfo);

        // https://msdn.microsoft.com/library/windows/desktop/bb761723.aspx
        [DllImport(Libraries.Comctl32, ExactSpelling = true)]
        public static extern void DrawInsert(
            HWND handParent,
            HWND hLB,
            int nItem);

        // https://msdn.microsoft.com/library/windows/desktop/bb761370.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern uint GetListBoxInfo(
            HWND hwnd);

        // https://msdn.microsoft.com/library/windows/desktop/bb761724.aspx
        [DllImport(Libraries.Comctl32, ExactSpelling = true)]
        public static extern int LBItemFromPt(
            HWND hLB,
            Point pt,
            bool bAutoScroll);

        // https://msdn.microsoft.com/library/windows/desktop/bb761725.aspx
        [DllImport(Libraries.Comctl32, ExactSpelling = true)]
        public static extern bool MakeDragList(
            HWND hLB);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-enumchildwindows
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool EnumChildWindows(
            HWND hWndParent,
            EnumerateWindowProcedure lpEnumFunc,
            LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms633495.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool EnumThreadWindows(
            uint dwThreadId,
            EnumerateWindowProcedure lpfn,
            LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms633497.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool EnumWindows(
            EnumerateWindowProcedure lpEnumFunc,
            LParam lParam);

        // https://msdn.microsoft.com/library/windows/desktop/ms647486.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern unsafe int LoadStringW(
            ModuleInstance hInstance,
            int uID,
            out char* lpBuffer,
            int nBufferMax);

        // https://msdn.microsoft.com/library/windows/desktop/ms648402.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool GetCaretPos(
            out Point lpPoint);

        // https://msdn.microsoft.com/library/windows/desktop/ms648405.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetCaretPos(
            int X,
            int Y);

        // https://msdn.microsoft.com/library/windows/desktop/ms648406.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool ShowCaret(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms648403.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool HideCaret(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms648399.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool CreateCaret(
            HWND hWnd,
            HBITMAP hBitmap,
            int nWidth,
            int nHeight);

        // https://msdn.microsoft.com/library/windows/desktop/ms648400.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool DestroyCaret();

        // uint.MaxValue is INFINITE, or doesn't blink
        // https://msdn.microsoft.com/library/windows/desktop/ms648401.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern uint GetCaretBlinkTime();

        // https://msdn.microsoft.com/library/windows/desktop/ms648404.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetCaretBlinkTime(
            uint uMSeconds);

        // https://msdn.microsoft.com/library/windows/desktop/ms648072.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern unsafe HICON LoadIconW(
            ModuleInstance hInstance,
            char* lpIconName);

        // https://msdn.microsoft.com/library/windows/desktop/ms648063.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool DestroyIcon(
            HICON hIcon);

        // https://msdn.microsoft.com/library/windows/desktop/ms648383.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern unsafe bool ClipCursor(
            Rect* lpRect);

        // https://msdn.microsoft.com/library/windows/desktop/ms648384.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern CursorHandle CopyCursor(
            CursorHandle pcur);

        // https://msdn.microsoft.com/library/windows/desktop/ms648385.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern CursorHandle CreateCursor(
            ModuleInstance hInst,
            int xHotSpot,
            int yHotSpot,
            int nWidth,
            int nHeight,
            byte[] pvANDPlane,
            byte[] pvXORPlane);

        // https://msdn.microsoft.com/library/windows/desktop/ms648386.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool DestroyCursor(
            HCURSOR hCursor);

        // https://msdn.microsoft.com/library/windows/desktop/ms648387.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool GetClipCursor(
            out Rect lpRect);

        // https://msdn.microsoft.com/library/windows/desktop/ms648388.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HCURSOR GetCursor();

        // https://msdn.microsoft.com/library/windows/desktop/ms648389.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool GetCursorInfo(
            ref CURSORINFO pci);

        // https://msdn.microsoft.com/library/windows/desktop/ms648390.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool GetCursorPos(
            out Point lpPoint);

        // https://msdn.microsoft.com/library/windows/desktop/aa969464.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool GetPhysicalCursorPos(
            out Point lpPoint);

        // https://msdn.microsoft.com/library/windows/desktop/ms648391.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern unsafe HCURSOR LoadCursorW(
            ModuleInstance hInstance,
            char* lpCursorName);

        // https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-loadcursorfromfilew
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern CursorHandle LoadCursorFromFileW(
            string lpFileName);

        // https://msdn.microsoft.com/library/windows/desktop/ms648393.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HCURSOR SetCursor(
            CursorHandle hCursor);

        // https://msdn.microsoft.com/library/windows/desktop/ms648394.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetCursorPos(
            int X,
            int Y);

        // https://msdn.microsoft.com/library/windows/desktop/aa969465.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetPhysicalCursorPos(
            int X,
            int Y);

        // https://msdn.microsoft.com/library/windows/desktop/ms648395.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetSystemCursor(
            CursorHandle hcur,
            SystemCursor id);

        // https://msdn.microsoft.com/library/windows/desktop/ms648396.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern int ShowCursor(
            bool bShow);

        // https://msdn.microsoft.com/library/windows/desktop/ms647616.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern bool AppendMenuW(
            HMENU hMenu,
            MenuFlags uFlags,
            IntPtr uIDNewItem,
            IntPtr lpNewItem);

        // https://msdn.microsoft.com/library/windows/desktop/ms647619.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern MenuFlags CheckMenuItem(
            HMENU hmenu,
            uint uIDCheckItem,
            MenuFlags uCheck);

        // https://msdn.microsoft.com/library/windows/desktop/ms647621.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool CheckMenuRadioItem(
            HMENU hmenu,
            uint idFirst,
            uint idLast,
            uint idCheck,
            MenuFlags uFlags);

        // https://msdn.microsoft.com/library/windows/desktop/ms647624.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern HMENU CreateMenu();

        // https://msdn.microsoft.com/library/windows/desktop/ms647626.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern HMENU CreatePopupMenu();

        // https://msdn.microsoft.com/library/windows/desktop/ms647626.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool DeleteMenu(
            HMENU hMenu,
            uint uPosition,
            MenuFlags uFlags);

        // https://msdn.microsoft.com/library/windows/desktop/ms647631.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool DestroyMenu(
            HMENU hMenu);

        // https://msdn.microsoft.com/library/windows/desktop/ms647633.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool DrawMenuBar(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms647636.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool EnableMenuItem(
            HMENU hMenu,
            uint uIDEnableItem,
            MenuFlags uEnable);

        // https://msdn.microsoft.com/library/windows/desktop/ms647637.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool EndMenu();

        // https://msdn.microsoft.com/library/windows/desktop/ms647640.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HMENU GetMenu(
            HWND hWnd);

        // https://msdn.microsoft.com/library/windows/desktop/ms647833.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool GetMenuBarInfo(
            HWND hwnd,
            MenuObject idObject,
            int idItem,
            ref MENUBARINFO pmbi);

        // https://msdn.microsoft.com/library/windows/desktop/ms647976.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern uint GetMenuDefaultItem(
            HMENU hMenu,
            bool fByPos,
            uint gmdiFlags);

        // https://msdn.microsoft.com/library/windows/desktop/ms647977.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool GetMenuInfo(
            HMENU hMenu,
            ref MENUINFO lpcmi);

        // https://msdn.microsoft.com/library/windows/desktop/ms647978.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern int GetMenuItemCount(
            HMENU hMenu);

        // https://msdn.microsoft.com/library/windows/desktop/ms647979.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern uint GetMenuItemID(
            HMENU hMenu,
            int nPos);

        // https://msdn.microsoft.com/library/windows/desktop/ms647980.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern bool GetMenuItemInfoW(
            HMENU hMenu,
            uint uItem,
            bool fByPos,
            ref MENUITEMINFO lpmii);

        // https://msdn.microsoft.com/library/windows/desktop/ms647981.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool GetMenuItemRect(
            HWND hWnd,
            HMENU hMenu,
            uint uItem,
            out Rect lprcItem);

        // https://msdn.microsoft.com/library/windows/desktop/ms647982.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern MenuFlags GetMenuState(
            HMENU hMenu,
            uint uId,
            MenuFlags uFlags);

        // https://msdn.microsoft.com/library/windows/desktop/ms647983.aspx
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int GetMenuString(
            HMENU hMenu,
            uint uIDItem,
            SafeHandle lpString,
            int nMaxCount,
            MenuFlags uFlag);

        // https://msdn.microsoft.com/library/windows/desktop/ms647984.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HMENU GetSubMenu(
            HMENU hMenu,
            int nPos);

        // https://msdn.microsoft.com/library/windows/desktop/ms647985.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HMENU GetSystemMenu(
            HWND hWnd,
            bool bRevert);

        // https://msdn.microsoft.com/library/windows/desktop/ms647986.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool HiliteMenuItem(
            HWND hwnd,
            HMENU hmenu,
            uint uItemHitite,
            MenuFlags uHilite);

        // https://msdn.microsoft.com/library/windows/desktop/ms647988.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern bool InsertMenuItemW(
            HMENU hMenu,
            uint uItem,
            bool fByPosition,
            [In] ref MENUITEMINFO lpmii);

        // https://msdn.microsoft.com/library/windows/desktop/ms647989.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern bool IsMenu(
            IntPtr hMenu);

        // https://msdn.microsoft.com/library/windows/desktop/ms647990.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern HMENU LoadMenuW(
            ModuleInstance hInstance,
            IntPtr lpMenuName);

        // https://msdn.microsoft.com/library/windows/desktop/ms647991.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern HMENU LoadMenuIndirectW(
            SafeHandle lpMenuTemplate);

        // https://msdn.microsoft.com/library/windows/desktop/ms647992.aspx
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern int MenuItemFromPoint(
            HWND hWnd,
            HMENU hMenu,
            Point ptScreen);

        // https://msdn.microsoft.com/library/windows/desktop/ms647994.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool RemoveMenu(
            HMENU hMenu,
            uint uPosition,
            MenuFlags uFlags);

        // https://msdn.microsoft.com/library/windows/desktop/ms647995.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetMenu(
            HWND hWnd,
            HMENU hMenu);

        // https://msdn.microsoft.com/library/windows/desktop/ms647996.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetMenuDefaultItem(
            HMENU hMenu,
            uint uItem,
            bool fByPos);

        // https://msdn.microsoft.com/library/windows/desktop/ms647997.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetMenuInfo(
            HMENU hmenu,
            in MENUINFO lpcmi);

        // https://msdn.microsoft.com/library/windows/desktop/ms647998.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetMenuItemBitmaps(
            HMENU hMenu,
            uint uPosition,
            MenuFlags uFlags,
            BitmapHandle hBitmapUnchecked,
            BitmapHandle hBitmapChecked);

        // https://msdn.microsoft.com/library/windows/desktop/ms648001.aspx
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern bool SetMenuItemInfoW(
            HMENU hMenu,
            uint uItem,
            bool fByPosition,
            [In] ref MENUITEMINFO lpmii);

        // https://msdn.microsoft.com/library/windows/desktop/ms648003.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern unsafe IntBoolean TrackPopupMenuEx(
            HWND hmenu,
            PopupMenuOptions fuFlags,
            int x,
            int y,
            HWND hwnd,
            TPMPARAMS* lptpm);

        // https://msdn.microsoft.com/library/windows/desktop/ms679277.aspx
        [DllImport(Libraries.User32, SetLastError = true, ExactSpelling = true)]
        public static extern bool MessageBeep(
            BeepType uType);

        // https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-monitorfrompoint
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HMONITOR MonitorFromPoint(
            Point pt,
            MonitorOption dwFlags);

        // https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-monitorfromrect
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HMONITOR MonitorFromRect(
            in Rect lprc,
            MonitorOption dwFlags);

        // https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-monitorfromwindow
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern HMONITOR MonitorFromWindow(
            HWND hwnd,
            MonitorOption dwFlags);

        // https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getmonitorinfow
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern unsafe bool GetMonitorInfoW(
            HMONITOR hMonitor,
            void* lpmi);

        // Only available after Win10 1607
        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getdpiforsystem
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern uint GetDpiForSystem();

        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern IntBoolean SetProcessDpiAwarenessContext(
            DpiAwarenessContext value);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getawarenessfromdpiawarenesscontext
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern DpiAwareness GetAwarenessFromDpiAwarenessContext(DpiAwarenessContext value);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getthreaddpiawarenesscontext
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern DpiAwarenessContext GetThreadDpiAwarenessContext();

        // https://docs.microsoft.com//windows/win32/api/winuser/nf-winuser-setthreaddpiawarenesscontext
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern DpiAwarenessContext SetThreadDpiAwarenessContext(DpiAwarenessContext dpiContext);

        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getdpiforwindow
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern uint GetDpiForWindow(HWND hwnd);

        // 1803
        // https://docs.microsoft.com/windows/win32/api/winuser/nf-winuser-getdpifromdpiawarenesscontext
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern uint GetDpiFromDpiAwarenessContext(DpiAwarenessContext value);
    }
}