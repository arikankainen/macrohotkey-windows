namespace MacroHotkey
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CheckActive = new System.Windows.Forms.CheckBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.timerIcon = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSExit = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSCloseToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.TSStartInTray = new System.Windows.Forms.ToolStripMenuItem();
            this.LstActions = new MacroHotkey.VisualStylesListView();
            this.ClmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmHotkey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(24, 335);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 24;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModify.Location = new System.Drawing.Point(105, 335);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 23);
            this.BtnModify.TabIndex = 25;
            this.BtnModify.Text = "Modify";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.Location = new System.Drawing.Point(186, 335);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 26;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
            this.NotifyIcon1.Text = "Macro Hotkey";
            this.NotifyIcon1.Visible = true;
            this.NotifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // CheckActive
            // 
            this.CheckActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckActive.AutoSize = true;
            this.CheckActive.Checked = true;
            this.CheckActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckActive.Location = new System.Drawing.Point(449, 339);
            this.CheckActive.Name = "CheckActive";
            this.CheckActive.Size = new System.Drawing.Size(97, 17);
            this.CheckActive.TabIndex = 27;
            this.CheckActive.Text = "Hotkeys active";
            this.CheckActive.UseVisualStyleBackColor = true;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemOpen,
            this.menuItemExit});
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Index = 0;
            this.menuItemOpen.Text = "Open";
            this.menuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 1;
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // timerIcon
            // 
            this.timerIcon.Interval = 500;
            this.timerIcon.Tick += new System.EventHandler(this.TimerIcon_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // TSExit
            // 
            this.TSExit.Name = "TSExit";
            this.TSExit.Size = new System.Drawing.Size(180, 22);
            this.TSExit.Text = "Exit";
            this.TSExit.Click += new System.EventHandler(this.TSExit_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSCloseToTray,
            this.TSStartInTray});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // TSCloseToTray
            // 
            this.TSCloseToTray.Name = "TSCloseToTray";
            this.TSCloseToTray.Size = new System.Drawing.Size(180, 22);
            this.TSCloseToTray.Text = "Close to tray";
            this.TSCloseToTray.Click += new System.EventHandler(this.TSCloseToTray_Click);
            // 
            // TSStartInTray
            // 
            this.TSStartInTray.Name = "TSStartInTray";
            this.TSStartInTray.Size = new System.Drawing.Size(180, 22);
            this.TSStartInTray.Text = "Start in tray";
            this.TSStartInTray.Click += new System.EventHandler(this.TSStartInTray_Click);
            // 
            // LstActions
            // 
            this.LstActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmName,
            this.ClmHotkey,
            this.ClmAction});
            this.LstActions.FullRowSelect = true;
            this.LstActions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstActions.HideSelection = false;
            this.LstActions.Location = new System.Drawing.Point(24, 48);
            this.LstActions.MultiSelect = false;
            this.LstActions.Name = "LstActions";
            this.LstActions.Size = new System.Drawing.Size(522, 248);
            this.LstActions.TabIndex = 23;
            this.LstActions.UseCompatibleStateImageBehavior = false;
            this.LstActions.View = System.Windows.Forms.View.Details;
            this.LstActions.SelectedIndexChanged += new System.EventHandler(this.LstActions_SelectedIndexChanged);
            this.LstActions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstActions_MouseDoubleClick);
            // 
            // ClmName
            // 
            this.ClmName.Text = "Name";
            this.ClmName.Width = 140;
            // 
            // ClmHotkey
            // 
            this.ClmHotkey.Text = "Hotkey";
            this.ClmHotkey.Width = 160;
            // 
            // ClmAction
            // 
            this.ClmAction.Text = "Macro";
            this.ClmAction.Width = 191;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(570, 371);
            this.Controls.Add(this.CheckActive);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LstActions);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(586, 410);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro Hotkey";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VisualStylesListView LstActions;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ColumnHeader ClmName;
        private System.Windows.Forms.ColumnHeader ClmHotkey;
        private System.Windows.Forms.NotifyIcon NotifyIcon1;
        private System.Windows.Forms.CheckBox CheckActive;
        private System.Windows.Forms.ColumnHeader ClmAction;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemOpen;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.Timer timerIcon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSExit;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSCloseToTray;
        private System.Windows.Forms.ToolStripMenuItem TSStartInTray;
    }
}

