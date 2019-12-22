using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class FormGetWindow : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out IntPtr lpdwProcessId);

        private IntPtr GetWindowProcessID(IntPtr hwnd)
        {
            GetWindowThreadProcessId(hwnd, out IntPtr pid);
            return pid;
        }

        private KeyboardHook hook = new KeyboardHook();
        
        private string windowProcess;

        public string WindowProcess
        {
            get { return windowProcess; }
        }

        private string windowTitle;

        public string WindowTitle
        {
            get { return windowTitle; }
        }

        public DialogResult Result { get; set; }

        public FormGetWindow()
        {
            InitializeComponent();

            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressedAsync);
            hook.RegisterHotKey(0, Keys.Enter);
        }

        private void hook_KeyPressedAsync(object sender, KeyPressedEventArgs e)
        {
            IntPtr hwnd = GetForegroundWindow();
            windowTitle = GetActiveWindowTitle();
            windowProcess = Process.GetProcessById((int)GetWindowProcessID(hwnd)).ProcessName;

            Result = DialogResult.OK;
            this.Close();
        }

        private void FormGetWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            hook.DisposeAllKeys();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
