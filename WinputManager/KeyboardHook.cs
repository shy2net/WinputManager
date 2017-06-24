using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WinputManager
{
    /// <summary>
    /// A low level system wide keyboard hook which can be used to listen to all mouse events across the application.
    /// </summary>
    class KeyboardHook : BaseHook
    {
        public KeyboardHook() : base(HookType.KeyboardHook)
        {

        }

        #region Structures
        public struct KeyboardHookStruct
        {
            public uint vkCode;
            public uint scanCode;
            public uint flags;
            public uint time;
            public UIntPtr dwExtraInfo;
        }
        #endregion

        protected override IntPtr OnHookCall(int nCode, IntPtr wParam, IntPtr lParam)
        {
            KeyboardHookStruct keyboardStruct = (KeyboardHookStruct) Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
            return base.OnHookCall(nCode, wParam, lParam);
        }
    }
}
