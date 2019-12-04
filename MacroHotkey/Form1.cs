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

        private Settings settings = new Settings();
        private string appDir = Path.GetDirectoryName(Application.ExecutablePath);
        private string listFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".lst");
        private bool reallyClose = false;
        private bool cancel = false;

        public Form1()
        {
            InitializeComponent();
            AddLines();

            notifyIcon1.ContextMenu = contextMenu1;
            lstActions.Sorting = SortOrder.Ascending;
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddHotkey form = new FormAddHotkey();
            form.EditMode = false;
            form.ShowDialog();

            if (form.Result == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form.ActionName);
                item.SubItems.Add(form.ActionHotkey);
                item.SubItems.Add(form.Action);

                lstActions.Items.Add(item);
                ReloadHotkeys();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count == 1)
            {
                FormAddHotkey form = new FormAddHotkey();
                form.EditMode = true;
                form.ActionName = lstActions.SelectedItems[LIST_NAME].Text;
                form.ActionHotkey = lstActions.SelectedItems[0].SubItems[LIST_HOTKEY].Text;
                form.Action = lstActions.SelectedItems[0].SubItems[LIST_ACTION].Text;
                form.ShowDialog();

                if (form.Result == DialogResult.OK)
                {
                    lstActions.SelectedItems[0].Remove();

                    ListViewItem item = new ListViewItem(form.ActionName);
                    item.SubItems.Add(form.ActionHotkey);
                    item.SubItems.Add(form.Action);

                    lstActions.Items.Add(item);
                    ReloadHotkeys();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count == 1)
            {
                string name = lstActions.SelectedItems[0].Text;
                DialogResult result = MessageBox.Show("Delete selected macro?\n" + name, "Confirm delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int index = lstActions.SelectedItems[0].Index;
                    lstActions.SelectedItems[0].Remove();
                    if (lstActions.Items.Count < index + 1) index--;
                    if (lstActions.Items.Count > 0) lstActions.Items[index].Selected = true;

                    ReloadHotkeys();
                }
            }
        }

        private void lstActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSelectedItems();
        }

        private void CheckSelectedItems()
        {
            if (lstActions.SelectedItems.Count == 1)
            {
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
            }

            else
            {
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void lstActions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnModify.PerformClick();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
            this.Show();
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.Show();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            reallyClose = true;
            this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
