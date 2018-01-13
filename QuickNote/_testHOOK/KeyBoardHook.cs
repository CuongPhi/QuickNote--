using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;


namespace QuickNote
{
    public class KeyBoardHook
    {
        #region Windows structure definitions      
        [StructLayout(LayoutKind.Sequential)]
        private class KeyboardHookStruct
        {
            /// <summary>
            /// Specifies a virtual-key code. The code must be a value in the range 1 to 254.
            /// </summary>
            public int vkCode;
            /// <summary>
            /// Specifies a hardware scan code for the key.
            /// </summary>
            public int scanCode;
            /// <summary>
            /// Specifies the extended-key flag, event-injected flag, context code, and transition-state flag.
            /// </summary>
            public int flags;
            /// <summary>
            /// Specifies the time stamp for this message.
            /// </summary>
            public int time;
            /// <summary>
            /// Specifies extra information associated with the message.
            /// </summary>
            public int dwExtraInfo;
        }
        #endregion

        #region Windows function imports
        /// <summary>
        /// 
        /// </summary>    
        [DllImport("user32.dll", CharSet = CharSet.Auto,
           CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int SetWindowsHookEx(
            int idHook,
            HookProc lpfn,
            IntPtr hMod,
            int dwThreadId);

        /// <summary>
        /// 
        /// </summary>
        [DllImport("user32.dll", CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int UnhookWindowsHookEx(int idHook);
        /// <summary>
        /// 
        /// </summary>
        [DllImport("user32.dll", CharSet = CharSet.Auto,
             CallingConvention = CallingConvention.StdCall)]
        private static extern int CallNextHookEx(
            int idHook,
            int nCode,
            int wParam,
            IntPtr lParam);
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// Destruction.
        /// </summary>
        ~KeyBoardHook()
        {
            Stop();
        }
        #region     events
        
        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;
        #endregion

        /// <summary>
        /// Stores the handle to the keyboard hook procedure.
        /// </summary>
        /// 
        private int hKeyboardHook = 0;
        /// <summary>
        /// Declare KeyboardHookProcedure as HookProc type.
        /// </summary>
        private static HookProc KeyboardHookProcedure;


        public void Start()
        {
            // install Keyboard hook only if it is not installed and must be installed
            if (hKeyboardHook == 0)
            {
                // Create an instance of HookProc.
                KeyboardHookProcedure = new HookProc(KeyboardHookProc);
                //install hook
                hKeyboardHook = SetWindowsHookEx(
                    WH_KEYBOARD_LL,
                    KeyboardHookProcedure,
                    Marshal.GetHINSTANCE(
                    Assembly.GetExecutingAssembly().GetModules()[0]),
                    0);
                //If SetWindowsHookEx fails.
                if (hKeyboardHook == 0)
                {
                    //do cleanup
                    Stop();
                }
            }
        }

        public void Stop()
        {
            //if keyboard hook must be uninstalled
            if (hKeyboardHook != 0)
            {   //uninstall hook
                UnhookWindowsHookEx(hKeyboardHook);
                //reset invalid handle
                hKeyboardHook = 0;
            }
        }
        private int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            bool handled = false;
            //it was ok and someone listens to events
            if ((nCode >= 0) && (KeyDown != null || KeyUp != null))
            {
                //read structure KeyboardHookStruct at lParam
                KeyboardHookStruct MyKeyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
                //raise KeyDown
                if (KeyDown != null && (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN))
                {
                    Keys keyData = (Keys)MyKeyboardHookStruct.vkCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    KeyDown(this, e);
                    handled = handled || e.Handled;
                }
                // raise KeyUp
                if (KeyUp != null && (wParam == WM_KEYUP || wParam == WM_SYSKEYUP))
                {
                    Keys keyData = (Keys)MyKeyboardHookStruct.vkCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    KeyUp(this, e);
                    handled = handled || e.Handled;
                }

            }
            //if event handled in application do not handoff to other listeners
            if (handled)
                return 1;
            else
                return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
        }
        #endregion
    }
}