// this sample installs a keyboard hook

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsManipulations.Infrastructure;

namespace WindowsManipulations
{
    public class MyScreenSaverHooker
    {
        private HookProc myCallbackDelegate = null;
        private MainForm m_Form;

        public MyScreenSaverHooker(MainForm form)
        {
            m_Form = form;

            // initialize our delegate
            this.myCallbackDelegate = new HookProc(this.MyCallbackFunction);

            // setup a keyboard hook
            SetWindowsHookEx(HookType.WH_KEYBOARD, this.myCallbackDelegate, IntPtr.Zero, AppDomain.GetCurrentThreadId());
        }

        [DllImport("user32.dll")]
        protected static extern IntPtr SetWindowsHookEx(HookType code, HookProc func, IntPtr hInstance, int threadID);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32")]
        private static extern void LockWorkStation();

        private IntPtr MyCallbackFunction(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code < 0)
            {
                //you need to call CallNextHookEx without further processing
                //and return the value returned by CallNextHookEx
                return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
            }
            // we can convert the 2nd parameter (the key code) to a System.Windows.Forms.Keys enum constant
            Keys keyPressed = (Keys)wParam.ToInt32();
            if (m_Form.ScreenSaverHooking)
            {
                m_Form.Lock();
            }
            //return the value returned by CallNextHookEx
            return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
        }
    }
}