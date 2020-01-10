using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class FormAddHotkey : Form
    {
        private Settings settings = new Settings();
        
        private const string REPLACE_SEMICOLON = "###_SC_###";
        private const string REPLACE_PIPE = "###_PIPE_###";

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
                    return txtAction.Text.Trim().Replace(";", REPLACE_SEMICOLON).Replace("|", REPLACE_PIPE).Replace(Environment.NewLine, ";");
                }

                else return "";
            }

            set
            {
                if (value != null && value != "")
                {
                    txtAction.Text = value.Replace(";", Environment.NewLine).Replace(REPLACE_SEMICOLON, ";").Replace(REPLACE_PIPE, "|") + Environment.NewLine;
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

        private void CenterForm()
        {
            Screen screen = Screen.FromPoint(Cursor.Position);
            this.Left = screen.WorkingArea.Left + (screen.WorkingArea.Size.Width / 2) - (this.Width / 2);
            this.Top = screen.WorkingArea.Top + (screen.WorkingArea.Size.Height / 2) - (this.Height / 2) - 1;
        }

		private void btnOk_Click(object sender, EventArgs e)
        {
            SaveSettings();
            result = DialogResult.OK;
            (Application.OpenForms["Form1"] as Form1).SaveAddForm(ActionName, ActionHotkey, Action, EditMode);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Close();
        }

        private void FormAddHotkey_Load(object sender, EventArgs e)
        {
            LoadSettings();
            CenterForm();

            //if (editMode) this.Text = "Edit Macro";
            //else this.Text = "Add Macro";
        }

        private void FormAddHotkey_FormClosing(object sender, FormClosingEventArgs e)
        {
            (Application.OpenForms["Form1"] as Form1).EditFormClosed();
        }

        private void FormAddHotkey_Shown(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Focus();
                txtName.SelectionStart = txtName.TextLength;
            }
            else
            {
                txtAction.Focus();
                txtAction.SelectionStart = 0;
                txtAction.SelectionLength = 0;
            }
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
            if (txtHotkey.Text == "Esc") txtHotkey.Text = "";
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

            if (!acceptMore) label1.Focus();
        }

        private void txtHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            if (acceptMore) txtHotkey.Text = txtOrig;
            listKeyValuesTemp.Clear();
            if (txtChanged) label1.Focus();
        }

        private void timerMouse_Tick(object sender, EventArgs e)
        {
            Screen screen = Screen.FromPoint(MousePosition);
            Screen screenPrimary = Screen.PrimaryScreen;
            Point screenLocation = screen.Bounds.Location;

            int absoluteX = Cursor.Position.X;
            int absoluteY = Cursor.Position.Y;

            int absoluteTotalX = screen.Bounds.Width;
            int absoluteTotalY = screen.Bounds.Height;

            int relativeX = Math.Abs(screenLocation.X - absoluteX);
            int relativeY = Math.Abs(screenLocation.Y - absoluteY);

            string monitor = screen.DeviceName.Substring(screen.DeviceName.Length - 1);
            bool primary = screen.DeviceName == screenPrimary.DeviceName ? true : false;

            LblAbsolute.Text = absoluteX.ToString() + ", " + absoluteY.ToString();
            LblRelative.Text = relativeX.ToString() + ", " + relativeY.ToString();
            LblResolution.Text = absoluteTotalX.ToString() + " x " + absoluteTotalY.ToString();

            string mon = monitor;
            mon += primary ? " (Primary)" : "";
            LblMonitor.Text = mon;
        }

        private void AddText(string text)
        {
            AddText(text, 0);
        }

        private void AddText(string text, int pos)
        {
            if (pos > 0) pos += 2;
            int scrollPosition = GetScrollPos(txtAction.Handle, 1);

            bool replace = txtAction.SelectionLength > 0 ? true : false;

            int selectionStart = txtAction.SelectionStart;
            int selectionLength = txtAction.SelectionLength;

            if (replace) txtAction.Text = txtAction.Text.Remove(selectionStart, selectionLength);
            else selectionStart = txtAction.GetFirstCharIndexFromLine(txtAction.GetLineFromCharIndex(selectionStart));

            int character = 0;

            try
            {
                string sub = txtAction.Text.Substring(txtAction.GetFirstCharIndexFromLine(txtAction.GetLineFromCharIndex(selectionStart)), 1);
                char[] c = sub.ToCharArray();
                character = (int)c[0];
            }
            catch { }

            if (!replace && character != 13) text += Environment.NewLine;
            if (character == 13 && pos == 0) pos -= 2;

            txtAction.Text = txtAction.Text.Insert(selectionStart, text);
            
            int selection = selectionStart + text.Length - pos;
            if (selection < 0) selection = 0;

            txtAction.SelectionStart = selection;
            txtAction.Focus();

            SetScrollPos(txtAction.Handle, 1, scrollPosition, true);
            SendMessage(txtAction.Handle, EM_LINESCROLL, 0, scrollPosition);
        }

        [DllImport("user32.dll")]
        static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        static extern int GetScrollPos(IntPtr hWnd, int nBar);

        const int EM_LINESCROLL = 0x00B6;

        private void BtnMousePositionMonitor_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            FormGetMouseLocation form = new FormGetMouseLocation();
            form.WindowTitle = "Add MousePosition";
            form.ShowDialog();
            if (form.Result == DialogResult.OK) AddText("MousePosition(" + form.PositionRelative.X.ToString() + "," + form.PositionRelative.Y.ToString() + "," + form.Monitor + ")");
            form.Dispose();

            //this.WindowState = FormWindowState.Normal;
            txtAction.Focus();
            this.Activate();
        }

        private void BtnMousePosition_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            FormGetMouseLocation form = new FormGetMouseLocation();
            form.WindowTitle = "Add MousePosition";
            form.ShowDialog();
            if (form.Result == DialogResult.OK) AddText("MousePosition(" + form.PositionAbsolute.X.ToString() + "," + form.PositionAbsolute.Y.ToString() + ")");
            form.Dispose();

            //this.WindowState = FormWindowState.Normal;
            txtAction.Focus();
            this.Activate();
        }

        private void BtnMouseMove_Click(object sender, EventArgs e)
        {
            AddText("MouseMove()", 1);
        }

        private void BtnMouseClickLeft_Click(object sender, EventArgs e)
        {
            AddText("MouseClick(Left)");
        }

        private void BtnMouseClickMiddle_Click(object sender, EventArgs e)
        {
            AddText("MouseClick(Middle)");
        }

        private void BtnMouseClickRight_Click(object sender, EventArgs e)
        {
            AddText("MouseClick(Right)");
        }

        private void BtnMouseDownLeft_Click(object sender, EventArgs e)
        {
            AddText("MouseDown(Left)");
        }

        private void BtnMouseUpLeft_Click(object sender, EventArgs e)
        {
            AddText("MouseUp(Left)");
        }

        private void BtnWindowPositionMonitor_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            FormGetMouseLocation form = new FormGetMouseLocation();
            form.WindowTitle = "Add WindowPosition";
            form.ShowDialog();
            if (form.Result == DialogResult.OK) AddText("WindowPosition(" + form.PositionRelative.X.ToString() + "," + form.PositionRelative.Y.ToString() + "," + form.Monitor + ")");
            form.Dispose();

            //this.WindowState = FormWindowState.Normal;
            txtAction.Focus();
            this.Activate();
        }

        private void BtnWindowPosition_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            FormGetMouseLocation form = new FormGetMouseLocation();
            form.WindowTitle = "Add WindowPosition";
            form.ShowDialog();
            if (form.Result == DialogResult.OK) AddText("WindowPosition(" + form.PositionAbsolute.X.ToString() + "," + form.PositionAbsolute.Y.ToString() + ")");
            form.Dispose();

            //this.WindowState = FormWindowState.Normal;
            txtAction.Focus();
            this.Activate();
        }


        private void BtnActivateWindow_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            FormGetWindow form = new FormGetWindow();
            form.ShowDialog();
            if (form.Result == DialogResult.OK) AddText("ActivateWindow(" + form.WindowProcess + "," + form.WindowTitle + ")");
            form.Dispose();

            //this.WindowState = FormWindowState.Normal;
            txtAction.Focus();
            this.Activate();
        }

        private void BtnWindowSize_Click(object sender, EventArgs e)
        {
            AddText("WindowSize()", 1);
        }

        private void BtnTypeText_Click(object sender, EventArgs e)
        {
            AddText("TypeText()", 1);
        }

        private void BtnPasteText_Click(object sender, EventArgs e)
        {
            AddText("PasteText()", 1);
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            AddText("Copy()");
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            AddText("Paste()", 1);
        }

        private void BtnKey_Click(object sender, EventArgs e)
        {
            FormGetKey form = new FormGetKey();
            form.ShowDialog();
            if (form.Result == DialogResult.OK) AddText("Key(" + form.Keystring + ")");
            form.Dispose();
            txtAction.Focus();
        }

        private void BtnKey1_Click(object sender, EventArgs e)
        {
            AddText("Key(" + TxtKey1.Text + ")");
        }

        private void BtnKey2_Click(object sender, EventArgs e)
        {
            AddText("Key(" + TxtKey2.Text + ")");
        }

        private void BtnKey3_Click(object sender, EventArgs e)
        {
            AddText("Key(" + TxtKey3.Text + ")");
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            AddText("Pause()");
        }

        private void BtnDelay_Click(object sender, EventArgs e)
        {
            AddText("Delay()", 1);
        }

        private void BtnDelay1_Click(object sender, EventArgs e)
        {
            AddText("Delay(" + TxtDelay1.Text + ")");
        }

        private void BtnDelay2_Click(object sender, EventArgs e)
        {
            AddText("Delay(" + TxtDelay2.Text + ")");
        }

        private void BtnDelay3_Click(object sender, EventArgs e)
        {
            AddText("Delay(" + TxtDelay3.Text + ")");
        }

        private void TxtKey1_TextChanged(object sender, EventArgs e)
        {
            BtnKey1.Text = "Key(" + TxtKey1.Text.Trim() + ")";
        }

        private void TxtKey2_TextChanged(object sender, EventArgs e)
        {
            BtnKey2.Text = "Key(" + TxtKey2.Text.Trim() + ")";
        }

        private void TxtKey3_TextChanged(object sender, EventArgs e)
        {
            BtnKey3.Text = "Key(" + TxtKey3.Text.Trim() + ")";
        }

        private void TxtDelay1_TextChanged(object sender, EventArgs e)
        {
            BtnDelay1.Text = "Delay(" + TxtDelay1.Text.Trim() + ")";
        }

        private void TxtDelay2_TextChanged(object sender, EventArgs e)
        {
            BtnDelay2.Text = "Delay(" + TxtDelay2.Text.Trim() + ")";
        }

        private void TxtDelay3_TextChanged(object sender, EventArgs e)
        {
            BtnDelay3.Text = "Delay(" + TxtDelay3.Text.Trim() + ")";
        }

        private void SaveSettings()
        {
            if (this.Width >= this.MinimumSize.Width) settings.SaveSetting("MacroWidth", this.Width.ToString());
            if (this.Height >= this.MinimumSize.Height) settings.SaveSetting("MacroHeight", this.Height.ToString());

            settings.SaveSetting("CustomKey1", TxtKey1.Text);
            settings.SaveSetting("CustomKey2", TxtKey2.Text);
            settings.SaveSetting("CustomKey3", TxtKey3.Text);
            settings.SaveSetting("CustomDelay1", TxtDelay1.Text);
            settings.SaveSetting("CustomDelay2", TxtDelay2.Text);
            settings.SaveSetting("CustomDelay3", TxtDelay3.Text);
        }

        private void LoadSettings()
        {
            this.Width = settings.LoadSetting("MacroWidth", "int", "724");
            this.Height = settings.LoadSetting("MacroHeight", "int", "851");
            
            TxtKey1.Text = settings.LoadSetting("CustomKey1", "string", "{ESC}");
            TxtKey2.Text = settings.LoadSetting("CustomKey2", "string", "{TAB}");
            TxtKey3.Text = settings.LoadSetting("CustomKey3", "string", "{ENTER}");
            TxtDelay1.Text = settings.LoadSetting("CustomDelay1", "string", "500");
            TxtDelay2.Text = settings.LoadSetting("CustomDelay2", "string", "1000");
            TxtDelay3.Text = settings.LoadSetting("CustomDelay3", "string", "2000");
        }

        private void txtAction_DoubleClick(object sender, EventArgs e)
        {
            string row = txtAction.Lines[txtAction.GetLineFromCharIndex(txtAction.SelectionStart)];
            txtAction.SelectionLength = 0;

            Regex regex = new Regex(@"(^.*?)\((.*)\)");
            Match match = regex.Match(row.ToLower());

            string command = match.Groups[1].Value;
            string value = match.Groups[2].Value;

            if (command == "mouseposition" || command == "windowposition")
            {
                try
                {
                    List<string> position = value.Split(',').ToList();

                    int.TryParse(position[0], out int x);
                    int.TryParse(position[1], out int y);

                    string scr = position.Count > 2 ? position[2] : null;

                    SetCursor(scr, x, y);
                }
                catch { }
            }
        }

        private void SetCursor(string scr, int x, int y)
        {
            try
            {
                if (scr == null)
                {
                    Cursor.Position = new Point(x, y);
                    Cursor.Position = new Point(x, y);
                }
                else
                {
                    Screen screen = GetScreen(scr);

                    if (screen != null)
                    {
                        int relativeX = screen.Bounds.X + x;
                        int relativeY = screen.Bounds.Y + y;

                        Cursor.Position = new Point(relativeX, relativeY);
                        Cursor.Position = new Point(relativeX, relativeY);
                    }
                }
            }
            catch { }
        }

        private Screen GetScreen(string number)
        {
            try
            {
                foreach (Screen s in Screen.AllScreens)
                {
                    if (s.DeviceName.Contains(number)) return s;
                }

                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
