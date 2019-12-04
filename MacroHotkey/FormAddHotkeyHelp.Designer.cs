namespace MacroHotkey
{
    partial class FormAddHotkeyHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddHotkeyHelp));
            this.timerMouse = new System.Windows.Forms.Timer(this.components);
            this.labelMouse = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHelp = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Size = new System.Drawing.Size(33, 15);
            this.labelName.Text = "Help";
            // 
            // btnOk
            // 
            this.btnOk.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Text = "Close";
            // 
            // timerMouse
            // 
            this.timerMouse.Interval = 50;
            this.timerMouse.Tick += new System.EventHandler(this.timerMouse_Tick);
            // 
            // labelMouse
            // 
            this.labelMouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMouse.AutoSize = true;
            this.labelMouse.Location = new System.Drawing.Point(21, 268);
            this.labelMouse.Name = "labelMouse";
            this.labelMouse.Size = new System.Drawing.Size(123, 13);
            this.labelMouse.TabIndex = 27;
            this.labelMouse.Text = "Mouse position: 999,999";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtHelp);
            this.panel1.Location = new System.Drawing.Point(24, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 147);
            this.panel1.TabIndex = 29;
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHelp.BackColor = System.Drawing.SystemColors.Window;
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp.Location = new System.Drawing.Point(1, 1);
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.Size = new System.Drawing.Size(349, 143);
            this.txtHelp.TabIndex = 0;
            this.txtHelp.Text = "";
            this.txtHelp.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtHelp_LinkClicked);
            // 
            // FormAddHotkeyHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 299);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMouse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddHotkeyHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Macro Hotkey";
            this.Load += new System.EventHandler(this.FormAddHotkeyHelp_Load);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.labelMouse, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMouse;
        private System.Windows.Forms.Label labelMouse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtHelp;
    }
}