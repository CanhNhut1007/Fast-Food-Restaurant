namespace Fast_Food_Restaurant
{
    partial class fThongTinNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_MNVtk = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.Exit = new System.Windows.Forms.Button();
            this.txtmsnv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayvl = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton_lammoi = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(457, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 582);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(477, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(709, 530);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 506);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 12.28239F;
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 89.15262F;
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 12.28239F;
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.FillWeight = 25.0661F;
            this.Column4.HeaderText = "GT";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 12.28239F;
            this.Column5.HeaderText = "Số ĐT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 12.28239F;
            this.Column6.HeaderText = "Ngày VL";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 12.28239F;
            this.Column7.HeaderText = "Chức vụ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.simpleButton_lammoi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.cbb_chucvu);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.txtmsnv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayvl);
            this.groupBox1.Controls.Add(this.dateTimePickerNgaySinh);
            this.groupBox1.Controls.Add(this.radioNu);
            this.groupBox1.Controls.Add(this.radioNam);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(3, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 527);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8F);
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(22, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(393, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Sau đó, sửa thông tin ở bên trên rồi ấn nút cập nhật là thành công !";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8F);
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(22, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(435, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Nếu bạn muốn sửa thông tin nhân viên thì tìm kiếm mã nhân viên bên dưới";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton_timkiem);
            this.panel2.Controls.Add(this.cbb_MNVtk);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(36, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 74);
            this.panel2.TabIndex = 60;
            // 
            // simpleButton_timkiem
            // 
            this.simpleButton_timkiem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton_timkiem.Appearance.Options.UseFont = true;
            this.simpleButton_timkiem.Image = global::Fast_Food_Restaurant.Properties.Resources.TimKiem;
            this.simpleButton_timkiem.Location = new System.Drawing.Point(150, 37);
            this.simpleButton_timkiem.Name = "simpleButton_timkiem";
            this.simpleButton_timkiem.Size = new System.Drawing.Size(112, 36);
            this.simpleButton_timkiem.TabIndex = 61;
            this.simpleButton_timkiem.Text = "Tìm kiếm";
            this.simpleButton_timkiem.Click += new System.EventHandler(this.simpleButton_timkiem_Click);
            // 
            // cbb_MNVtk
            // 
            this.cbb_MNVtk.FormattingEnabled = true;
            this.cbb_MNVtk.Location = new System.Drawing.Point(202, 3);
            this.cbb_MNVtk.Name = "cbb_MNVtk";
            this.cbb_MNVtk.Size = new System.Drawing.Size(170, 24);
            this.cbb_MNVtk.TabIndex = 60;
            this.cbb_MNVtk.Text = "--Tìm mã nhân viên--";
            this.cbb_MNVtk.SelectedIndexChanged += new System.EventHandler(this.cbb_MNVtk_SelectedIndexChanged);
            this.cbb_MNVtk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbb_MNVtk_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label9.Location = new System.Drawing.Point(24, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mã số nhân viên";
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(238, 121);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(170, 24);
            this.cbb_chucvu.TabIndex = 59;
            this.cbb_chucvu.Text = "---Chọn chức vụ---";
            this.cbb_chucvu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbb_chucvu_KeyPress);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.Image = global::Fast_Food_Restaurant.Properties.Resources.add;
            this.btn_them.Location = new System.Drawing.Point(47, 270);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 36);
            this.btn_them.TabIndex = 58;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_sua.Appearance.Options.UseFont = true;
            this.btn_sua.Image = global::Fast_Food_Restaurant.Properties.Resources.Sua;
            this.btn_sua.Location = new System.Drawing.Point(198, 270);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(97, 36);
            this.btn_sua.TabIndex = 56;
            this.btn_sua.Text = "Cập nhật";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LimeGreen;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Image = global::Fast_Food_Restaurant.Properties.Resources.exit_icon;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(191, 477);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(104, 50);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Thoát";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // txtmsnv
            // 
            this.txtmsnv.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtmsnv.Location = new System.Drawing.Point(238, 13);
            this.txtmsnv.Name = "txtmsnv";
            this.txtmsnv.ReadOnly = true;
            this.txtmsnv.Size = new System.Drawing.Size(170, 26);
            this.txtmsnv.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(57, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã số nhân viên";
            // 
            // dateTimePickerNgayvl
            // 
            this.dateTimePickerNgayvl.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayvl.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateTimePickerNgayvl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayvl.Location = new System.Drawing.Point(238, 195);
            this.dateTimePickerNgayvl.Margin = new System.Windows.Forms.Padding(1);
            this.dateTimePickerNgayvl.Name = "dateTimePickerNgayvl";
            this.dateTimePickerNgayvl.Size = new System.Drawing.Size(170, 26);
            this.dateTimePickerNgayvl.TabIndex = 16;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(238, 82);
            this.dateTimePickerNgaySinh.Margin = new System.Windows.Forms.Padding(1);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(170, 26);
            this.dateTimePickerNgaySinh.TabIndex = 15;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.radioNu.Location = new System.Drawing.Point(360, 227);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(48, 23);
            this.radioNu.TabIndex = 14;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.radioNam.Location = new System.Drawing.Point(238, 227);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(57, 23);
            this.radioNam.TabIndex = 13;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label8.Location = new System.Drawing.Point(56, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Giới tính";
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtsdt.Location = new System.Drawing.Point(238, 157);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(170, 26);
            this.txtsdt.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtname.Location = new System.Drawing.Point(238, 46);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(170, 26);
            this.txtname.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(55, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày vào làm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(56, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(57, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(57, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(56, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // simpleButton_lammoi
            // 
            this.simpleButton_lammoi.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton_lammoi.Appearance.Options.UseFont = true;
            this.simpleButton_lammoi.Image = global::Fast_Food_Restaurant.Properties.Resources.restore;
            this.simpleButton_lammoi.Location = new System.Drawing.Point(345, 270);
            this.simpleButton_lammoi.Name = "simpleButton_lammoi";
            this.simpleButton_lammoi.Size = new System.Drawing.Size(112, 36);
            this.simpleButton_lammoi.TabIndex = 63;
            this.simpleButton_lammoi.Text = "Thêm mới";
            this.simpleButton_lammoi.Click += new System.EventHandler(this.simpleButton_lammoi_Click);
            // 
            // fThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 577);
            this.Controls.Add(this.panel1);
            this.Name = "fThongTinNhanVien";
            this.Text = "fThongTinNhanVien";
            this.Load += new System.EventHandler(this.fThongTinNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox txtmsnv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayvl;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_timkiem;
        private System.Windows.Forms.ComboBox cbb_MNVtk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private DevExpress.XtraEditors.SimpleButton simpleButton_lammoi;
    }
}