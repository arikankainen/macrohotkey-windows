namespace MacroHotkey
{
    partial class FormAddHotkey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddHotkey));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelLineTop = new System.Windows.Forms.Label();
            this.labelLineBottom = new System.Windows.Forms.Label();
            this.labelHotkey = new System.Windows.Forms.Label();
            this.labelAction = new System.Windows.Forms.Label();
            this.txtHotkey = new System.Windows.Forms.TextBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMouse = new System.Windows.Forms.Label();
            this.timerMouse = new System.Windows.Forms.Timer(this.components);
            this.btnAction = new System.Windows.Forms.Button();
            this.contextMenuAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mouseLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mouseMoveMonitorPrimaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseMoveMonitor1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseMoveMonitor2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mouseClickLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseClickMiddleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseClickRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyControlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyShiftCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyAltCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.delayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delay500ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delay1000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delay2000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            this.contextMenuAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTop.Controls.Add(this.labelName);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(484, 51);
            this.panelTop.TabIndex = 23;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(21, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.UseMnemonic = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(302, 591);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(383, 591);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelLineTop
            // 
            this.labelLineTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLineTop.Location = new System.Drawing.Point(-1, 51);
            this.labelLineTop.Name = "labelLineTop";
            this.labelLineTop.Size = new System.Drawing.Size(486, 2);
            this.labelLineTop.TabIndex = 25;
            this.labelLineTop.Text = "labelLine1";
            // 
            // labelLineBottom
            // 
            this.labelLineBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLineBottom.Location = new System.Drawing.Point(-1, 576);
            this.labelLineBottom.Name = "labelLineBottom";
            this.labelLineBottom.Size = new System.Drawing.Size(486, 2);
            this.labelLineBottom.TabIndex = 26;
            this.labelLineBottom.Text = "label1";
            // 
            // labelHotkey
            // 
            this.labelHotkey.AutoSize = true;
            this.labelHotkey.Location = new System.Drawing.Point(21, 109);
            this.labelHotkey.Name = "labelHotkey";
            this.labelHotkey.Size = new System.Drawing.Size(44, 13);
            this.labelHotkey.TabIndex = 24;
            this.labelHotkey.Text = "Hotkey:";
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Location = new System.Drawing.Point(21, 140);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(40, 13);
            this.labelAction.TabIndex = 23;
            this.labelAction.Text = "Action:";
            // 
            // txtHotkey
            // 
            this.txtHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotkey.Location = new System.Drawing.Point(95, 106);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.Size = new System.Drawing.Size(363, 20);
            this.txtHotkey.TabIndex = 1;
            this.txtHotkey.Enter += new System.EventHandler(this.txtHotkey_Enter);
            this.txtHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHotkey_KeyDown);
            this.txtHotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHotkey_KeyUp);
            this.txtHotkey.Leave += new System.EventHandler(this.txtHotkey_Leave);
            this.txtHotkey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtHotkey_PreviewKeyDown);
            // 
            // txtAction
            // 
            this.txtAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAction.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAction.Location = new System.Drawing.Point(95, 137);
            this.txtAction.Multiline = true;
            this.txtAction.Name = "txtAction";
            this.txtAction.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAction.Size = new System.Drawing.Size(363, 415);
            this.txtAction.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(95, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name:";
            // 
            // labelMouse
            // 
            this.labelMouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMouse.AutoSize = true;
            this.labelMouse.Location = new System.Drawing.Point(26, 596);
            this.labelMouse.Name = "labelMouse";
            this.labelMouse.Size = new System.Drawing.Size(123, 13);
            this.labelMouse.TabIndex = 32;
            this.labelMouse.Text = "Mouse position: 999,999";
            // 
            // timerMouse
            // 
            this.timerMouse.Interval = 50;
            this.timerMouse.Tick += new System.EventHandler(this.timerMouse_Tick);
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAction.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(56, 523);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(30, 30);
            this.btnAction.TabIndex = 33;
            this.btnAction.Text = "+";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // contextMenuAction
            // 
            this.contextMenuAction.DropShadowEnabled = false;
            this.contextMenuAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseLocationToolStripMenuItem,
            this.mouseMoveToolStripMenuItem,
            this.toolStripMenuItem3,
            this.mouseMoveMonitorPrimaryToolStripMenuItem,
            this.mouseMoveMonitor1ToolStripMenuItem,
            this.mouseMoveMonitor2ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mouseClickLeftToolStripMenuItem,
            this.mouseClickMiddleToolStripMenuItem,
            this.mouseClickRightToolStripMenuItem,
            this.toolStripMenuItem1,
            this.keyToolStripMenuItem,
            this.keyControlCToolStripMenuItem,
            this.keyShiftCToolStripMenuItem,
            this.keyAltCToolStripMenuItem,
            this.keyHelpToolStripMenuItem,
            this.toolStripMenuItem4,
            this.delayToolStripMenuItem,
            this.delay500ToolStripMenuItem,
            this.delay1000ToolStripMenuItem,
            this.delay2000ToolStripMenuItem});
            this.contextMenuAction.Name = "contextMenuAction";
            this.contextMenuAction.Size = new System.Drawing.Size(233, 424);
            this.contextMenuAction.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuAction_Closing);
            // 
            // mouseLocationToolStripMenuItem
            // 
            this.mouseLocationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mouseLocationToolStripMenuItem.Image")));
            this.mouseLocationToolStripMenuItem.Name = "mouseLocationToolStripMenuItem";
            this.mouseLocationToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.mouseLocationToolStripMenuItem.Text = "MousePosition(x,y)";
            this.mouseLocationToolStripMenuItem.ToolTipText = "Move mouse to location X , Y";
            this.mouseLocationToolStripMenuItem.Click += new System.EventHandler(this.mouseLocationToolStripMenuItem_Click);
            // 
            // mouseMoveToolStripMenuItem
            // 
            this.mouseMoveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mouseMoveToolStripMenuItem.Image")));
            this.mouseMoveToolStripMenuItem.Name = "mouseMoveToolStripMenuItem";
            this.mouseMoveToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.mouseMoveToolStripMenuItem.Text = "MouseMove(x,y)";
            this.mouseMoveToolStripMenuItem.ToolTipText = "Move mouse X pixels right, Y pixels down (negative values can be used)";
            this.mouseMoveToolStripMenuItem.Click += new System.EventHandler(this.mouseMoveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(229, 6);
            // 
            // mouseMoveMonitorPrimaryToolStripMenuItem
            // 
            this.mouseMoveMonitorPrimaryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mouseMoveMonitorPrimaryToolStripMenuItem.Image")));
            this.mouseMoveMonitorPrimaryToolStripMenuItem.Name = "mouseMoveMonitorPrimaryToolStripMenuItem";
            this.mouseMoveMonitorPrimaryToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.mouseMoveMonitorPrimaryToolStripMenuItem.Text = "MouseMoveMonitor(Primary)";
            this.mouseMoveMonitorPrimaryToolStripMenuItem.ToolTipText = "Move mouse to primary monitor, upper left corner";
            this.mouseMoveMonitorPrimaryToolStripMenuItem.Click += new System.EventHandler(this.mouseMoveMonitorPrimaryToolStripMenuItem_Click);
            // 
            // mouseMoveMonitor1ToolStripMenuItem
            // 
            this.mouseMoveMonitor1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mouseMoveMonitor1ToolStripMenuItem.Image")));
            this.mouseMoveMonitor1ToolStripMenuItem.Name = "mouseMoveMonitor1ToolStripMenuItem";
            this.mouseMoveMonitor1ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.mouseMoveMonitor1ToolStripMenuItem.Text = "MouseMoveMonitor(1)";
            this.mouseMoveMonitor1ToolStripMenuItem.ToolTipText = "Move mouse to monitor 1, upper left corner";
            this.mouseMoveMonitor1ToolStripMenuItem.Click += new System.EventHandler(this.mouseMoveMonitor1ToolStripMenuItem_Click);
            // 
            // mouseMoveMonitor2ToolStripMenuItem
            // 
            this.mouseMoveMonitor2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mouseMoveMonitor2ToolStripMenuItem.Image")));
            this.mouseMoveMonitor2ToolStripMenuItem.Name = "mouseMoveMonitor2ToolStripMenuItem";
            this.mouseMoveMonitor2ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.mouseMoveMonitor2ToolStripMenuItem.Text = "MouseMoveMonitor(2)";
            this.mouseMoveMonitor2ToolStripMenuItem.ToolTipText = "Move mouse to monitor 2, upper left corner";
            this.mouseMoveMonitor2ToolStripMenuItem.Click += new System.EventHandler(this.mouseMoveMonitor2ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(229, 6);
            // 
            // mouseClickLeftToolStripMenuItem
            // 
            this.mouseClickLeftToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mouseClickLeftToolStripMenuItem.Image")));
            this.mouseClickLeftToolStripMenuItem.Name = "mouseClickLeftToolStripMenuItem";
            this.mouseClickLeftToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.mouseClickLeftToolStripMenuItem.Text = "MouseClick(Left)";
            this.mouseClickLeftToolStripMenuItem.ToolTipText = "Left mouse click";
            this.mouseClickLeftToolStripMenuItem.Click += new System.EventHandler(this.mouseClickLeftToolStripMenuItem_Click);
            // 
            // mouseClickMiddleToolStripMenuItem
            // 
            this.mouseClickMiddleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mouseClickMiddleToolStripMenuItem.Image")));
            this.mouseClickMiddleToolStripMenuItem.Name = "mouseClickMiddleToolStripMenuItem";
            this.mouseClickMiddleToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.mouseClickMiddleToolStripMenuItem.Text = "MouseClick(Middle)";
            this.mouseClickMiddleToolStripMenuItem.ToolTipText = "Middle mouse click";
            this.mouseClickMiddleToolStripMenuItem.Click += new System.EventHandler(this.mouseClickMiddleToolStripMenuItem_Click);
            // 
            // mouseClickRightToolStripMenuItem
            // 
            this.mouseClickRightToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mouseClickRightToolStripMenuItem.Image")));
            this.mouseClickRightToolStripMenuItem.Name = "mouseClickRightToolStripMenuItem";
            this.mouseClickRightToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.mouseClickRightToolStripMenuItem.Text = "MouseClick(Right)";
            this.mouseClickRightToolStripMenuItem.ToolTipText = "Right mouse click";
            this.mouseClickRightToolStripMenuItem.Click += new System.EventHandler(this.mouseClickRightToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("keyToolStripMenuItem.Image")));
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.keyToolStripMenuItem.Text = "Key(n)";
            this.keyToolStripMenuItem.ToolTipText = "Insert keystroke";
            this.keyToolStripMenuItem.Click += new System.EventHandler(this.keyToolStripMenuItem_Click);
            // 
            // keyControlCToolStripMenuItem
            // 
            this.keyControlCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("keyControlCToolStripMenuItem.Image")));
            this.keyControlCToolStripMenuItem.Name = "keyControlCToolStripMenuItem";
            this.keyControlCToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.keyControlCToolStripMenuItem.Text = "Key(^c)";
            this.keyControlCToolStripMenuItem.ToolTipText = "Insert keystroke Ctrl-C";
            this.keyControlCToolStripMenuItem.Click += new System.EventHandler(this.keyControlCToolStripMenuItem_Click);
            // 
            // keyShiftCToolStripMenuItem
            // 
            this.keyShiftCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("keyShiftCToolStripMenuItem.Image")));
            this.keyShiftCToolStripMenuItem.Name = "keyShiftCToolStripMenuItem";
            this.keyShiftCToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.keyShiftCToolStripMenuItem.Text = "Key(+c)";
            this.keyShiftCToolStripMenuItem.ToolTipText = "Insert keystroke Shift-C";
            this.keyShiftCToolStripMenuItem.Click += new System.EventHandler(this.keyShiftCToolStripMenuItem_Click);
            // 
            // keyAltCToolStripMenuItem
            // 
            this.keyAltCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("keyAltCToolStripMenuItem.Image")));
            this.keyAltCToolStripMenuItem.Name = "keyAltCToolStripMenuItem";
            this.keyAltCToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.keyAltCToolStripMenuItem.Text = "Key(%c)";
            this.keyAltCToolStripMenuItem.ToolTipText = "Insert keystroke Alt-C";
            this.keyAltCToolStripMenuItem.Click += new System.EventHandler(this.keyAltCToolStripMenuItem_Click);
            // 
            // keyHelpToolStripMenuItem
            // 
            this.keyHelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("keyHelpToolStripMenuItem.Image")));
            this.keyHelpToolStripMenuItem.Name = "keyHelpToolStripMenuItem";
            this.keyHelpToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.keyHelpToolStripMenuItem.Text = "(Show commands)";
            this.keyHelpToolStripMenuItem.Click += new System.EventHandler(this.keyHelpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(229, 6);
            // 
            // delayToolStripMenuItem
            // 
            this.delayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("delayToolStripMenuItem.Image")));
            this.delayToolStripMenuItem.Name = "delayToolStripMenuItem";
            this.delayToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.delayToolStripMenuItem.Text = "Delay(n)";
            this.delayToolStripMenuItem.ToolTipText = "Insert delay";
            this.delayToolStripMenuItem.Click += new System.EventHandler(this.delayToolStripMenuItem_Click);
            // 
            // delay500ToolStripMenuItem
            // 
            this.delay500ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("delay500ToolStripMenuItem.Image")));
            this.delay500ToolStripMenuItem.Name = "delay500ToolStripMenuItem";
            this.delay500ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.delay500ToolStripMenuItem.Text = "Delay(500)";
            this.delay500ToolStripMenuItem.ToolTipText = "Insert delay 500ms";
            this.delay500ToolStripMenuItem.Click += new System.EventHandler(this.delay500ToolStripMenuItem_Click);
            // 
            // delay1000ToolStripMenuItem
            // 
            this.delay1000ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("delay1000ToolStripMenuItem.Image")));
            this.delay1000ToolStripMenuItem.Name = "delay1000ToolStripMenuItem";
            this.delay1000ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.delay1000ToolStripMenuItem.Text = "Delay(1000)";
            this.delay1000ToolStripMenuItem.ToolTipText = "Insert delay 1000ms";
            this.delay1000ToolStripMenuItem.Click += new System.EventHandler(this.delay1000ToolStripMenuItem_Click);
            // 
            // delay2000ToolStripMenuItem
            // 
            this.delay2000ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("delay2000ToolStripMenuItem.Image")));
            this.delay2000ToolStripMenuItem.Name = "delay2000ToolStripMenuItem";
            this.delay2000ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.delay2000ToolStripMenuItem.Text = "Delay(2000)";
            this.delay2000ToolStripMenuItem.ToolTipText = "Insert delay 2000ms";
            this.delay2000ToolStripMenuItem.Click += new System.EventHandler(this.delay2000ToolStripMenuItem_Click);
            // 
            // FormAddHotkey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(484, 627);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.labelMouse);
            this.Controls.Add(this.labelLineTop);
            this.Controls.Add(this.labelLineBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.labelHotkey);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.txtHotkey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormAddHotkey";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Macro Hotkey";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormAddHotkey_HelpButtonClicked);
            this.Load += new System.EventHandler(this.FormAddHotkey_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.contextMenuAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        protected System.Windows.Forms.Label labelName;
        protected System.Windows.Forms.Button btnOk;
        protected System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelLineTop;
        private System.Windows.Forms.Label labelLineBottom;
        private System.Windows.Forms.Label labelHotkey;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.TextBox txtHotkey;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMouse;
        private System.Windows.Forms.Timer timerMouse;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ContextMenuStrip contextMenuAction;
        private System.Windows.Forms.ToolStripMenuItem mouseClickLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseClickRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mouseMoveMonitor1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseMoveMonitor2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseMoveMonitorPrimaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mouseMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem keyControlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyShiftCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyAltCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem delay500ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delay1000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delay2000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseClickMiddleToolStripMenuItem;
    }
}