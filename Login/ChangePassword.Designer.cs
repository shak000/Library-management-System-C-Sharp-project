namespace Login
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.old = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Label();
            this.oldTF = new System.Windows.Forms.TextBox();
            this.newTF = new System.Windows.Forms.TextBox();
            this.conTF = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.passwordFetch = new System.Windows.Forms.Label();
            this.userFetch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // old
            // 
            this.old.AutoSize = true;
            this.old.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old.Location = new System.Drawing.Point(68, 46);
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(158, 21);
            this.old.TabIndex = 0;
            this.old.Text = "Old Password          :";
            // 
            // New
            // 
            this.New.AutoSize = true;
            this.New.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(68, 90);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(158, 21);
            this.New.TabIndex = 1;
            this.New.Text = "New Password        :";
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(68, 133);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(159, 21);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirm Password  :";
            // 
            // oldTF
            // 
            this.oldTF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldTF.Location = new System.Drawing.Point(271, 47);
            this.oldTF.Name = "oldTF";
            this.oldTF.PasswordChar = '*';
            this.oldTF.Size = new System.Drawing.Size(143, 26);
            this.oldTF.TabIndex = 3;
            // 
            // newTF
            // 
            this.newTF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTF.Location = new System.Drawing.Point(271, 90);
            this.newTF.Name = "newTF";
            this.newTF.PasswordChar = '*';
            this.newTF.Size = new System.Drawing.Size(143, 26);
            this.newTF.TabIndex = 4;
            // 
            // conTF
            // 
            this.conTF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conTF.Location = new System.Drawing.Point(271, 133);
            this.conTF.Name = "conTF";
            this.conTF.PasswordChar = '*';
            this.conTF.Size = new System.Drawing.Size(143, 26);
            this.conTF.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(96, 186);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(123, 36);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(247, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(456, 3);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCross.TabIndex = 8;
            this.pictureBoxCross.TabStop = false;
            this.pictureBoxCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // passwordFetch
            // 
            this.passwordFetch.AutoSize = true;
            this.passwordFetch.Location = new System.Drawing.Point(21, 29);
            this.passwordFetch.Name = "passwordFetch";
            this.passwordFetch.Size = new System.Drawing.Size(0, 13);
            this.passwordFetch.TabIndex = 9;
            this.passwordFetch.Visible = false;
            // 
            // userFetch
            // 
            this.userFetch.AutoSize = true;
            this.userFetch.Location = new System.Drawing.Point(77, 24);
            this.userFetch.Name = "userFetch";
            this.userFetch.Size = new System.Drawing.Size(0, 13);
            this.userFetch.TabIndex = 10;
            this.userFetch.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(492, 276);
            this.Controls.Add(this.userFetch);
            this.Controls.Add(this.passwordFetch);
            this.Controls.Add(this.pictureBoxCross);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.conTF);
            this.Controls.Add(this.newTF);
            this.Controls.Add(this.oldTF);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.New);
            this.Controls.Add(this.old);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.Label New;
        private System.Windows.Forms.Label old;
        private System.Windows.Forms.TextBox conTF;
        private System.Windows.Forms.TextBox newTF;
        private System.Windows.Forms.TextBox oldTF;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label passwordFetch;
        private System.Windows.Forms.Label userFetch;
    }
}