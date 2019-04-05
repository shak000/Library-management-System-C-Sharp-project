namespace Login
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelLibraryManagementSystem = new System.Windows.Forms.Label();
            this.panelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.Color.White;
            this.panelMiddle.Controls.Add(this.btnLogin);
            this.panelMiddle.Controls.Add(this.txtPassword);
            this.panelMiddle.Controls.Add(this.txtUsername);
            this.panelMiddle.Controls.Add(this.pictureBoxLogin);
            this.panelMiddle.Location = new System.Drawing.Point(233, 111);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(346, 359);
            this.panelMiddle.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(112, 301);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(55, 221);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(236, 33);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassEnter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassLeave);
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(55, 159);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(236, 33);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Enter += new System.EventHandler(this.txtUserEnter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUesrLeave);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(112, 21);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(123, 104);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogin.TabIndex = 0;
            this.pictureBoxLogin.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Navy;
            this.panelTop.Controls.Add(this.pictureBoxCross);
            this.panelTop.Controls.Add(this.labelLogin);
            this.panelTop.Controls.Add(this.labelLibraryManagementSystem);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(799, 164);
            this.panelTop.TabIndex = 1;
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(766, 0);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCross.TabIndex = 3;
            this.pictureBoxCross.TabStop = false;
            this.pictureBoxCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.Transparent;
            this.labelLogin.Location = new System.Drawing.Point(337, 53);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(141, 26);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "User Login";
            // 
            // labelLibraryManagementSystem
            // 
            this.labelLibraryManagementSystem.AutoSize = true;
            this.labelLibraryManagementSystem.BackColor = System.Drawing.Color.Transparent;
            this.labelLibraryManagementSystem.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibraryManagementSystem.ForeColor = System.Drawing.Color.White;
            this.labelLibraryManagementSystem.Location = new System.Drawing.Point(201, 18);
            this.labelLibraryManagementSystem.Name = "labelLibraryManagementSystem";
            this.labelLibraryManagementSystem.Size = new System.Drawing.Size(418, 30);
            this.labelLibraryManagementSystem.TabIndex = 1;
            this.labelLibraryManagementSystem.Text = "Library Management System";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 517);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Button btnLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelLibraryManagementSystem;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
    }
}

