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
            this.txtHotkey = new System.Windows.Forms.TextBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAbsolute = new System.Windows.Forms.Label();
            this.timerMouse = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblRelative = new System.Windows.Forms.Label();
            this.LblMonitor = new System.Windows.Forms.Label();
            this.LblResolution = new System.Windows.Forms.Label();
            this.BtnMousePositionMonitor = new System.Windows.Forms.Button();
            this.BtnMousePosition = new System.Windows.Forms.Button();
            this.BtnMouseMove = new System.Windows.Forms.Button();
            this.BtnMouseClickLeft = new System.Windows.Forms.Button();
            this.BtnMouseClickMiddle = new System.Windows.Forms.Button();
            this.BtnMouseClickRight = new System.Windows.Forms.Button();
            this.BtnKey = new System.Windows.Forms.Button();
            this.BtnKey1 = new System.Windows.Forms.Button();
            this.BtnDelay = new System.Windows.Forms.Button();
            this.BtnDelay1 = new System.Windows.Forms.Button();
            this.BtnDelay2 = new System.Windows.Forms.Button();
            this.BtnDelay3 = new System.Windows.Forms.Button();
            this.TxtDelay1 = new System.Windows.Forms.TextBox();
            this.TxtDelay2 = new System.Windows.Forms.TextBox();
            this.TxtDelay3 = new System.Windows.Forms.TextBox();
            this.TxtKey1 = new System.Windows.Forms.TextBox();
            this.TxtKey2 = new System.Windows.Forms.TextBox();
            this.BtnKey2 = new System.Windows.Forms.Button();
            this.TxtKey3 = new System.Windows.Forms.TextBox();
            this.BtnKey3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnMouseDownLeft = new System.Windows.Forms.Button();
            this.BtnMouseUpLeft = new System.Windows.Forms.Button();
            this.BtnWindowPositionMonitor = new System.Windows.Forms.Button();
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
            this.panelTop.Size = new System.Drawing.Size(697, 51);
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
            this.btnOk.Location = new System.Drawing.Point(515, 670);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(596, 670);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
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
            this.labelLineTop.Size = new System.Drawing.Size(699, 2);
            this.labelLineTop.TabIndex = 25;
            this.labelLineTop.Text = "labelLine1";
            // 
            // labelLineBottom
            // 
            this.labelLineBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLineBottom.Location = new System.Drawing.Point(-1, 655);
            this.labelLineBottom.Name = "labelLineBottom";
            this.labelLineBottom.Size = new System.Drawing.Size(699, 2);
            this.labelLineBottom.TabIndex = 26;
            this.labelLineBottom.Text = "label1";
            // 
            // labelHotkey
            // 
            this.labelHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHotkey.AutoSize = true;
            this.labelHotkey.Location = new System.Drawing.Point(209, 79);
            this.labelHotkey.Name = "labelHotkey";
            this.labelHotkey.Size = new System.Drawing.Size(44, 13);
            this.labelHotkey.TabIndex = 24;
            this.labelHotkey.Text = "Hotkey:";
            // 
            // txtHotkey
            // 
            this.txtHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotkey.Location = new System.Drawing.Point(259, 76);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.Size = new System.Drawing.Size(120, 20);
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
            this.txtAction.Location = new System.Drawing.Point(24, 118);
            this.txtAction.Multiline = true;
            this.txtAction.Name = "txtAction";
            this.txtAction.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAction.Size = new System.Drawing.Size(355, 512);
            this.txtAction.TabIndex = 27;
            this.txtAction.DoubleClick += new System.EventHandler(this.txtAction_DoubleClick);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(65, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
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
            // LblAbsolute
            // 
            this.LblAbsolute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblAbsolute.AutoSize = true;
            this.LblAbsolute.Location = new System.Drawing.Point(161, 683);
            this.LblAbsolute.Name = "LblAbsolute";
            this.LblAbsolute.Size = new System.Drawing.Size(25, 13);
            this.LblAbsolute.TabIndex = 32;
            this.LblAbsolute.Text = "0, 0";
            // 
            // timerMouse
            // 
            this.timerMouse.Interval = 50;
            this.timerMouse.Tick += new System.EventHandler(this.timerMouse_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 683);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mouse position (Windows):";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mouse position (Monitor):";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 666);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Monitor number:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 683);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Monitor resolution:";
            // 
            // LblRelative
            // 
            this.LblRelative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblRelative.AutoSize = true;
            this.LblRelative.Location = new System.Drawing.Point(161, 667);
            this.LblRelative.Name = "LblRelative";
            this.LblRelative.Size = new System.Drawing.Size(25, 13);
            this.LblRelative.TabIndex = 39;
            this.LblRelative.Text = "0, 0";
            // 
            // LblMonitor
            // 
            this.LblMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblMonitor.AutoSize = true;
            this.LblMonitor.Location = new System.Drawing.Point(355, 666);
            this.LblMonitor.Name = "LblMonitor";
            this.LblMonitor.Size = new System.Drawing.Size(13, 13);
            this.LblMonitor.TabIndex = 40;
            this.LblMonitor.Text = "1";
            // 
            // LblResolution
            // 
            this.LblResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblResolution.AutoSize = true;
            this.LblResolution.Location = new System.Drawing.Point(355, 683);
            this.LblResolution.Name = "LblResolution";
            this.LblResolution.Size = new System.Drawing.Size(25, 13);
            this.LblResolution.TabIndex = 42;
            this.LblResolution.Text = "0, 0";
            // 
            // BtnMousePositionMonitor
            // 
            this.BtnMousePositionMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMousePositionMonitor.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnMousePositionMonitor.Image = ((System.Drawing.Image)(resources.GetObject("BtnMousePositionMonitor.Image")));
            this.BtnMousePositionMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMousePositionMonitor.Location = new System.Drawing.Point(428, 76);
            this.BtnMousePositionMonitor.Name = "BtnMousePositionMonitor";
            this.BtnMousePositionMonitor.Size = new System.Drawing.Size(245, 24);
            this.BtnMousePositionMonitor.TabIndex = 3;
            this.BtnMousePositionMonitor.Text = "MousePosition(X,Y,Monitor)...";
            this.BtnMousePositionMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMousePositionMonitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMousePositionMonitor.UseVisualStyleBackColor = true;
            this.BtnMousePositionMonitor.Click += new System.EventHandler(this.BtnMousePositionMonitor_Click);
            // 
            // BtnMousePosition
            // 
            this.BtnMousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMousePosition.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnMousePosition.Image = ((System.Drawing.Image)(resources.GetObject("BtnMousePosition.Image")));
            this.BtnMousePosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMousePosition.Location = new System.Drawing.Point(428, 106);
            this.BtnMousePosition.Name = "BtnMousePosition";
            this.BtnMousePosition.Size = new System.Drawing.Size(245, 24);
            this.BtnMousePosition.TabIndex = 4;
            this.BtnMousePosition.Text = "MousePosition(X,Y)...";
            this.BtnMousePosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMousePosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMousePosition.UseVisualStyleBackColor = true;
            this.BtnMousePosition.Click += new System.EventHandler(this.BtnMousePosition_Click);
            // 
            // BtnMouseMove
            // 
            this.BtnMouseMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMouseMove.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnMouseMove.Image = ((System.Drawing.Image)(resources.GetObject("BtnMouseMove.Image")));
            this.BtnMouseMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseMove.Location = new System.Drawing.Point(428, 136);
            this.BtnMouseMove.Name = "BtnMouseMove";
            this.BtnMouseMove.Size = new System.Drawing.Size(245, 24);
            this.BtnMouseMove.TabIndex = 5;
            this.BtnMouseMove.Text = "MouseMove(X,Y)";
            this.BtnMouseMove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMouseMove.UseVisualStyleBackColor = true;
            this.BtnMouseMove.Click += new System.EventHandler(this.BtnMouseMove_Click);
            // 
            // BtnMouseClickLeft
            // 
            this.BtnMouseClickLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMouseClickLeft.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnMouseClickLeft.Image = ((System.Drawing.Image)(resources.GetObject("BtnMouseClickLeft.Image")));
            this.BtnMouseClickLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseClickLeft.Location = new System.Drawing.Point(428, 176);
            this.BtnMouseClickLeft.Name = "BtnMouseClickLeft";
            this.BtnMouseClickLeft.Size = new System.Drawing.Size(245, 24);
            this.BtnMouseClickLeft.TabIndex = 6;
            this.BtnMouseClickLeft.Text = "MouseClick(Left)";
            this.BtnMouseClickLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseClickLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMouseClickLeft.UseVisualStyleBackColor = true;
            this.BtnMouseClickLeft.Click += new System.EventHandler(this.BtnMouseClickLeft_Click);
            // 
            // BtnMouseClickMiddle
            // 
            this.BtnMouseClickMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMouseClickMiddle.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnMouseClickMiddle.Image = ((System.Drawing.Image)(resources.GetObject("BtnMouseClickMiddle.Image")));
            this.BtnMouseClickMiddle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseClickMiddle.Location = new System.Drawing.Point(428, 206);
            this.BtnMouseClickMiddle.Name = "BtnMouseClickMiddle";
            this.BtnMouseClickMiddle.Size = new System.Drawing.Size(245, 24);
            this.BtnMouseClickMiddle.TabIndex = 7;
            this.BtnMouseClickMiddle.Text = "MouseClick(Middle)";
            this.BtnMouseClickMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseClickMiddle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMouseClickMiddle.UseVisualStyleBackColor = true;
            this.BtnMouseClickMiddle.Click += new System.EventHandler(this.BtnMouseClickMiddle_Click);
            // 
            // BtnMouseClickRight
            // 
            this.BtnMouseClickRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMouseClickRight.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnMouseClickRight.Image = ((System.Drawing.Image)(resources.GetObject("BtnMouseClickRight.Image")));
            this.BtnMouseClickRight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseClickRight.Location = new System.Drawing.Point(428, 236);
            this.BtnMouseClickRight.Name = "BtnMouseClickRight";
            this.BtnMouseClickRight.Size = new System.Drawing.Size(245, 24);
            this.BtnMouseClickRight.TabIndex = 8;
            this.BtnMouseClickRight.Text = "MouseClick(Right)";
            this.BtnMouseClickRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseClickRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMouseClickRight.UseVisualStyleBackColor = true;
            this.BtnMouseClickRight.Click += new System.EventHandler(this.BtnMouseClickRight_Click);
            // 
            // BtnKey
            // 
            this.BtnKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKey.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnKey.Image = ((System.Drawing.Image)(resources.GetObject("BtnKey.Image")));
            this.BtnKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKey.Location = new System.Drawing.Point(428, 346);
            this.BtnKey.Name = "BtnKey";
            this.BtnKey.Size = new System.Drawing.Size(245, 24);
            this.BtnKey.TabIndex = 11;
            this.BtnKey.Text = "Key(n)...";
            this.BtnKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKey.UseVisualStyleBackColor = true;
            this.BtnKey.Click += new System.EventHandler(this.BtnKey_Click);
            // 
            // BtnKey1
            // 
            this.BtnKey1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKey1.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnKey1.Image = ((System.Drawing.Image)(resources.GetObject("BtnKey1.Image")));
            this.BtnKey1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKey1.Location = new System.Drawing.Point(428, 376);
            this.BtnKey1.Name = "BtnKey1";
            this.BtnKey1.Size = new System.Drawing.Size(165, 24);
            this.BtnKey1.TabIndex = 12;
            this.BtnKey1.Text = "Key(n)";
            this.BtnKey1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKey1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKey1.UseVisualStyleBackColor = true;
            this.BtnKey1.Click += new System.EventHandler(this.BtnKey1_Click);
            // 
            // BtnDelay
            // 
            this.BtnDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelay.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnDelay.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelay.Image")));
            this.BtnDelay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelay.Location = new System.Drawing.Point(428, 476);
            this.BtnDelay.Name = "BtnDelay";
            this.BtnDelay.Size = new System.Drawing.Size(245, 24);
            this.BtnDelay.TabIndex = 18;
            this.BtnDelay.Text = "Delay(n)";
            this.BtnDelay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelay.UseVisualStyleBackColor = true;
            this.BtnDelay.Click += new System.EventHandler(this.BtnDelay_Click);
            // 
            // BtnDelay1
            // 
            this.BtnDelay1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelay1.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnDelay1.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelay1.Image")));
            this.BtnDelay1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelay1.Location = new System.Drawing.Point(428, 506);
            this.BtnDelay1.Name = "BtnDelay1";
            this.BtnDelay1.Size = new System.Drawing.Size(165, 24);
            this.BtnDelay1.TabIndex = 19;
            this.BtnDelay1.Text = "Delay(n)";
            this.BtnDelay1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelay1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelay1.UseVisualStyleBackColor = true;
            this.BtnDelay1.Click += new System.EventHandler(this.BtnDelay1_Click);
            // 
            // BtnDelay2
            // 
            this.BtnDelay2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelay2.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnDelay2.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelay2.Image")));
            this.BtnDelay2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelay2.Location = new System.Drawing.Point(428, 536);
            this.BtnDelay2.Name = "BtnDelay2";
            this.BtnDelay2.Size = new System.Drawing.Size(165, 24);
            this.BtnDelay2.TabIndex = 21;
            this.BtnDelay2.Text = "Delay(n)";
            this.BtnDelay2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelay2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelay2.UseVisualStyleBackColor = true;
            this.BtnDelay2.Click += new System.EventHandler(this.BtnDelay2_Click);
            // 
            // BtnDelay3
            // 
            this.BtnDelay3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelay3.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnDelay3.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelay3.Image")));
            this.BtnDelay3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelay3.Location = new System.Drawing.Point(428, 566);
            this.BtnDelay3.Name = "BtnDelay3";
            this.BtnDelay3.Size = new System.Drawing.Size(165, 24);
            this.BtnDelay3.TabIndex = 23;
            this.BtnDelay3.Text = "Delay(n)";
            this.BtnDelay3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelay3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelay3.UseVisualStyleBackColor = true;
            this.BtnDelay3.Click += new System.EventHandler(this.BtnDelay3_Click);
            // 
            // TxtDelay1
            // 
            this.TxtDelay1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDelay1.Font = new System.Drawing.Font("Consolas", 9F);
            this.TxtDelay1.Location = new System.Drawing.Point(599, 507);
            this.TxtDelay1.Name = "TxtDelay1";
            this.TxtDelay1.Size = new System.Drawing.Size(73, 22);
            this.TxtDelay1.TabIndex = 20;
            this.TxtDelay1.TextChanged += new System.EventHandler(this.TxtDelay1_TextChanged);
            // 
            // TxtDelay2
            // 
            this.TxtDelay2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDelay2.Font = new System.Drawing.Font("Consolas", 9F);
            this.TxtDelay2.Location = new System.Drawing.Point(599, 537);
            this.TxtDelay2.Name = "TxtDelay2";
            this.TxtDelay2.Size = new System.Drawing.Size(73, 22);
            this.TxtDelay2.TabIndex = 22;
            this.TxtDelay2.TextChanged += new System.EventHandler(this.TxtDelay2_TextChanged);
            // 
            // TxtDelay3
            // 
            this.TxtDelay3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDelay3.Font = new System.Drawing.Font("Consolas", 9F);
            this.TxtDelay3.Location = new System.Drawing.Point(599, 567);
            this.TxtDelay3.Name = "TxtDelay3";
            this.TxtDelay3.Size = new System.Drawing.Size(73, 22);
            this.TxtDelay3.TabIndex = 24;
            this.TxtDelay3.TextChanged += new System.EventHandler(this.TxtDelay3_TextChanged);
            // 
            // TxtKey1
            // 
            this.TxtKey1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtKey1.Font = new System.Drawing.Font("Consolas", 9F);
            this.TxtKey1.Location = new System.Drawing.Point(599, 377);
            this.TxtKey1.Name = "TxtKey1";
            this.TxtKey1.Size = new System.Drawing.Size(73, 22);
            this.TxtKey1.TabIndex = 13;
            this.TxtKey1.TextChanged += new System.EventHandler(this.TxtKey1_TextChanged);
            // 
            // TxtKey2
            // 
            this.TxtKey2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtKey2.Font = new System.Drawing.Font("Consolas", 9F);
            this.TxtKey2.Location = new System.Drawing.Point(599, 407);
            this.TxtKey2.Name = "TxtKey2";
            this.TxtKey2.Size = new System.Drawing.Size(73, 22);
            this.TxtKey2.TabIndex = 15;
            this.TxtKey2.TextChanged += new System.EventHandler(this.TxtKey2_TextChanged);
            // 
            // BtnKey2
            // 
            this.BtnKey2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKey2.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnKey2.Image = ((System.Drawing.Image)(resources.GetObject("BtnKey2.Image")));
            this.BtnKey2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKey2.Location = new System.Drawing.Point(428, 406);
            this.BtnKey2.Name = "BtnKey2";
            this.BtnKey2.Size = new System.Drawing.Size(165, 24);
            this.BtnKey2.TabIndex = 14;
            this.BtnKey2.Text = "Key(n)";
            this.BtnKey2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKey2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKey2.UseVisualStyleBackColor = true;
            this.BtnKey2.Click += new System.EventHandler(this.BtnKey2_Click);
            // 
            // TxtKey3
            // 
            this.TxtKey3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtKey3.Font = new System.Drawing.Font("Consolas", 9F);
            this.TxtKey3.Location = new System.Drawing.Point(599, 437);
            this.TxtKey3.Name = "TxtKey3";
            this.TxtKey3.Size = new System.Drawing.Size(73, 22);
            this.TxtKey3.TabIndex = 17;
            this.TxtKey3.TextChanged += new System.EventHandler(this.TxtKey3_TextChanged);
            // 
            // BtnKey3
            // 
            this.BtnKey3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKey3.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnKey3.Image = ((System.Drawing.Image)(resources.GetObject("BtnKey3.Image")));
            this.BtnKey3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKey3.Location = new System.Drawing.Point(428, 436);
            this.BtnKey3.Name = "BtnKey3";
            this.BtnKey3.Size = new System.Drawing.Size(165, 24);
            this.BtnKey3.TabIndex = 16;
            this.BtnKey3.Text = "Key(n)";
            this.BtnKey3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKey3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKey3.UseVisualStyleBackColor = true;
            this.BtnKey3.Click += new System.EventHandler(this.BtnKey3_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(404, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 604);
            this.label7.TabIndex = 64;
            this.label7.Text = "label1";
            // 
            // BtnMouseDownLeft
            // 
            this.BtnMouseDownLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMouseDownLeft.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnMouseDownLeft.Image = ((System.Drawing.Image)(resources.GetObject("BtnMouseDownLeft.Image")));
            this.BtnMouseDownLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseDownLeft.Location = new System.Drawing.Point(428, 276);
            this.BtnMouseDownLeft.Name = "BtnMouseDownLeft";
            this.BtnMouseDownLeft.Size = new System.Drawing.Size(245, 24);
            this.BtnMouseDownLeft.TabIndex = 9;
            this.BtnMouseDownLeft.Text = "MouseDown(Left)";
            this.BtnMouseDownLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseDownLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMouseDownLeft.UseVisualStyleBackColor = true;
            this.BtnMouseDownLeft.Click += new System.EventHandler(this.BtnMouseDownLeft_Click);
            // 
            // BtnMouseUpLeft
            // 
            this.BtnMouseUpLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMouseUpLeft.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnMouseUpLeft.Image = ((System.Drawing.Image)(resources.GetObject("BtnMouseUpLeft.Image")));
            this.BtnMouseUpLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseUpLeft.Location = new System.Drawing.Point(428, 306);
            this.BtnMouseUpLeft.Name = "BtnMouseUpLeft";
            this.BtnMouseUpLeft.Size = new System.Drawing.Size(245, 24);
            this.BtnMouseUpLeft.TabIndex = 10;
            this.BtnMouseUpLeft.Text = "MouseUp(Left)";
            this.BtnMouseUpLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMouseUpLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMouseUpLeft.UseVisualStyleBackColor = true;
            this.BtnMouseUpLeft.Click += new System.EventHandler(this.BtnMouseUpLeft_Click);
            // 
            // BtnWindowPositionMonitor
            // 
            this.BtnWindowPositionMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWindowPositionMonitor.Font = new System.Drawing.Font("Consolas", 9F);
            this.BtnWindowPositionMonitor.Image = ((System.Drawing.Image)(resources.GetObject("BtnWindowPositionMonitor.Image")));
            this.BtnWindowPositionMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWindowPositionMonitor.Location = new System.Drawing.Point(428, 606);
            this.BtnWindowPositionMonitor.Name = "BtnWindowPositionMonitor";
            this.BtnWindowPositionMonitor.Size = new System.Drawing.Size(245, 24);
            this.BtnWindowPositionMonitor.TabIndex = 65;
            this.BtnWindowPositionMonitor.Text = "WindowPosition(X,Y,Monitor)...";
            this.BtnWindowPositionMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWindowPositionMonitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnWindowPositionMonitor.UseVisualStyleBackColor = true;
            this.BtnWindowPositionMonitor.Click += new System.EventHandler(this.BtnWindowPositionMonitor_Click);
            // 
            // FormAddHotkey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(697, 706);
            this.Controls.Add(this.BtnWindowPositionMonitor);
            this.Controls.Add(this.LblResolution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblMonitor);
            this.Controls.Add(this.BtnMouseUpLeft);
            this.Controls.Add(this.BtnMouseDownLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblAbsolute);
            this.Controls.Add(this.LblRelative);
            this.Controls.Add(this.labelLineBottom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtKey3);
            this.Controls.Add(this.BtnKey3);
            this.Controls.Add(this.TxtKey2);
            this.Controls.Add(this.BtnKey2);
            this.Controls.Add(this.TxtKey1);
            this.Controls.Add(this.TxtDelay3);
            this.Controls.Add(this.TxtDelay2);
            this.Controls.Add(this.TxtDelay1);
            this.Controls.Add(this.BtnDelay3);
            this.Controls.Add(this.BtnDelay2);
            this.Controls.Add(this.BtnDelay1);
            this.Controls.Add(this.BtnDelay);
            this.Controls.Add(this.BtnKey1);
            this.Controls.Add(this.BtnKey);
            this.Controls.Add(this.BtnMouseClickRight);
            this.Controls.Add(this.BtnMouseClickMiddle);
            this.Controls.Add(this.BtnMouseClickLeft);
            this.Controls.Add(this.BtnMouseMove);
            this.Controls.Add(this.BtnMousePosition);
            this.Controls.Add(this.BtnMousePositionMonitor);
            this.Controls.Add(this.labelLineTop);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.labelHotkey);
            this.Controls.Add(this.txtHotkey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(713, 745);
            this.Name = "FormAddHotkey";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Macro Hotkey";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddHotkey_FormClosing);
            this.Load += new System.EventHandler(this.FormAddHotkey_Load);
            this.Shown += new System.EventHandler(this.FormAddHotkey_Shown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
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
        private System.Windows.Forms.TextBox txtHotkey;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAbsolute;
        private System.Windows.Forms.Timer timerMouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblRelative;
        private System.Windows.Forms.Label LblMonitor;
        private System.Windows.Forms.Label LblResolution;
        private System.Windows.Forms.Button BtnMousePositionMonitor;
        private System.Windows.Forms.Button BtnMousePosition;
        private System.Windows.Forms.Button BtnMouseMove;
        private System.Windows.Forms.Button BtnMouseClickLeft;
        private System.Windows.Forms.Button BtnMouseClickMiddle;
        private System.Windows.Forms.Button BtnMouseClickRight;
        private System.Windows.Forms.Button BtnKey;
        private System.Windows.Forms.Button BtnKey1;
        private System.Windows.Forms.Button BtnDelay;
        private System.Windows.Forms.Button BtnDelay1;
        private System.Windows.Forms.Button BtnDelay2;
        private System.Windows.Forms.Button BtnDelay3;
        private System.Windows.Forms.TextBox TxtDelay1;
        private System.Windows.Forms.TextBox TxtDelay2;
        private System.Windows.Forms.TextBox TxtDelay3;
        private System.Windows.Forms.TextBox TxtKey1;
        private System.Windows.Forms.TextBox TxtKey2;
        private System.Windows.Forms.Button BtnKey2;
        private System.Windows.Forms.TextBox TxtKey3;
        private System.Windows.Forms.Button BtnKey3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnMouseDownLeft;
        private System.Windows.Forms.Button BtnMouseUpLeft;
        private System.Windows.Forms.Button BtnWindowPositionMonitor;
    }
}