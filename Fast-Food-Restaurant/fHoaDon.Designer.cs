namespace Fast_Food_Restaurant
{
    partial class fHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TinhTien = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TienThua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TienNhan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_CTPBan = new System.Windows.Forms.GroupBox();
            this.dataGridView_CTHD = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_TenMA = new System.Windows.Forms.ComboBox();
            this.comboBox_TenLoaiMA = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_ngayHD = new System.Windows.Forms.DateTimePicker();
            this.comboBox_MANV = new System.Windows.Forms.ComboBox();
            this.txt_MAHD = new System.Windows.Forms.TextBox();
            this.label_nhd = new System.Windows.Forms.Label();
            this.label_mba = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label_mnv = new System.Windows.Forms.Label();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_mhd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxHD = new System.Windows.Forms.GroupBox();
            this.comboBox_MABA = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox_MAHD = new System.Windows.Forms.ComboBox();
            this.btn_ThemHD = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox_ttCTHD = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_NewHD = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_printHD = new DevExpress.XtraEditors.SimpleButton();
            this.btn_destroyHD = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaCTHD = new System.Windows.Forms.TextBox();
            this.btn_xoamonan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_capnhatmonan = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox_CTPBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CTHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxHD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_ttCTHD.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TinhTien);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_TienThua);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_TienNhan);
            this.groupBox1.Location = new System.Drawing.Point(20, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 127);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh toán:";
            // 
            // btn_TinhTien
            // 
            this.btn_TinhTien.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_TinhTien.Appearance.Options.UseFont = true;
            this.btn_TinhTien.Image = global::Fast_Food_Restaurant.Properties.Resources.calculator;
            this.btn_TinhTien.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_TinhTien.Location = new System.Drawing.Point(317, 36);
            this.btn_TinhTien.Name = "btn_TinhTien";
            this.btn_TinhTien.Size = new System.Drawing.Size(84, 39);
            this.btn_TinhTien.TabIndex = 49;
            this.btn_TinhTien.Text = "Tính tiền";
            this.btn_TinhTien.Click += new System.EventHandler(this.btn_TinhTien_Click);
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(114, 19);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(170, 23);
            this.txt_TongTien.TabIndex = 45;
            this.txt_TongTien.TabStop = false;
            this.txt_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 14);
            this.label3.TabIndex = 48;
            this.label3.Text = "------------------------------------------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tổng tiền:";
            // 
            // txt_TienThua
            // 
            this.txt_TienThua.Enabled = false;
            this.txt_TienThua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TienThua.Location = new System.Drawing.Point(114, 95);
            this.txt_TienThua.Name = "txt_TienThua";
            this.txt_TienThua.Size = new System.Drawing.Size(170, 23);
            this.txt_TienThua.TabIndex = 47;
            this.txt_TienThua.TabStop = false;
            this.txt_TienThua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tiền nhận:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tiền thừa:";
            // 
            // txt_TienNhan
            // 
            this.txt_TienNhan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TienNhan.Location = new System.Drawing.Point(114, 52);
            this.txt_TienNhan.Name = "txt_TienNhan";
            this.txt_TienNhan.Size = new System.Drawing.Size(170, 23);
            this.txt_TienNhan.TabIndex = 46;
            this.txt_TienNhan.TabStop = false;
            this.txt_TienNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_TienNhan.TextChanged += new System.EventHandler(this.txt_TienNhan_TextChanged);
            this.txt_TienNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TienNhan_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tên món ăn:";
            // 
            // groupBox_CTPBan
            // 
            this.groupBox_CTPBan.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox_CTPBan.Controls.Add(this.dataGridView_CTHD);
            this.groupBox_CTPBan.Location = new System.Drawing.Point(328, 5);
            this.groupBox_CTPBan.Name = "groupBox_CTPBan";
            this.groupBox_CTPBan.Size = new System.Drawing.Size(816, 228);
            this.groupBox_CTPBan.TabIndex = 2;
            this.groupBox_CTPBan.TabStop = false;
            this.groupBox_CTPBan.Text = "Chi tiết phiếu bán hàng";
            // 
            // dataGridView_CTHD
            // 
            this.dataGridView_CTHD.AllowUserToAddRows = false;
            this.dataGridView_CTHD.AllowUserToDeleteRows = false;
            this.dataGridView_CTHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView_CTHD.Location = new System.Drawing.Point(6, 16);
            this.dataGridView_CTHD.Name = "dataGridView_CTHD";
            this.dataGridView_CTHD.ReadOnly = true;
            this.dataGridView_CTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CTHD.Size = new System.Drawing.Size(804, 206);
            this.dataGridView_CTHD.TabIndex = 1;
            this.dataGridView_CTHD.TabStop = false;
            this.dataGridView_CTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CTHD_CellContentClick);
            this.dataGridView_CTHD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_CTHD_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hóa đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Loại món ăn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã món ăn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên món ăn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // comboBox_TenMA
            // 
            this.comboBox_TenMA.Enabled = false;
            this.comboBox_TenMA.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenMA.FormattingEnabled = true;
            this.comboBox_TenMA.Location = new System.Drawing.Point(126, 75);
            this.comboBox_TenMA.Name = "comboBox_TenMA";
            this.comboBox_TenMA.Size = new System.Drawing.Size(162, 23);
            this.comboBox_TenMA.TabIndex = 37;
            this.comboBox_TenMA.TabStop = false;
            this.comboBox_TenMA.Text = "-------Chọn món ăn-------";
            this.comboBox_TenMA.SelectedIndexChanged += new System.EventHandler(this.comboBox_TenMA_SelectedIndexChanged);
            // 
            // comboBox_TenLoaiMA
            // 
            this.comboBox_TenLoaiMA.Enabled = false;
            this.comboBox_TenLoaiMA.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenLoaiMA.FormattingEnabled = true;
            this.comboBox_TenLoaiMA.Location = new System.Drawing.Point(126, 39);
            this.comboBox_TenLoaiMA.Name = "comboBox_TenLoaiMA";
            this.comboBox_TenLoaiMA.Size = new System.Drawing.Size(162, 23);
            this.comboBox_TenLoaiMA.TabIndex = 28;
            this.comboBox_TenLoaiMA.TabStop = false;
            this.comboBox_TenLoaiMA.Text = "----Chọn loại món ăn----";
            this.comboBox_TenLoaiMA.SelectedIndexChanged += new System.EventHandler(this.comboBox_TenLoaiMA_SelectedIndexChanged);
            // 
            // dateTimePicker_ngayHD
            // 
            this.dateTimePicker_ngayHD.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngayHD.Enabled = false;
            this.dateTimePicker_ngayHD.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePicker_ngayHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngayHD.Location = new System.Drawing.Point(465, 56);
            this.dateTimePicker_ngayHD.Name = "dateTimePicker_ngayHD";
            this.dateTimePicker_ngayHD.Size = new System.Drawing.Size(162, 24);
            this.dateTimePicker_ngayHD.TabIndex = 35;
            this.dateTimePicker_ngayHD.Value = new System.DateTime(2018, 6, 15, 0, 0, 0, 0);
            // 
            // comboBox_MANV
            // 
            this.comboBox_MANV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MANV.FormattingEnabled = true;
            this.comboBox_MANV.Location = new System.Drawing.Point(146, 57);
            this.comboBox_MANV.Name = "comboBox_MANV";
            this.comboBox_MANV.Size = new System.Drawing.Size(162, 23);
            this.comboBox_MANV.TabIndex = 27;
            this.comboBox_MANV.TabStop = false;
            this.comboBox_MANV.Text = "----Chọn mã nhân viên----";
            // 
            // txt_MAHD
            // 
            this.txt_MAHD.Enabled = false;
            this.txt_MAHD.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAHD.Location = new System.Drawing.Point(146, 19);
            this.txt_MAHD.Name = "txt_MAHD";
            this.txt_MAHD.ReadOnly = true;
            this.txt_MAHD.Size = new System.Drawing.Size(162, 23);
            this.txt_MAHD.TabIndex = 5;
            this.txt_MAHD.TabStop = false;
            this.txt_MAHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_nhd
            // 
            this.label_nhd.AutoSize = true;
            this.label_nhd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nhd.Location = new System.Drawing.Point(356, 65);
            this.label_nhd.Name = "label_nhd";
            this.label_nhd.Size = new System.Drawing.Size(86, 15);
            this.label_nhd.TabIndex = 3;
            this.label_nhd.Text = "Ngày hóa đơn:";
            // 
            // label_mba
            // 
            this.label_mba.AutoSize = true;
            this.label_mba.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mba.Location = new System.Drawing.Point(356, 27);
            this.label_mba.Name = "label_mba";
            this.label_mba.Size = new System.Drawing.Size(67, 15);
            this.label_mba.TabIndex = 2;
            this.label_mba.Text = "Mã bàn ăn:";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dongia.Location = new System.Drawing.Point(126, 150);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.ReadOnly = true;
            this.txt_dongia.Size = new System.Drawing.Size(162, 23);
            this.txt_dongia.TabIndex = 8;
            this.txt_dongia.TabStop = false;
            this.txt_dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_mnv
            // 
            this.label_mnv.AutoSize = true;
            this.label_mnv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mnv.Location = new System.Drawing.Point(41, 65);
            this.label_mnv.Name = "label_mnv";
            this.label_mnv.Size = new System.Drawing.Size(84, 15);
            this.label_mnv.TabIndex = 1;
            this.label_mnv.Text = "Mã nhân viên:";
            // 
            // txt_SL
            // 
            this.txt_SL.Enabled = false;
            this.txt_SL.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Location = new System.Drawing.Point(126, 116);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(162, 23);
            this.txt_SL.TabIndex = 7;
            this.txt_SL.TabStop = false;
            this.txt_SL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SL_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // label_mhd
            // 
            this.label_mhd.AutoSize = true;
            this.label_mhd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mhd.Location = new System.Drawing.Point(41, 27);
            this.label_mhd.Name = "label_mhd";
            this.label_mhd.Size = new System.Drawing.Size(75, 15);
            this.label_mhd.TabIndex = 0;
            this.label_mhd.Text = "Mã hóa đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBoxHD);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.groupBox_ttCTHD);
            this.panel1.Location = new System.Drawing.Point(-8, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 606);
            this.panel1.TabIndex = 4;
            // 
            // groupBoxHD
            // 
            this.groupBoxHD.BackColor = System.Drawing.Color.Turquoise;
            this.groupBoxHD.Controls.Add(this.comboBox_MABA);
            this.groupBoxHD.Controls.Add(this.groupBox2);
            this.groupBoxHD.Controls.Add(this.dateTimePicker_ngayHD);
            this.groupBoxHD.Controls.Add(this.comboBox_MANV);
            this.groupBoxHD.Controls.Add(this.btn_ThemHD);
            this.groupBoxHD.Controls.Add(this.txt_MAHD);
            this.groupBoxHD.Controls.Add(this.label_nhd);
            this.groupBoxHD.Controls.Add(this.label_mba);
            this.groupBoxHD.Controls.Add(this.label_mnv);
            this.groupBoxHD.Controls.Add(this.label_mhd);
            this.groupBoxHD.Location = new System.Drawing.Point(6, 51);
            this.groupBoxHD.Name = "groupBoxHD";
            this.groupBoxHD.Size = new System.Drawing.Size(1191, 161);
            this.groupBoxHD.TabIndex = 1;
            this.groupBoxHD.TabStop = false;
            this.groupBoxHD.Text = "Thông tin hóa đơn";
            // 
            // comboBox_MABA
            // 
            this.comboBox_MABA.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MABA.FormattingEnabled = true;
            this.comboBox_MABA.Location = new System.Drawing.Point(465, 19);
            this.comboBox_MABA.Name = "comboBox_MABA";
            this.comboBox_MABA.Size = new System.Drawing.Size(162, 23);
            this.comboBox_MABA.TabIndex = 54;
            this.comboBox_MABA.TabStop = false;
            this.comboBox_MABA.Text = "-------Chọn bàn ăn-------";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_Timkiem);
            this.groupBox2.Controls.Add(this.comboBox_MAHD);
            this.groupBox2.Location = new System.Drawing.Point(794, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 103);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 14);
            this.label10.TabIndex = 50;
            this.label10.Text = "Mã hóa đơn:";
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Timkiem.Appearance.Options.UseFont = true;
            this.btn_Timkiem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Timkiem.Location = new System.Drawing.Point(108, 72);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(117, 22);
            this.btn_Timkiem.TabIndex = 52;
            this.btn_Timkiem.Text = "Tìm kiếm ";
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // comboBox_MAHD
            // 
            this.comboBox_MAHD.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MAHD.FormattingEnabled = true;
            this.comboBox_MAHD.Location = new System.Drawing.Point(153, 25);
            this.comboBox_MAHD.Name = "comboBox_MAHD";
            this.comboBox_MAHD.Size = new System.Drawing.Size(162, 23);
            this.comboBox_MAHD.TabIndex = 51;
            this.comboBox_MAHD.Text = "----Tìm kiếm hóa đơn----";
            // 
            // btn_ThemHD
            // 
            this.btn_ThemHD.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_ThemHD.Appearance.Options.UseFont = true;
            this.btn_ThemHD.Image = global::Fast_Food_Restaurant.Properties.Resources.add;
            this.btn_ThemHD.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_ThemHD.Location = new System.Drawing.Point(653, 42);
            this.btn_ThemHD.Name = "btn_ThemHD";
            this.btn_ThemHD.Size = new System.Drawing.Size(118, 39);
            this.btn_ThemHD.TabIndex = 43;
            this.btn_ThemHD.Text = "Thêm hóa đơn";
            this.btn_ThemHD.Click += new System.EventHandler(this.btn_ThemHD_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(478, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "HÓA ĐƠN BÁN HÀNG";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox_ttCTHD
            // 
            this.groupBox_ttCTHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox_ttCTHD.Controls.Add(this.panel3);
            this.groupBox_ttCTHD.Controls.Add(this.panel2);
            this.groupBox_ttCTHD.Controls.Add(this.groupBox1);
            this.groupBox_ttCTHD.Location = new System.Drawing.Point(3, 211);
            this.groupBox_ttCTHD.Name = "groupBox_ttCTHD";
            this.groupBox_ttCTHD.Size = new System.Drawing.Size(1200, 393);
            this.groupBox_ttCTHD.TabIndex = 4;
            this.groupBox_ttCTHD.TabStop = false;
            this.groupBox_ttCTHD.Text = "Thông tin các mặt hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_NewHD);
            this.panel3.Controls.Add(this.btn_Close);
            this.panel3.Controls.Add(this.btn_printHD);
            this.panel3.Controls.Add(this.btn_destroyHD);
            this.panel3.Location = new System.Drawing.Point(465, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 129);
            this.panel3.TabIndex = 52;
            // 
            // btn_NewHD
            // 
            this.btn_NewHD.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_NewHD.Appearance.Options.UseFont = true;
            this.btn_NewHD.Enabled = false;
            this.btn_NewHD.Image = global::Fast_Food_Restaurant.Properties.Resources.save;
            this.btn_NewHD.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_NewHD.Location = new System.Drawing.Point(14, 50);
            this.btn_NewHD.Name = "btn_NewHD";
            this.btn_NewHD.Size = new System.Drawing.Size(160, 39);
            this.btn_NewHD.TabIndex = 37;
            this.btn_NewHD.Text = "Thêm hóa đơn mới";
            this.btn_NewHD.Click += new System.EventHandler(this.btn_NewHD_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Close.Appearance.Options.UseFont = true;
            this.btn_Close.Image = global::Fast_Food_Restaurant.Properties.Resources.delete;
            this.btn_Close.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(536, 50);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(118, 39);
            this.btn_Close.TabIndex = 51;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_printHD
            // 
            this.btn_printHD.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_printHD.Appearance.Options.UseFont = true;
            this.btn_printHD.Image = global::Fast_Food_Restaurant.Properties.Resources.print;
            this.btn_printHD.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_printHD.Location = new System.Drawing.Point(210, 50);
            this.btn_printHD.Name = "btn_printHD";
            this.btn_printHD.Size = new System.Drawing.Size(118, 39);
            this.btn_printHD.TabIndex = 42;
            this.btn_printHD.Text = "In hóa đơn";
            // 
            // btn_destroyHD
            // 
            this.btn_destroyHD.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_destroyHD.Appearance.Options.UseFont = true;
            this.btn_destroyHD.Image = global::Fast_Food_Restaurant.Properties.Resources.delete;
            this.btn_destroyHD.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_destroyHD.Location = new System.Drawing.Point(370, 50);
            this.btn_destroyHD.Name = "btn_destroyHD";
            this.btn_destroyHD.Size = new System.Drawing.Size(118, 39);
            this.btn_destroyHD.TabIndex = 38;
            this.btn_destroyHD.Text = "Xóa hóa đơn";
            this.btn_destroyHD.Click += new System.EventHandler(this.btn_destroyHD_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox_TenLoaiMA);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_MaCTHD);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.groupBox_CTPBan);
            this.panel2.Controls.Add(this.btn_xoamonan);
            this.panel2.Controls.Add(this.btn_capnhatmonan);
            this.panel2.Controls.Add(this.comboBox_TenMA);
            this.panel2.Controls.Add(this.txt_dongia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_SL);
            this.panel2.Location = new System.Drawing.Point(20, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 241);
            this.panel2.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loại món ăn:";
            // 
            // txt_MaCTHD
            // 
            this.txt_MaCTHD.Enabled = false;
            this.txt_MaCTHD.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaCTHD.Location = new System.Drawing.Point(126, 5);
            this.txt_MaCTHD.Name = "txt_MaCTHD";
            this.txt_MaCTHD.ReadOnly = true;
            this.txt_MaCTHD.Size = new System.Drawing.Size(162, 23);
            this.txt_MaCTHD.TabIndex = 5;
            this.txt_MaCTHD.TabStop = false;
            this.txt_MaCTHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_xoamonan
            // 
            this.btn_xoamonan.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_xoamonan.Appearance.Options.UseFont = true;
            this.btn_xoamonan.Image = global::Fast_Food_Restaurant.Properties.Resources.delete;
            this.btn_xoamonan.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_xoamonan.Location = new System.Drawing.Point(193, 186);
            this.btn_xoamonan.Name = "btn_xoamonan";
            this.btn_xoamonan.Size = new System.Drawing.Size(106, 47);
            this.btn_xoamonan.TabIndex = 38;
            this.btn_xoamonan.Text = "Xóa món ăn";
            this.btn_xoamonan.Click += new System.EventHandler(this.btn_xoamonan_Click);
            // 
            // btn_capnhatmonan
            // 
            this.btn_capnhatmonan.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_capnhatmonan.Appearance.Options.UseFont = true;
            this.btn_capnhatmonan.Image = global::Fast_Food_Restaurant.Properties.Resources.Sua;
            this.btn_capnhatmonan.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_capnhatmonan.Location = new System.Drawing.Point(24, 186);
            this.btn_capnhatmonan.Name = "btn_capnhatmonan";
            this.btn_capnhatmonan.Size = new System.Drawing.Size(116, 47);
            this.btn_capnhatmonan.TabIndex = 41;
            this.btn_capnhatmonan.Text = "Cập nhật món ăn";
            this.btn_capnhatmonan.Click += new System.EventHandler(this.btn_capnhatmonan_Click);
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1192, 585);
            this.Controls.Add(this.panel1);
            this.Name = "fHoaDon";
            this.Text = "formHoadon";
            this.Load += new System.EventHandler(this.fHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_CTPBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CTHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxHD.ResumeLayout(false);
            this.groupBoxHD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_ttCTHD.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_TinhTien;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TienThua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TienNhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox_CTPBan;
        private System.Windows.Forms.DataGridView dataGridView_CTHD;
        private DevExpress.XtraEditors.SimpleButton btn_destroyHD;
        private DevExpress.XtraEditors.SimpleButton btn_NewHD;
        private DevExpress.XtraEditors.SimpleButton btn_printHD;
        private DevExpress.XtraEditors.SimpleButton btn_capnhatmonan;
        private DevExpress.XtraEditors.SimpleButton btn_xoamonan;
        private System.Windows.Forms.ComboBox comboBox_TenMA;
        private DevExpress.XtraEditors.SimpleButton btn_ThemHD;
        private System.Windows.Forms.ComboBox comboBox_TenLoaiMA;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayHD;
        private System.Windows.Forms.ComboBox comboBox_MANV;
        private System.Windows.Forms.TextBox txt_MAHD;
        private System.Windows.Forms.Label label_nhd;
        private System.Windows.Forms.Label label_mba;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label_mnv;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_mhd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_ttCTHD;
        private System.Windows.Forms.TextBox txt_MaCTHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxHD;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btn_Timkiem;
        private System.Windows.Forms.ComboBox comboBox_MAHD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_MABA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}