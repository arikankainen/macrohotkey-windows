using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class FormAddHotkey : Form
    {
        private DialogResult result;
        public DialogResult Result
        {
            get { return result; }
        }

        public string ActionName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string ActionHotkey
        {
            get { return txtHotkey.Text; }
            set
            {
                if (value != "")
                {
                    keyValues = Hotkeys.KeyListToValueList(value);
                    txtHotkey.Text = value;
                }
            }
        }

        public string Action
        {
            get
            {
                if (txtAction.Text != "")
                {
                    return txtAction.Text.Trim().Replace(Environment.NewLine, ";");
                }

                else return "";
            }

            set
            {
                if (value != null && value != "")
                {
                    txtAction.Text = value.Replace(";", Environment.NewLine);
                }
            }
        }

        private bool editMode;
        public bool EditMode
        {
            get { return editMode; }
            set { editMode = value; }
        }

        private List<string> listKeyValuesTemp = new List<string>();
        private string keyValues = null;
        private bool txtChanged = false;
        private string txtOrig = "";
        private bool firstEnter = true;
        private bool acceptMore = true;

        public FormAddHotkey()
        {
            InitializeComponent();

            timerMouse.Start();
        }

		private void btnOk_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Close();
        }

        private void btnHotkeyOk_Click(object sender, EventArgs e)
        {
            //result = DialogResult.OK;
            //this.Close();
        }

        private void btnHotkeyCancel_Click(object sender, EventArgs e)
        {
            //result = DialogResult.Cancel;
            //this.Close();
        }

        private void FormAddHotkey_Load(object sender, EventArgs e)
        {
            if (editMode) labelName.Text = "Edit macro";
            else labelName.Text = "New macro";
        }

        private void FormAddHotkey_Shown(object sender, EventArgs e)
        {
            txtName.Focus();
            txtName.SelectionStart = txtName.TextLength;
        }

        private void txtHotkey_Enter(object sender, EventArgs e)
        {
            txtChanged = false;
            txtOrig = txtHotkey.Text;
            txtHotkey.Text = "";
            listKeyValuesTemp.Clear();
            txtHotkey.BackColor = ColorTranslator.FromHtml("#ffffdd");
            txtHotkey.Tag = null;
        }

        private void txtHotkey_Leave(object sender, EventArgs e)
        {
            txtHotkey.BackColor = SystemColors.Window;
            if (!txtChanged) txtHotkey.Text = txtOrig;
            if (firstEnter)
            {
                txtHotkey.Text = ActionHotkey;
                firstEnter = false;
            }

            else
            {
                bool first = true;
                foreach (string val in listKeyValuesTemp)
                {
                    if (first) keyValues = val;
                    else keyValues += "|" + val;
                    first = false;
                }
            }

            listKeyValuesTemp.Clear();
        }

        private void txtHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void txtHotkey_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (
                e.KeyCode != Keys.Menu &&
                e.KeyCode != Keys.ShiftKey &&
                e.KeyCode != Keys.ControlKey
                ) acceptMore = false;

            else acceptMore = true;

            string key = e.KeyValue.ToString();
            txtChanged = true;

            if (!listKeyValuesTemp.Contains(key)) listKeyValuesTemp.Add(key);
            listKeyValuesTemp.Sort();

            txtHotkey.Text = "";
            for (int i = 0; i < listKeyValuesTemp.Count; i++)
            {
                if (i > 0) txtHotkey.Text += "+" + Hotkeys.GetKeyName(listKeyValuesTemp[i]);
                else txtHotkey.Text = Hotkeys.GetKeyName(listKeyValuesTemp[i]);
            }

            if (!acceptMore) labelAction.Focus();
        }

        private void txtHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            if (acceptMore) txtHotkey.Text = txtOrig;
            listKeyValuesTemp.Clear();
            if (txtChanged) labelAction.Focus();
        }

        private void FormAddHotkey_HelpButtonClicked(object sender, CancelEventArgs e)
        {
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

        private void btnAction_Click(object sender, EventArgs e)
        {
            contextMenuAction.Show(btnAction, new Point(-contextMenuAction.Width - 5, 0));
            contextMenuAction.Show(btnAction, new Point(-contextMenuAction.Width - 9, -contextMenuAction.Height + btnAction.Height));
        }

        private void mouseClickLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("MouseClick(Left)");
            
        }

        private void mouseClickRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("MouseClick(Right)");
        }

        private void mouseClickMiddleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("MouseClick(Middle)");
        }

        private void mouseMoveMonitor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("MouseMoveMonitor(1)");
        }

        private void mouseMoveMonitor2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("MouseMoveMonitor(2)");
        }

        private void mouseMoveMonitorPrimaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("MouseMoveMonitor(Primary)");
        }

        private void mouseMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("MouseMove()", 1);
        }

        private void mouseLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGetMouseLocation form = new FormGetMouseLocation();
            form.ShowDialog();
            AddText("MousePosition(" + form.Position.X.ToString() + "," + form.Position.Y.ToString() + ")");
        }

        private void keyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("Key()", 1);
        }

        private void keyControlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("Key(^c)");
        }

        private void keyShiftCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("Key(+c)");
        }

        private void keyAltCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("Key(%c)");
        }

        private void delayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("Delay()", 1);
        }

        private void delay500ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("Delay(500)");
        }

        private void delay1000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("Delay(1000)");
        }

        private void delay2000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddText("Delay(2000)");
        }

        private void AddText(string text)
        {
            AddText(text, 0);
        }

        private void AddText(string text, int pos)
        {
            if (pos == 0) text += Environment.NewLine;
            var selectionIndex = txtAction.SelectionStart;
            txtAction.Text = txtAction.Text.Insert(selectionIndex, text);
            txtAction.SelectionStart = selectionIndex + text.Length - pos;
            txtAction.Focus();
        }

        private void keyHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.send(v=vs.110).aspx");
        }

        private void contextMenuAction_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}
