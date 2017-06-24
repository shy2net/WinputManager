using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinputManager
{
    public partial class TestForm : Form
    {
        KeyboardHook keyboardHook = new KeyboardHook();
        MouseHook mouseHook = new MouseHook();

        public TestForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            keyboardHook.OnKeyboardEvent += KeyboardHook_OnKeyboardEvent;
            keyboardHook.Install();

            mouseHook.OnMouseEvent += MouseHook_OnMouseEvent;
            mouseHook.OnMouseMove += MouseHook_OnMouseMove;
            mouseHook.OnMouseWheelEvent += MouseHook_OnMouseWheelEvent;
            mouseHook.Install();

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            keyboardHook.Uninstall();
        }


        #region Hook events
        private bool KeyboardHook_OnKeyboardEvent(uint key, BaseHook.KeyState keyState)
        {
            LogToCapturedEvents(String.Format("{0} key was {1}", 
                ((Keys) key).ToString(), 
                keyState == BaseHook.KeyState.Keydown ? "pressed" : "released"));

            return consumeKeyboardEventsCheckBox.Checked;
        }

        private bool MouseHook_OnMouseWheelEvent(int wheelValue)
        {
            LogToCapturedEvents(String.Format("{0} mouse wheel value captured",
                wheelValue));

            return consumeMouseEventsCheckBox.Checked;
        }

        private bool MouseHook_OnMouseMove(int x, int y)
        {
            LogToCapturedEvents(String.Format("Mouse moved to: {0},{1}",
                                                                x, y));

            return consumeMouseEventsCheckBox.Checked;
        }

        private bool MouseHook_OnMouseEvent(int mouseEvent)
        {
            LogToCapturedEvents(String.Format("{0} mouse event occured", (MouseHook.MouseEvents) mouseEvent));
            return consumeMouseEventsCheckBox.Checked;
        }
        #endregion

        private void LogToCapturedEvents(string log)
        {
            capturedInputListBox.Items.Add(log);
            ScrollListBoxToBottom();
        }

        private void ScrollListBoxToBottom()
        {
            int visibleItems = capturedInputListBox.ClientSize.Height / capturedInputListBox.ItemHeight;
            capturedInputListBox.TopIndex = Math.Max(capturedInputListBox.Items.Count - visibleItems + 1, 0);
        }
    }
}
