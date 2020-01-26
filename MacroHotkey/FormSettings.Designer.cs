namespace MacroHotkey
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CheckReturnMouse = new System.Windows.Forms.CheckBox();
            this.CheckRememberEditorWindowPosition = new System.Windows.Forms.CheckBox();
            this.CheckRememberEditorWindowSize = new System.Windows.Forms.CheckBox();
            this.CheckRememberMainWindowPosition = new System.Windows.Forms.CheckBox();
            this.CheckRememberMainWindowSize = new System.Windows.Forms.CheckBox();
            this.CheckStartInTray = new System.Windows.Forms.CheckBox();
            this.CheckMinimizeOnRun = new System.Windows.Forms.CheckBox();
            this.CheckCloseToTray = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboDelayBetween = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboDelayStart = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboDelayAfterPaste = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboDelayBeforePaste = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CheckReturnMouse);
            this.tabPage1.Controls.Add(this.CheckRememberEditorWindowPosition);
            this.tabPage1.Controls.Add(this.CheckRememberEditorWindowSize);
            this.tabPage1.Controls.Add(this.CheckRememberMainWindowPosition);
            this.tabPage1.Controls.Add(this.CheckRememberMainWindowSize);
            this.tabPage1.Controls.Add(this.CheckStartInTray);
            this.tabPage1.Controls.Add(this.CheckMinimizeOnRun);
            this.tabPage1.Controls.Add(this.CheckCloseToTray);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CheckReturnMouse
            // 
            this.CheckReturnMouse.AutoSize = true;
            this.CheckReturnMouse.Location = new System.Drawing.Point(23, 227);
            this.CheckReturnMouse.Name = "CheckReturnMouse";
            this.CheckReturnMouse.Size = new System.Drawing.Size(338, 19);
            this.CheckReturnMouse.TabIndex = 7;
            this.CheckReturnMouse.Text = "Return mouse to its original position after macro is finished";
            this.CheckReturnMouse.UseVisualStyleBackColor = true;
            // 
            // CheckRememberEditorWindowPosition
            // 
            this.CheckRememberEditorWindowPosition.AutoSize = true;
            this.CheckRememberEditorWindowPosition.Location = new System.Drawing.Point(23, 192);
            this.CheckRememberEditorWindowPosition.Name = "CheckRememberEditorWindowPosition";
            this.CheckRememberEditorWindowPosition.Size = new System.Drawing.Size(209, 19);
            this.CheckRememberEditorWindowPosition.TabIndex = 6;
            this.CheckRememberEditorWindowPosition.Text = "Remember editor window position";
            this.CheckRememberEditorWindowPosition.UseVisualStyleBackColor = true;
            // 
            // CheckRememberEditorWindowSize
            // 
            this.CheckRememberEditorWindowSize.AutoSize = true;
            this.CheckRememberEditorWindowSize.Location = new System.Drawing.Point(23, 167);
            this.CheckRememberEditorWindowSize.Name = "CheckRememberEditorWindowSize";
            this.CheckRememberEditorWindowSize.Size = new System.Drawing.Size(185, 19);
            this.CheckRememberEditorWindowSize.TabIndex = 5;
            this.CheckRememberEditorWindowSize.Text = "Remember editor window size";
            this.CheckRememberEditorWindowSize.UseVisualStyleBackColor = true;
            // 
            // CheckRememberMainWindowPosition
            // 
            this.CheckRememberMainWindowPosition.AutoSize = true;
            this.CheckRememberMainWindowPosition.Location = new System.Drawing.Point(23, 132);
            this.CheckRememberMainWindowPosition.Name = "CheckRememberMainWindowPosition";
            this.CheckRememberMainWindowPosition.Size = new System.Drawing.Size(205, 19);
            this.CheckRememberMainWindowPosition.TabIndex = 4;
            this.CheckRememberMainWindowPosition.Text = "Remember main window position";
            this.CheckRememberMainWindowPosition.UseVisualStyleBackColor = true;
            // 
            // CheckRememberMainWindowSize
            // 
            this.CheckRememberMainWindowSize.AutoSize = true;
            this.CheckRememberMainWindowSize.Location = new System.Drawing.Point(23, 107);
            this.CheckRememberMainWindowSize.Name = "CheckRememberMainWindowSize";
            this.CheckRememberMainWindowSize.Size = new System.Drawing.Size(181, 19);
            this.CheckRememberMainWindowSize.TabIndex = 3;
            this.CheckRememberMainWindowSize.Text = "Remember main window size";
            this.CheckRememberMainWindowSize.UseVisualStyleBackColor = true;
            // 
            // CheckStartInTray
            // 
            this.CheckStartInTray.AutoSize = true;
            this.CheckStartInTray.Location = new System.Drawing.Point(23, 47);
            this.CheckStartInTray.Name = "CheckStartInTray";
            this.CheckStartInTray.Size = new System.Drawing.Size(86, 19);
            this.CheckStartInTray.TabIndex = 2;
            this.CheckStartInTray.Text = "Start in tray";
            this.CheckStartInTray.UseVisualStyleBackColor = true;
            // 
            // CheckMinimizeOnRun
            // 
            this.CheckMinimizeOnRun.AutoSize = true;
            this.CheckMinimizeOnRun.Location = new System.Drawing.Point(23, 72);
            this.CheckMinimizeOnRun.Name = "CheckMinimizeOnRun";
            this.CheckMinimizeOnRun.Size = new System.Drawing.Size(208, 19);
            this.CheckMinimizeOnRun.TabIndex = 1;
            this.CheckMinimizeOnRun.Text = "Minimize when using \'Run\' button";
            this.CheckMinimizeOnRun.UseVisualStyleBackColor = true;
            // 
            // CheckCloseToTray
            // 
            this.CheckCloseToTray.AutoSize = true;
            this.CheckCloseToTray.Location = new System.Drawing.Point(23, 22);
            this.CheckCloseToTray.Name = "CheckCloseToTray";
            this.CheckCloseToTray.Size = new System.Drawing.Size(92, 19);
            this.CheckCloseToTray.TabIndex = 0;
            this.CheckCloseToTray.Text = "Close to tray";
            this.CheckCloseToTray.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.ComboDelayBeforePaste);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.ComboDelayBetween);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ComboDelayStart);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ComboDelayAfterPaste);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delays";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "milliseconds";
            // 
            // ComboDelayBetween
            // 
            this.ComboDelayBetween.FormattingEnabled = true;
            this.ComboDelayBetween.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1500",
            "2000"});
            this.ComboDelayBetween.Location = new System.Drawing.Point(278, 48);
            this.ComboDelayBetween.Name = "ComboDelayBetween";
            this.ComboDelayBetween.Size = new System.Drawing.Size(64, 23);
            this.ComboDelayBetween.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Delay between commands:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "milliseconds";
            // 
            // ComboDelayStart
            // 
            this.ComboDelayStart.FormattingEnabled = true;
            this.ComboDelayStart.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1500",
            "2000"});
            this.ComboDelayStart.Location = new System.Drawing.Point(278, 19);
            this.ComboDelayStart.Name = "ComboDelayStart";
            this.ComboDelayStart.Size = new System.Drawing.Size(64, 23);
            this.ComboDelayStart.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delay on start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "milliseconds";
            // 
            // ComboDelayAfterPaste
            // 
            this.ComboDelayAfterPaste.FormattingEnabled = true;
            this.ComboDelayAfterPaste.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1500",
            "2000"});
            this.ComboDelayAfterPaste.Location = new System.Drawing.Point(278, 106);
            this.ComboDelayAfterPaste.Name = "ComboDelayAfterPaste";
            this.ComboDelayAfterPaste.Size = new System.Drawing.Size(64, 23);
            this.ComboDelayAfterPaste.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delay after \'Paste\' or \'PasteText\' commands:";
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Location = new System.Drawing.Point(302, 316);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(383, 316);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "milliseconds";
            // 
            // ComboDelayBeforePaste
            // 
            this.ComboDelayBeforePaste.FormattingEnabled = true;
            this.ComboDelayBeforePaste.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1500",
            "2000"});
            this.ComboDelayBeforePaste.Location = new System.Drawing.Point(278, 77);
            this.ComboDelayBeforePaste.Name = "ComboDelayBeforePaste";
            this.ComboDelayBeforePaste.Size = new System.Drawing.Size(64, 23);
            this.ComboDelayBeforePaste.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Delay before \'Paste\' or \'PasteText\' commands:";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 351);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboDelayAfterPaste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboDelayStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboDelayBetween;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckCloseToTray;
        private System.Windows.Forms.CheckBox CheckMinimizeOnRun;
        private System.Windows.Forms.CheckBox CheckStartInTray;
        private System.Windows.Forms.CheckBox CheckRememberEditorWindowPosition;
        private System.Windows.Forms.CheckBox CheckRememberEditorWindowSize;
        private System.Windows.Forms.CheckBox CheckRememberMainWindowPosition;
        private System.Windows.Forms.CheckBox CheckRememberMainWindowSize;
        private System.Windows.Forms.CheckBox CheckReturnMouse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboDelayBeforePaste;
        private System.Windows.Forms.Label label8;
    }
}