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
        KeyboardHook hook = new KeyboardHook();

        public TestForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            hook.Install();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            hook.Uninstall();
        }
    }
}
