﻿namespace MacroHotkey
{
    partial class FormGetKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGetKey));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLineTop = new System.Windows.Forms.Label();
            this.labelLineBottom = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ChkShift = new System.Windows.Forms.CheckBox();
            this.ChkCtrl = new System.Windows.Forms.CheckBox();
            this.ChkAlt = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelTop.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(335, 51);
            this.panelTop.TabIndex = 49;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(21, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(130, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Add keystroke or text";
            this.labelName.UseMnemonic = false;
            // 
            // labelLineTop
            // 
            this.labelLineTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLineTop.Location = new System.Drawing.Point(-1, 51);
            this.labelLineTop.Name = "labelLineTop";
            this.labelLineTop.Size = new System.Drawing.Size(337, 2);
            this.labelLineTop.TabIndex = 52;
            this.labelLineTop.Text = "labelLine1";
            // 
            // labelLineBottom
            // 
            this.labelLineBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLineBottom.Location = new System.Drawing.Point(-1, 150);
            this.labelLineBottom.Name = "labelLineBottom";
            this.labelLineBottom.Size = new System.Drawing.Size(337, 2);
            this.labelLineBottom.TabIndex = 53;
            this.labelLineBottom.Text = "label1";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(153, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 48;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(234, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChkShift
            // 
            this.ChkShift.AutoSize = true;
            this.ChkShift.Location = new System.Drawing.Point(24, 112);
            this.ChkShift.Name = "ChkShift";
            this.ChkShift.Size = new System.Drawing.Size(47, 17);
            this.ChkShift.TabIndex = 55;
            this.ChkShift.Text = "Shift";
            this.ChkShift.UseVisualStyleBackColor = true;
            this.ChkShift.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
            // 
            // ChkCtrl
            // 
            this.ChkCtrl.AutoSize = true;
            this.ChkCtrl.Location = new System.Drawing.Point(87, 112);
            this.ChkCtrl.Name = "ChkCtrl";
            this.ChkCtrl.Size = new System.Drawing.Size(41, 17);
            this.ChkCtrl.TabIndex = 56;
            this.ChkCtrl.Text = "Ctrl";
            this.ChkCtrl.UseVisualStyleBackColor = true;
            this.ChkCtrl.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
            // 
            // ChkAlt
            // 
            this.ChkAlt.AutoSize = true;
            this.ChkAlt.Location = new System.Drawing.Point(144, 112);
            this.ChkAlt.Name = "ChkAlt";
            this.ChkAlt.Size = new System.Drawing.Size(38, 17);
            this.ChkAlt.TabIndex = 57;
            this.ChkAlt.Text = "Alt";
            this.ChkAlt.UseVisualStyleBackColor = true;
            this.ChkAlt.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "{BACKSPACE}",
            "{BREAK}",
            "{CAPSLOCK}",
            "{DELETE}",
            "{DOWN}",
            "{END}",
            "{ENTER}",
            "{ESC}",
            "{HELP}",
            "{HOME}",
            "{INSERT}",
            "{LEFT}",
            "{NUMLOCK}",
            "{PGDN}",
            "{PGUP}",
            "{PRTSC}",
            "{RIGHT}",
            "{SCROLLLOCK}",
            "{TAB}",
            "{UP}",
            "{F1}",
            "{F2}",
            "{F3}",
            "{F4}",
            "{F5}",
            "{F6}",
            "{F7}",
            "{F8}",
            "{F9}",
            "{F10}",
            "{F11}",
            "{F12}",
            "{F13}",
            "{F14}",
            "{F15}",
            "{F16}",
            "{ADD}",
            "{SUBTRACT}",
            "{MULTIPLY}",
            "{DIVIDE}"});
            this.comboBox1.Location = new System.Drawing.Point(24, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 21);
            this.comboBox1.TabIndex = 58;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // FormGetKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 201);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ChkAlt);
            this.Controls.Add(this.ChkCtrl);
            this.Controls.Add(this.ChkShift);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.labelLineTop);
            this.Controls.Add(this.labelLineBottom);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGetKey";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Macro Hotkey";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        protected System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLineTop;
        private System.Windows.Forms.Label labelLineBottom;
        protected System.Windows.Forms.Button btnOk;
        protected System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ChkShift;
        private System.Windows.Forms.CheckBox ChkCtrl;
        private System.Windows.Forms.CheckBox ChkAlt;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}