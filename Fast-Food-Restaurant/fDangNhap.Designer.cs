namespace Fast_Food_Restaurant
{
    partial class fDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangNhap));
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
            this.Label_Title = new DevExpress.XtraEditors.LabelControl();
            this.Picture_eyeDisplayPass = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.label_Password = new DevExpress.XtraEditors.LabelControl();
            this.Label_Account = new DevExpress.XtraEditors.LabelControl();
            this.txt_Account = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_eyeDisplayPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Account.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Fast_Food_Restaurant.Properties.Resources.delete_2_icon;
            this.btn_exit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_exit.Location = new System.Drawing.Point(645, 338);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 65);
            this.btn_exit.TabIndex = 33;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Image = global::Fast_Food_Restaurant.Properties.Resources.secrecy_icon1;
            this.btn_Login.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Login.Location = new System.Drawing.Point(513, 338);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(101, 65);
            this.btn_Login.TabIndex = 32;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Label_Title
            // 
            this.Label_Title.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Label_Title.Location = new System.Drawing.Point(364, 62);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(122, 24);
            this.Label_Title.TabIndex = 31;
            this.Label_Title.Text = "ĐĂNG NHẬP";
            // 
            // Picture_eyeDisplayPass
            // 
            this.Picture_eyeDisplayPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.Picture_eyeDisplayPass.EditValue = global::Fast_Food_Restaurant.Properties.Resources.eye_icon;
            this.Picture_eyeDisplayPass.Location = new System.Drawing.Point(713, 276);
            this.Picture_eyeDisplayPass.Name = "Picture_eyeDisplayPass";
            this.Picture_eyeDisplayPass.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Picture_eyeDisplayPass.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.Picture_eyeDisplayPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Picture_eyeDisplayPass.Size = new System.Drawing.Size(32, 26);
            this.Picture_eyeDisplayPass.TabIndex = 30;
            this.Picture_eyeDisplayPass.Click += new System.EventHandler(this.Picture_eyeDisplayPass_Click);
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(513, 276);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(32, 26);
            this.pictureEdit3.TabIndex = 29;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(513, 226);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(32, 26);
            this.pictureEdit2.TabIndex = 28;
            // 
            // txt_Password
            // 
            this.txt_Password.EditValue = "";
            this.txt_Password.Location = new System.Drawing.Point(544, 276);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Password.Properties.Appearance.Options.UseFont = true;
            this.txt_Password.Properties.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(201, 26);
            this.txt_Password.TabIndex = 27;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // label_Password
            // 
            this.label_Password.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_Password.Location = new System.Drawing.Point(409, 283);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(77, 19);
            this.label_Password.TabIndex = 26;
            this.label_Password.Text = "Mật Khẩu";
            // 
            // Label_Account
            // 
            this.Label_Account.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Label_Account.Location = new System.Drawing.Point(409, 233);
            this.Label_Account.Name = "Label_Account";
            this.Label_Account.Size = new System.Drawing.Size(82, 19);
            this.Label_Account.TabIndex = 25;
            this.Label_Account.Text = "Tài Khoản";
            // 
            // txt_Account
            // 
            this.txt_Account.EditValue = "";
            this.txt_Account.Location = new System.Drawing.Point(544, 226);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Account.Properties.Appearance.Options.UseFont = true;
            this.txt_Account.Size = new System.Drawing.Size(201, 26);
            this.txt_Account.TabIndex = 24;
            this.txt_Account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Account_KeyPress);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.BackgroundImage")));
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(93, 180);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(240, 223);
            this.pictureEdit1.TabIndex = 23;
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(872, 501);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Picture_eyeDisplayPass);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.Label_Account);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.pictureEdit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDangNhap";
            this.Text = "fDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDangNhap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_eyeDisplayPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Account.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_exit;
        private DevExpress.XtraEditors.SimpleButton btn_Login;
        private DevExpress.XtraEditors.LabelControl Label_Title;
        private DevExpress.XtraEditors.PictureEdit Picture_eyeDisplayPass;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private DevExpress.XtraEditors.LabelControl label_Password;
        private DevExpress.XtraEditors.LabelControl Label_Account;
        private DevExpress.XtraEditors.TextEdit txt_Account;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}