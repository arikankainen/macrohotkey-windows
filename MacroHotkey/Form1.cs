using System;
using System.IO;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class Form1 : Form
    {
        private const int LIST_NAME = 0;
        private const int LIST_HOTKEY = 1;
        private const int LIST_ACTION = 2;

        private FormNotification notification;

        private readonly Settings settings = new Settings();
        private readonly string listFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".lst");
        private bool reallyClose = false;
        private bool cancel = false;
        private bool running = false;
        private bool iconVisible = true;

        public Form1()
        {
            InitializeComponent();
            AddLines();

            NotifyIcon1.ContextMenu = contextMenu1;
            LstActions.Sorting = SortOrder.Ascending;
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressedAsync);

            notification = new FormNotification();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadList();
            CheckSelectedItems();
            ReloadHotkeys();
            LoadSettings();

            this.Opacity = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveList();
            SaveSettings();

            if (!reallyClose)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                hook.KeyPressed -= new EventHandler<KeyPressedEventArgs>(hook_KeyPressedAsync);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormAddHotkey form = new FormAddHotkey();
            form.EditMode = false;
            form.ShowDialog();

            if (form.Result == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form.ActionName);
                item.SubItems.Add(form.ActionHotkey);
                item.SubItems.Add(form.Action);

                LstActions.Items.Add(item);
                ReloadHotkeys();
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (LstActions.SelectedItems.Count == 1)
            {
                FormAddHotkey form = new FormAddHotkey();
                form.EditMode = true;
                form.ActionName = LstActions.SelectedItems[LIST_NAME].Text;
                form.ActionHotkey = LstActions.SelectedItems[0].SubItems[LIST_HOTKEY].Text;
                form.Action = LstActions.SelectedItems[0].SubItems[LIST_ACTION].Text;
                form.ShowDialog();

                if (form.Result == DialogResult.OK)
                {
                    LstActions.SelectedItems[0].Remove();

                    ListViewItem item = new ListViewItem(form.ActionName);
                    item.SubItems.Add(form.ActionHotkey);
                    item.SubItems.Add(form.Action);

                    LstActions.Items.Add(item);
                    ReloadHotkeys();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LstActions.SelectedItems.Count == 1)
            {
                string name = LstActions.SelectedItems[0].Text;
                DialogResult result = MessageBox.Show("Delete selected macro?\n\n" + name, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void LstActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSelectedItems();
        }

        private void CheckSelectedItems()
        {
            if (LstActions.SelectedItems.Count == 1)
            {
                BtnModify.Enabled = true;
                BtnDelete.Enabled = true;
            }

            else
            {
                BtnModify.Enabled = false;
                BtnDelete.Enabled = false;
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
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            reallyClose = true;
            this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
