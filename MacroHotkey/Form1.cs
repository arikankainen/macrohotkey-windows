using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class Form1 : Form
    {
        private int setDelayOnStart = 500;
        private int setDelayBetween = 100;
        private int setDelayPaste = 200;

        private const int LIST_NAME = 0;
        private const int LIST_HOTKEY = 1;
        private const int LIST_ACTION = 2;

        private readonly FormNotification notification;
        private readonly Settings settings = new Settings();
        private readonly string listFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".lst");
        private readonly string appDir = Path.GetDirectoryName(Application.ExecutablePath);

        private bool reallyClose = false;
        private bool macroCancelled = false;
        private bool macroRunning = false;
        private bool iconVisible = true;

        private bool editing = false;

        private Point originalMousePosition;
        private DateTime macroRowCompletedTime;
        private List<string> macroRows = new List<string>();
        private int macroRow;
        private long actionDelay;

        private ActionDelayType actionDelayType;

        private enum ActionDelayType
        {
            DelayInitial,
            DelayBetween,
            DelayCustom,
            Pause,
            None
        }

        public Form1()
        {
            InitializeComponent();

            labelVersion.Text = "v" + Assembly.GetEntryAssembly().GetName().Version.ToString();
            toolStrip1.Renderer = new MySR();
            NotifyIcon1.ContextMenu = contextMenu1;
            LstActions.Sorting = SortOrder.Ascending;
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressedAsync);

            notification = new FormNotification();
        }

        private void CenterForm()
        {
            Screen screen = Screen.FromPoint(Cursor.Position);
            this.Left = screen.WorkingArea.Left + (screen.WorkingArea.Size.Width / 2) - (this.Width / 2);
            this.Top = screen.WorkingArea.Top + (screen.WorkingArea.Size.Height / 2) - (this.Height / 2) - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadList();
            CheckSelectedItems();
            ReloadHotkeys();
            LoadSettings(true);

            if (setStartInTray) this.Opacity = 0;

            string cfgFile = Path.Combine(appDir, "settings.cfg");
            if (!File.Exists(cfgFile)) TSHelp.PerformClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveList();
            SaveSettings();

            if (reallyClose || e.CloseReason == CloseReason.WindowsShutDown || !setCloseToTray)
            {
                hook.KeyPressed -= new EventHandler<KeyPressedEventArgs>(hook_KeyPressedAsync);
                notification.Dispose();
            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            editing = true;
            CheckSelectedItems();
            hook.DisposeAllKeys();

            FormAddHotkey form = new FormAddHotkey();
            form.EditMode = false;
            form.Show();

            /*
            if (form.Result == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form.ActionName);
                item.SubItems.Add(form.ActionHotkey);
                item.SubItems.Add(form.Action);

                LstActions.Items.Add(item);
            }

            editing = false;
            CheckSelectedItems();
            ReloadHotkeys();
            */
        }

        public void SaveAddForm(string name, string hotkey, string action, bool edit)
        {
            if (edit) LstActions.SelectedItems[0].Remove();

            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(hotkey);
            item.SubItems.Add(action);
            LstActions.Items.Add(item);
            item.Selected = true;
        }

        public void EditFormClosed()
        {
            editing = false;
            CheckSelectedItems();
            //LstActions.Focus();
            SaveList();
            ReloadHotkeys();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (LstActions.SelectedItems.Count == 1)
            {
                editing = true;
                CheckSelectedItems();
                hook.DisposeAllKeys();

                FormAddHotkey form = new FormAddHotkey();
                form.EditMode = true;
                form.ActionName = LstActions.SelectedItems[LIST_NAME].Text;
                form.ActionHotkey = LstActions.SelectedItems[0].SubItems[LIST_HOTKEY].Text;
                form.Action = LstActions.SelectedItems[0].SubItems[LIST_ACTION].Text;
                form.Show();

                /*
                if (form.Result == DialogResult.OK)
                {
                    LstActions.SelectedItems[0].Remove();

                    ListViewItem item = new ListViewItem(form.ActionName);
                    item.SubItems.Add(form.ActionHotkey);
                    item.SubItems.Add(form.Action);

                    LstActions.Items.Add(item);
                }

                editing = false;
                CheckSelectedItems();
                ReloadHotkeys();
                */
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LstActions.SelectedItems.Count == 1)
            {
                string name = LstActions.SelectedItems[0].Text;
                DialogResult result = MessageBox.Show("Really delete selected macro?\n\n" + name, "Delete macro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int index = LstActions.SelectedItems[0].Index;
                    LstActions.SelectedItems[0].Remove();
                    if (LstActions.Items.Count < index + 1) index--;
                    if (LstActions.Items.Count > 0) LstActions.Items[index].Selected = true;

                    ReloadHotkeys();
                }
            }
        }

        private void BtnRunMacro_Click(object sender, EventArgs e)
        {
            RunMacro();
        }

        private void LstActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSelectedItems();
        }

        private void CheckSelectedItems()
        {
            if (LstActions.SelectedItems.Count == 1 && !macroRunning && !editing)
            {
                BtnModify.Enabled = true;
                BtnDelete.Enabled = true;
                BtnRunMacro.Enabled = true;
            }
            else
            {
                BtnModify.Enabled = false;
                BtnDelete.Enabled = false;
                BtnRunMacro.Enabled = false;
            }

            if (!macroRunning && !editing) BtnAdd.Enabled = true;
            else BtnAdd.Enabled = false;

            if (editing) LstActions.Enabled = false;
            else LstActions.Enabled = true;

            UpdateStatusbar();
        }

        private void UpdateStatusbar()
        {
            labelItems.Text = " " + LstActions.Items.Count.ToString() + " macros";
            if (LstActions.SelectedItems.Count == 1)
            {
                string action = LstActions.SelectedItems[0].SubItems[LIST_ACTION].Text;
                List<string> rows = action.Split(';').ToList();
                double duration = CalculateMacroTotalTime(rows);

                labelDuration.Image = Properties.Resources.macrohotkey_delay;
                labelDuration.Text = " " + (duration / 1000).ToString() + " seconds";
            }
            else
            {
                labelDuration.Image = null;
                labelDuration.Text = "";
            }
        }

        private void LstActions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BtnModify.PerformClick();
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
            this.Show();
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            reallyClose = true;
            this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (setStartInTray) this.Hide();
        }

        private void TimerMacro_Tick(object sender, EventArgs e)
        {
            MacroTimerTick();
        }

        private void TimerIcon_Tick(object sender, EventArgs e)
        {
            if (iconVisible)
            {
                iconVisible = false;
                NotifyIcon1.Icon = this.Icon = Properties.Resources.blank;
            }
            else
            {
                iconVisible = true;
                NotifyIcon1.Icon = this.Icon = Properties.Resources.mh;
            }
        }

        private void TSExit_Click(object sender, EventArgs e)
        {
            reallyClose = true;
            this.Close();
        }

        private void TSBackup_Click(object sender, EventArgs e)
        {
            if (File.Exists(listFile))
            {
                string backupFile = Path.Combine(appDir, "macrohotkey_backup_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".lst");

                if (File.Exists(backupFile)) File.Delete(backupFile);
                File.Copy(listFile, backupFile);

                MessageBox.Show("Macros backed up successfully!" + Environment.NewLine + Environment.NewLine + Path.GetFileName(backupFile), "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TSSettings_Click(object sender, EventArgs e)
        {
            hook.DisposeAllKeys();

            FormSettings form = new FormSettings();
            form.ShowDialog();

            LoadSettings(false);
            ReloadHotkeys();
        }

        private void TSHelp_Click(object sender, EventArgs e)
        {
            string helpFile = Path.Combine(appDir, "macrohotkey.chm");
            if (File.Exists(helpFile))
            {
                Process.Start(helpFile);
            }
        }
    }

    // correcting a bug in the "system" renderer (white bottom line in toolstrip)
    public class MySR : ToolStripSystemRenderer
    {
        public MySR() { }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBorder(e);
        }
    }

}
