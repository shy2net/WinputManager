using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WinputManager
{
    /// <summary>
    /// A low level system wide mouse hook which can be used to listen to all mouse events across the application.
    /// </summary>
    public class MouseHook : BaseHook
    {
        public MouseHook() : base(HookType.MouseHook)
        {

        }

        #region Structures
        public struct NativePoint
        {
            public int x;
            public int y;
        }

        public struct MouseHookStruct
        {
            public NativePoint pt;
            public int mouseData;
            private int flags;
            private int time;
            private int dwExtraInfo;
        }
        #endregion

        protected override IntPtr OnHookCall(int nCode, IntPtr wParam, IntPtr lParam)
        {
            MouseHookStruct mouseStruct = (MouseHookStruct) Marshal.PtrToStructure(lParam, typeof(MouseHookStruct));
            return base.OnHookCall(nCode, wParam, lParam);
        }
    }
}
