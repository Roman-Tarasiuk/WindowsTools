﻿using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace User32Helper
{
    public class DesktopWindow
    {
        public IntPtr Handle { get; set; }
        public int ProcessId { get; set; }
        public string Title { get; set; }
        public bool IsVisible { get; set; }
        public Icon Icon { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var other = obj as DesktopWindow;

            if (other == null)
            {
                return false;
            }

            return (other.Handle == this.Handle)
                && (other.Title == this.Title);
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct COLORREF
    {
        public COLORREF(byte r, byte g, byte b)
        {
            this.Value = 0;
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public COLORREF(uint value)
        {
            this.R = 0;
            this.G = 0;
            this.B = 0;
            this.Value = value & 0x00FFFFFF;
        }

        [FieldOffset(0)]
        public byte R;
        [FieldOffset(1)]
        public byte G;
        [FieldOffset(2)]
        public byte B;

        [FieldOffset(0)]
        public uint Value;
    }

    public class User32Windows
    {
        public delegate bool Win32Callback(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "GetWindowText",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);

        public static string GetWindowText(IntPtr hWnd, int length)
        {
            var titleStrBuild = new StringBuilder(length);
            User32Windows.GetWindowText(hWnd, titleStrBuild, length + 1);

            return titleStrBuild.ToString();
        }

        [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDesktopWindows(IntPtr hDesktop, Win32Callback lpEnumCallbackFunction,
            IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool EnumThreadWindows(IntPtr threadId, Win32Callback lpEnumCallbackFunction,
            IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool EnumChildWindows(IntPtr hwnd, Win32Callback lpEnumCallbackFunction,
            IntPtr lParam);
        
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern IntPtr GetClassName(IntPtr hWnd, System.Text.StringBuilder lpClassName, int nMaxCount);

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern int PostMessage(IntPtr hWnd, int uMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool CloseWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);

        [DllImport("user32.dll")]
        public static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out int ProcessId);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern bool IsWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowText(IntPtr hWnd, string title);

        [DllImport("Gdi32.dll")]
        public static extern IntPtr SetTextColor(IntPtr hdc, COLORREF c);

        [DllImport("User32.dll")]
        public static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32")]
        public static extern void LockWorkStation();

        [DllImport("user32")]
        public static extern void RegisterHotKey(IntPtr hwnd, int id, int modifiers, int vk);

        [DllImport("user32.dll")]
        public static extern IntPtr GetNextWindow(IntPtr hWnd, int wCmd);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string ClassName, string WindowName);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32.dll", ExactSpelling = true)]
        public static extern IntPtr GetAncestor(IntPtr hwnd, int flags);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        public static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        public const int HWND_BOTTOM = 1;
        public const int HWND_NOTOPMOST = -2;
        public const int HWND_TOP = 0;
        public const int HWND_TOPMOST = -1;

        public static IntPtr HWND_BROADCAST = (IntPtr)0xffff;

        public const int SWP_ASYNCWINDOWPOS = 0x4000;
        public const int SWP_DEFERERASE = 0x2000;
        public const int SWP_DRAWFRAME = 0x0020;
        public const int SWP_FRAMECHANGED = 0x0020;
        public const int SWP_HIDEWINDOW = 0x0080;
        public const int SWP_NOACTIVATE = 0x0010;
        public const int SWP_NOCOPYBITS = 0x0100;
        public const int SWP_NOMOVE = 0x0002;
        public const int SWP_NOOWNERZORDER = 0x0200;
        public const int SWP_NOREDRAW = 0x0008;
        public const int SWP_NOREPOSITION = 0x0200;
        public const int SWP_NOSENDCHANGING = 0x0400;
        public const int SWP_NOSIZE = 0x0001;
        public const int SWP_NOZORDER = 0x0004;
        public const int SWP_SHOWWINDOW = 0x0040;

        public const int SW_HIDE = 0;
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_SHOW = 5;
        public const int SW_MINIMIZE = 6;
        public const int SW_RESTORE = 9;

        public const int WM_SETTEXT = 0x000c;
        public const int WM_CLOSE = 0x0010;
        public const int WM_NCPAINT = 0x85;
        public const int WM_HOTKEY = 0x0312;

        public const int WM_SYSCOMMAND = 0x0112;

        public static int SC_MONITORPOWER = 0xF170;

        public const int VK_OEM_3 = 0xC0;
        public const int MOD_CONTROL = 0x0002;

        public static int LParamDisplayLowPower = 1;
        public static int LParamDisplayShutOff = 2;
        public static int LParamDisplayTurnOn = -1;

        public const int GW_HWNDNEXT = 2;
        public const int GW_HWNDPREV = 3;

        public const int GA_PARENT = 1;
        public const int GA_ROOT = 2;
        public const int GA_ROOTOWNER = 3;

        public const int GWL_EXSTYLE = -20;
        public const int GWL_HINSTANCE = -6;
        public const int GWL_ID = -12;
        public const int GWL_STYLE = -16;
        public const int GWL_USERDATA = -21;
        public const int GWL_WNDPROC = -4;

        public const long WS_EX_APPWINDOW = 0x00040000L;
        public const long WS_EX_TOOLWINDOW = 0x00000080L;

        public static List<DesktopWindow> GetDesktopWindows(bool visibleOnly = true, List<string> exceptNames = null, bool getIcons = true)
        {
            var collection = new List<DesktopWindow>();

            Win32Callback AcquireMatchingWindows = delegate (IntPtr hWnd, IntPtr lParam)
            {
                Tuple<bool, string> isVisibleAndHasTitle = WindowVisibilityAndTitle(hWnd);

                var isVisible = isVisibleAndHasTitle.Item1;

                if (visibleOnly && (!isVisible))
                {
                    // Current window does not match, continue enumeration.
                    return true;
                }

                var title = isVisibleAndHasTitle.Item2;

                if (exceptNames != null && exceptNames.IndexOf(title) != -1)
                {
                    return true;
                }

                Icon icon = getIcons ? GetIcon(hWnd) : null;


                int processId;
                User32Windows.GetWindowThreadProcessId(hWnd, out processId);

                collection.Add(new DesktopWindow
                {
                    Handle = hWnd,
                    ProcessId = processId,
                    Title = title,
                    IsVisible = isVisible,
                    Icon = icon
                });

                return true;
            };

            EnumDesktopWindows(IntPtr.Zero, AcquireMatchingWindows, IntPtr.Zero);

            return collection;
        }

        private static bool EnumWindow(IntPtr handle, IntPtr pointer)
        {
            GCHandle gch = GCHandle.FromIntPtr(pointer);
            List<IntPtr> list = gch.Target as List<IntPtr>;
            if (list == null)
                throw new InvalidCastException("GCHandle Target could not be cast as List<IntPtr>");
            list.Add(handle);
            return true;
        }

        public static List<IntPtr> GetChildWindows(IntPtr parent)
        {
            List<IntPtr> result = new List<IntPtr>();
            GCHandle listHandle = GCHandle.Alloc(result);
            try
            {
                Win32Callback childProc = new Win32Callback(EnumWindow);
                EnumChildWindows(parent, childProc, GCHandle.ToIntPtr(listHandle));
            }
            finally
            {
                if (listHandle.IsAllocated)
                    listHandle.Free();
            }
            return result;
        }

        public static string GetWinClass(IntPtr hwnd)
        {
            if (hwnd == IntPtr.Zero)
                return null;
            StringBuilder classname = new StringBuilder(100);
            IntPtr result = GetClassName(hwnd, classname, classname.Capacity);
            if (result != IntPtr.Zero)
                return classname.ToString();
            return null;
        }

        public static IEnumerable<IntPtr> EnumAllWindows(IntPtr hwnd, string childClassName)
        {
            List<IntPtr> children = GetChildWindows(hwnd);
            if (children == null)
                yield break;
            foreach (IntPtr child in children)
            {
                if (GetWinClass(child) == childClassName)
                    yield return child;
                foreach (var childchild in EnumAllWindows(child, childClassName))
                    yield return childchild;
            }
        }

        public static Icon GetIcon(IntPtr hWnd)
        {
            try
            {
                var path = NativeMethods.GetProcessPath(hWnd);
                var icon = Icon.ExtractAssociatedIcon(path);

                return icon;
            }
            catch
            {
                return null;
            }
        }

        public static DesktopWindow GetLastActiveWindow(bool visibleOnly = true,
            IntPtr hwndExcept = default(IntPtr),
            bool skipExcepaAllProcessWindows = true,
            List<string> exceptNames = null)
        {
            DesktopWindow result = null;

            Win32Callback AcquireMatchingWindows = delegate (IntPtr hWnd, IntPtr lParam)
            {
                Tuple<bool, string> isVisibleAndHasTitle = WindowVisibilityAndTitle(hWnd);

                var isVisible = isVisibleAndHasTitle.Item1;
                var title = isVisibleAndHasTitle.Item2;

                if (visibleOnly && (!isVisible))
                {
                    // Current window does not match, continue enumeration.
                    return true;
                }

                if (exceptNames != null && exceptNames.IndexOf(title) != -1)
                {
                    return true;
                }

                if (hwndExcept != IntPtr.Zero)
                {
                    if (hWnd == hwndExcept)
                    {
                        return true;
                    }
                    else if (skipExcepaAllProcessWindows)
                    {
                        int procId1, procId2;
                        GetWindowThreadProcessId(hWnd, out procId1);
                        GetWindowThreadProcessId(hwndExcept, out procId2);

                        if (procId1 == procId2)
                        {
                            return true;
                        }
                    }
                }

                Icon icon = null;
                try
                {
                    var path = NativeMethods.GetProcessPath(hWnd);
                    icon = Icon.ExtractAssociatedIcon(path);
                }
                catch { }

                result = new DesktopWindow
                {
                    Handle = hWnd,
                    Title = title,
                    IsVisible = isVisible,
                    Icon = icon
                };

                return false;
            };

            EnumDesktopWindows(IntPtr.Zero, AcquireMatchingWindows, IntPtr.Zero);

            return result;
        }

        public static Tuple<bool, string> WindowVisibilityAndTitle(IntPtr hWnd)
        {
            string title = GetWindowText(hWnd, 255);

            var isVisible = (!string.IsNullOrEmpty(title)) && IsWindowVisible(hWnd);

            return new Tuple<bool, string>(isVisible, title);
        }

        public static void ShowForm(Form form)
        {
            form.Show();
            User32Windows.ShowWindow(form.Handle, User32Windows.SW_RESTORE);
            User32Windows.SetForegroundWindow(form.Handle);
        }

        public static Form GetForm(Form f, Type t)
        {
            if (f == null || f.IsDisposed)
            {
                f = (Form)Activator.CreateInstance(t);
            }

            return f;
        }

        public static void CloseForm(Form f)
        {
            if (f != null && !f.IsDisposed)
            {
                f.Close();
            }
        }
    }
}
