using System;
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
        public delegate bool EnumDelegate(IntPtr hWnd, int lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "GetWindowText",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);

        [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDelegate lpEnumCallbackFunction,
            IntPtr lParam);

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

        public static List<DesktopWindow> GetDesktopWindows(bool visibleOnly = true)
        {
            var collection = new List<DesktopWindow>();

            EnumDelegate filter = delegate (IntPtr hWnd, int lParam)
            {
                var result = new StringBuilder(255);
                GetWindowText(hWnd, result, result.Capacity + 1);
                string title = result.ToString();

                var isVisible = !string.IsNullOrEmpty(title) && IsWindowVisible(hWnd);

                if (visibleOnly && (!isVisible))
                {
                    return true;
                }

                Icon icon = null;
                try
                {
                    var path = NativeMethods.GetProcessPath(hWnd);
                    icon = Icon.ExtractAssociatedIcon(path);
                }
                catch { }

                collection.Add(new DesktopWindow {
                    Handle = hWnd,
                    Title = title,
                    IsVisible = isVisible,
                    Icon = icon });

                return true;
            };

            EnumDesktopWindows(IntPtr.Zero, filter, IntPtr.Zero);
            return collection;
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
