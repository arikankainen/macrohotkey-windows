using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class FormAddHotkeyHelp : Arska.FormBase
    {
        private Font fontTopic = new Font("Segoe UI Semibold", 10, FontStyle.Regular);
        private Font fontNormal = new Font("Segoe UI", 8, FontStyle.Regular);
        private Font fontFixed = new Font("Consolas", 9, FontStyle.Regular);

        private Color colorTopic = ColorTranslator.FromHtml("#000000");
        private Color colorNormal = ColorTranslator.FromHtml("#000000");
        private Color colorFixed = ColorTranslator.FromHtml("#000000");

        public FormAddHotkeyHelp()
        {
            InitializeComponent();
        }

        private void timerMouse_Tick(object sender, EventArgs e)
        {

            string mouse = "Mouse position: " + Cursor.Position.X.ToString() + "," + Cursor.Position.Y.ToString();

            Screen screenPrimary = Screen.PrimaryScreen;
            Screen screen = Screen.FromPoint(MousePosition);
            mouse += " / Monitor " + screen.DeviceName.Substring(screen.DeviceName.Length - 1);
            if (screen.DeviceName == screenPrimary.DeviceName) mouse += " (Primary)";
            labelMouse.Text = mouse;
        }

        private void FormAddHotkeyHelp_Load(object sender, EventArgs e)
        {
            timerMouse.Start();
            this.Height = 500;
            MakeHelp();
        }

        private void MakeHelp()
        {
            AddText("Comment", fontTopic, colorTopic);
            AddText("Start line with #", fontFixed, colorFixed);
            AddText();

            AddText("Mouse click", fontTopic, colorTopic);
            AddText("MouseClick(Left)", fontFixed, colorFixed);
            AddText("MouseClick(Right)", fontFixed, colorFixed);
            AddText();

            AddText("Move mouse to another monitor", fontTopic, colorTopic);
            AddText("MouseMoveMonitor(1)", fontFixed, colorFixed);
            AddText("MouseMoveMonitor(2)", fontFixed, colorFixed);
            AddText("MouseMoveMonitor(Primary)", fontFixed, colorFixed);
            AddText();

            AddText("Move mouse to relative position", fontTopic, colorTopic);
            AddText("MouseMove(100,100)", fontFixed, colorFixed);
            AddText();

            AddText("Move mouse to fixed position", fontTopic, colorTopic);
            AddText("MousePosition(100,100)", fontFixed, colorFixed);
            AddText();

            AddText("Insert delay (milliseconds)", fontTopic, colorTopic);
            AddText("Delay(100)", fontFixed, colorFixed);
            AddText();

            AddText("Send keystroke Ctrl-C", fontTopic, colorTopic);
            AddText("Key(^c)", fontFixed, colorFixed);
            AddText();

            AddText("Send keystroke Shift-C", fontTopic, colorTopic);
            AddText("Key(+c)", fontFixed, colorFixed);
            AddText();

            AddText("Send keystroke Alt-C", fontTopic, colorTopic);
            AddText("Key(%c)", fontFixed, colorFixed);
            AddText();

            AddText("https://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.send(v=vs.110).aspx");
            AddText();
        }

        private void AddText()
        {
            AddText("", fontNormal, colorNormal);
        }

        private void AddText(string text)
        {
            AddText(text, fontNormal, colorNormal);
        }

        private void AddText(string text, Font font, Color color)
        {
            txtHelp.SelectionFont = font;
            txtHelp.SelectionColor = color;
            txtHelp.AppendText(text);
            txtHelp.AppendText(Environment.NewLine);
        }

        private void txtHelp_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
