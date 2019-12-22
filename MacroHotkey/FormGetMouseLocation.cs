using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class FormGetMouseLocation : Form
    {
        private KeyboardHook hook = new KeyboardHook();

        public string WindowTitle { get; set; }

        private string monitor;

        public string Monitor
        {
            get { return monitor; }
        }

        private Point positionAbsolute;

        public Point PositionAbsolute
        {
            get { return positionAbsolute; }
        }

        private Point positionRelative;

        public Point PositionRelative
        {
            get { return positionRelative; }
        }

        public DialogResult Result { get; set; }

        public FormGetMouseLocation()
        {
            InitializeComponent();

            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressedAsync);
            hook.RegisterHotKey(0, Keys.Enter);
        }

        private void hook_KeyPressedAsync(object sender, KeyPressedEventArgs e)
        {
            Screen screen = Screen.FromPoint(MousePosition);
            Point screenLocation = screen.Bounds.Location;

            int absoluteX = Cursor.Position.X;
            int absoluteY = Cursor.Position.Y;

            int relativeX = Math.Abs(screenLocation.X - absoluteX);
            int relativeY = Math.Abs(screenLocation.Y - absoluteY);

            monitor = screen.DeviceName.Substring(screen.DeviceName.Length - 1);
            positionRelative = new Point(relativeX, relativeY);
            positionAbsolute = new Point(absoluteX, absoluteY);

            Result = DialogResult.OK;
            this.Close();
        }

        private void FormGetMouseLocation_FormClosing(object sender, FormClosingEventArgs e)
        {
            hook.DisposeAllKeys();
        }

        private void FormGetMouseLocation_Load(object sender, EventArgs e)
        {
            this.Text = WindowTitle;
        }
    }
}
