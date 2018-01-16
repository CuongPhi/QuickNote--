using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;


namespace QuickNote
{
    /// <summary>
    /// Tham khảo mã nguồn ở codeproject.com
    /// </summary>
    public class KeyBoardHook
    {
        #region Windows structure definitions      
        [StructLayout(LayoutKind.Sequential)]
        private class KeyboardHookStruct
        { 
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }
        #endregion

        #region Windows function imports
        [DllImport("user32.dll", CharSet = CharSet.Auto,
           CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int SetWindowsHookEx(
            int idHook,
            HookProc lpfn,
            IntPtr hMod,
            int dwThreadId);
        
        [DllImport("user32.dll", CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int UnhookWindowsHookEx(int idHook);
        [DllImport("user32.dll", CharSet = CharSet.Auto,
             CallingConvention = CallingConvention.StdCall)]
        private static extern int CallNextHookEx(
            int idHook,
            int nCode,
            int wParam,
            IntPtr lParam);
        private delegate int HookProc(int nCode, int wParam, IntPtr lParam);   
        #endregion

        #region Windows constants       
        private const int WH_KEYBOARD_LL = 13;

        private const int WM_KEYDOWN = 0x100;      
        private const int WM_SYSKEYDOWN = 0x104;

        private const int WM_KEYUP = 0x101;
        private const int WM_SYSKEYUP = 0x105;
        #endregion

        #region An instance of KeyBoardHook object set keyboard hooks
        public KeyBoardHook()
        {
            Start();
        }
        ~KeyBoardHook()
        {
            Stop();
        }
        #region     events
        
        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;
        #endregion
        
        private int hKeyboardHook = 0;

        private static HookProc KeyboardHookProcedure;

        public void Start()
        {
            if (hKeyboardHook == 0)
            {
                KeyboardHookProcedure = new HookProc(KeyboardHookProc);
                hKeyboardHook = SetWindowsHookEx(
                    WH_KEYBOARD_LL,
                    KeyboardHookProcedure,
                    Marshal.GetHINSTANCE(
                    Assembly.GetExecutingAssembly().GetModules()[0]),
                    0);
                if (hKeyboardHook == 0)
                {
                    Stop();
                }
            }
        }

        public void Stop()
        {
            if (hKeyboardHook != 0)
            {   
                UnhookWindowsHookEx(hKeyboardHook);               
                hKeyboardHook = 0;
            }
        }
        private int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            bool handled = false;           
            if ((nCode >= 0) && (KeyDown != null || KeyUp != null))
            {               
                KeyboardHookStruct MyKeyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
           
                if (KeyDown != null && (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN))
                {
                    Keys keyData = (Keys)MyKeyboardHookStruct.vkCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    KeyDown(this, e);
                    handled = handled || e.Handled;
                }
               
                if (KeyUp != null && (wParam == WM_KEYUP || wParam == WM_SYSKEYUP))
                {
                    Keys keyData = (Keys)MyKeyboardHookStruct.vkCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    KeyUp(this, e);
                    handled = handled || e.Handled;
                }

            } 
           
            if (handled)
                return 1;
            else
                return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
        }
        #endregion
    }
}