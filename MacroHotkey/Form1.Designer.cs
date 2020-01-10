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
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.timerIcon = new System.Windows.Forms.Timer(this.components);
            this.TimerMacro = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAdd = new System.Windows.Forms.ToolStripButton();
            this.BtnModify = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.BtnRunMacro = new System.Windows.Forms.ToolStripButton();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.TSBackup = new System.Windows.Forms.MenuItem();
            this.TSSettings = new System.Windows.Forms.MenuItem();
            this.TSHelp = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.TSExit = new System.Windows.Forms.MenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelDuration = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.LstActions = new MacroHotkey.VisualStylesListView();
            this.ClmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmHotkey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
            this.NotifyIcon1.Text = "Macro Hotkey";
            this.NotifyIcon1.Visible = true;
            this.NotifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
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
            // TimerMacro
            // 
            this.TimerMacro.Interval = 50;
            this.TimerMacro.Tick += new System.EventHandler(this.TimerMacro_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAdd,
            this.BtnModify,
            this.BtnDelete,
            this.BtnRunMacro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 15, 1, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(570, 38);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(24, 1, 0, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(49, 20);
            this.BtnAdd.Text = "Add";
            this.BtnAdd.ToolTipText = "Add new macro";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Image = ((System.Drawing.Image)(resources.GetObject("BtnModify.Image")));
            this.BtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModify.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(47, 20);
            this.BtnModify.Text = "Edit";
            this.BtnModify.ToolTipText = "Edit selected macro";
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(60, 20);
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.ToolTipText = "Delete selected macro";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnRunMacro
            // 
            this.BtnRunMacro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnRunMacro.Image = ((System.Drawing.Image)(resources.GetObject("BtnRunMacro.Image")));
            this.BtnRunMacro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRunMacro.Margin = new System.Windows.Forms.Padding(0, 1, 24, 2);
            this.BtnRunMacro.Name = "BtnRunMacro";
            this.BtnRunMacro.Size = new System.Drawing.Size(48, 20);
            this.BtnRunMacro.Text = "Run";
            this.BtnRunMacro.ToolTipText = "Run selected macro";
            this.BtnRunMacro.Click += new System.EventHandler(this.BtnRunMacro_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.TSBackup,
            this.menuItem2,
            this.TSSettings,
            this.TSHelp,
            this.menuItem3,
            this.TSExit});
            this.menuItem1.Text = "File";
            // 
            // TSBackup
            // 
            this.TSBackup.Index = 0;
            this.TSBackup.Text = "Create backup of all macros";
            this.TSBackup.Click += new System.EventHandler(this.TSBackup_Click);
            // 
            // TSSettings
            // 
            this.TSSettings.Index = 2;
            this.TSSettings.Text = "Settings";
            this.TSSettings.Click += new System.EventHandler(this.TSSettings_Click);
            // 
            // TSHelp
            // 
            this.TSHelp.Index = 3;
            this.TSHelp.Text = "Help";
            this.TSHelp.Click += new System.EventHandler(this.TSHelp_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            this.menuItem3.Text = "-";
            // 
            // TSExit
            // 
            this.TSExit.Index = 5;
            this.TSExit.Text = "Exit";
            this.TSExit.Click += new System.EventHandler(this.TSExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelItems,
            this.labelDuration,
            this.toolStripStatusLabel2,
            this.labelVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(570, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelItems
            // 
            this.labelItems.Image = ((System.Drawing.Image)(resources.GetObject("labelItems.Image")));
            this.labelItems.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(61, 17);
            this.labelItems.Text = "0 items";
            // 
            // labelDuration
            // 
            this.labelDuration.Image = ((System.Drawing.Image)(resources.GetObject("labelDuration.Image")));
            this.labelDuration.Margin = new System.Windows.Forms.Padding(15, 3, 0, 2);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(75, 17);
            this.labelDuration.Text = "0 seconds";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(348, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // labelVersion
            // 
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(46, 17);
            this.labelVersion.Text = "v0.0.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.LstActions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstActions.FullRowSelect = true;
            this.LstActions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstActions.HideSelection = false;
            this.LstActions.Location = new System.Drawing.Point(24, 44);
            this.LstActions.MultiSelect = false;
            this.LstActions.Name = "LstActions";
            this.LstActions.Size = new System.Drawing.Size(522, 175);
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
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(570, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LstActions);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro Hotkey";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VisualStylesListView LstActions;
        private System.Windows.Forms.ColumnHeader ClmName;
        private System.Windows.Forms.ColumnHeader ClmHotkey;
        private System.Windows.Forms.NotifyIcon NotifyIcon1;
        private System.Windows.Forms.ColumnHeader ClmAction;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemOpen;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.Timer timerIcon;
        private System.Windows.Forms.Timer TimerMacro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripButton BtnAdd;
        private System.Windows.Forms.ToolStripButton BtnModify;
        private System.Windows.Forms.ToolStripButton BtnRunMacro;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem TSExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelItems;
        private System.Windows.Forms.ToolStripStatusLabel labelVersion;
        private System.Windows.Forms.ToolStripStatusLabel labelDuration;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem TSBackup;
        private System.Windows.Forms.MenuItem TSSettings;
        private System.Windows.Forms.MenuItem TSHelp;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}

