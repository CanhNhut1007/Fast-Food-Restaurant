namespace Fast_Food_Restaurant
{
    partial class fThongTinThucPham
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CN = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_npp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txtmatp = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Button_Thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_timkiem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(6, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(601, 449);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(575, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 471);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách thực phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(454, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "THÔNG TIN THỰC PHẨM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 534);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(7, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 471);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thực phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_CN);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.cbb_npp);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtdvt);
            this.panel2.Controls.Add(this.txtmatp);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtmoney);
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 295);
            this.panel2.TabIndex = 25;
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.Image = global::Fast_Food_Restaurant.Properties.Resources.add;
            this.btn_them.Location = new System.Drawing.Point(39, 222);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(82, 36);
            this.btn_them.TabIndex = 55;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // btn_CN
            // 
            this.btn_CN.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_CN.Appearance.Options.UseFont = true;
            this.btn_CN.Image = global::Fast_Food_Restaurant.Properties.Resources.Sua;
            this.btn_CN.Location = new System.Drawing.Point(211, 222);
            this.btn_CN.Name = "btn_CN";
            this.btn_CN.Size = new System.Drawing.Size(97, 36);
            this.btn_CN.TabIndex = 54;
            this.btn_CN.Text = "Cập nhật";
            this.btn_CN.Click += new System.EventHandler(this.btn_CN_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_sua.Appearance.Options.UseFont = true;
            this.btn_sua.Image = global::Fast_Food_Restaurant.Properties.Resources.restore;
            this.btn_sua.Location = new System.Drawing.Point(388, 222);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(96, 36);
            this.btn_sua.TabIndex = 53;
            this.btn_sua.Text = "Làm mới";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // cbb_npp
            // 
            this.cbb_npp.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbb_npp.FormattingEnabled = true;
            this.cbb_npp.Location = new System.Drawing.Point(194, 149);
            this.cbb_npp.Name = "cbb_npp";
            this.cbb_npp.Size = new System.Drawing.Size(169, 27);
            this.cbb_npp.TabIndex = 49;
            this.cbb_npp.Text = "--Chọn nhà phân phối--";
            this.cbb_npp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbb_npp_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label8.Location = new System.Drawing.Point(50, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 48;
            this.label8.Text = "Nhà phân phối";
            // 
            // txtdvt
            // 
            this.txtdvt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtdvt.Location = new System.Drawing.Point(194, 80);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(169, 26);
            this.txtdvt.TabIndex = 47;
            // 
            // txtmatp
            // 
            this.txtmatp.Enabled = false;
            this.txtmatp.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtmatp.Location = new System.Drawing.Point(194, 5);
            this.txtmatp.Name = "txtmatp";
            this.txtmatp.Size = new System.Drawing.Size(169, 26);
            this.txtmatp.TabIndex = 42;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtname.Location = new System.Drawing.Point(195, 41);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(168, 26);
            this.txtname.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(52, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 46;
            this.label7.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(52, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mã thực phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(50, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tên thực phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(50, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Giá tiền";
            // 
            // txtmoney
            // 
            this.txtmoney.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtmoney.Location = new System.Drawing.Point(194, 115);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(169, 26);
            this.txtmoney.TabIndex = 43;
            this.txtmoney.TextChanged += new System.EventHandler(this.txtmoney_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.Button_Thoat);
            this.panel3.Controls.Add(this.btn_timkiem);
            this.panel3.Controls.Add(this.cbb_timkiem);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(0, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 149);
            this.panel3.TabIndex = 24;
            // 
            // Button_Thoat
            // 
            this.Button_Thoat.BackColor = System.Drawing.Color.SkyBlue;
            this.Button_Thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Thoat.Image = global::Fast_Food_Restaurant.Properties.Resources.exit_icon;
            this.Button_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Thoat.Location = new System.Drawing.Point(231, 96);
            this.Button_Thoat.Name = "Button_Thoat";
            this.Button_Thoat.Size = new System.Drawing.Size(104, 53);
            this.Button_Thoat.TabIndex = 26;
            this.Button_Thoat.Text = "Thoát";
            this.Button_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Thoat.UseVisualStyleBackColor = false;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_timkiem.Appearance.Options.UseFont = true;
            this.btn_timkiem.Image = global::Fast_Food_Restaurant.Properties.Resources.TimKiem;
            this.btn_timkiem.Location = new System.Drawing.Point(383, 29);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(112, 36);
            this.btn_timkiem.TabIndex = 62;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // cbb_timkiem
            // 
            this.cbb_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbb_timkiem.FormattingEnabled = true;
            this.cbb_timkiem.Location = new System.Drawing.Point(176, 38);
            this.cbb_timkiem.Name = "cbb_timkiem";
            this.cbb_timkiem.Size = new System.Drawing.Size(187, 27);
            this.cbb_timkiem.TabIndex = 26;
            this.cbb_timkiem.Text = "---Tìm tên thực phẩm---";
            this.cbb_timkiem.SelectedIndexChanged += new System.EventHandler(this.cbb_timkiem_SelectedIndexChanged);
            this.cbb_timkiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbb_timkiem_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(47, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên thực phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(202, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tìm kiếm thực phẩm";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã thực phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Thực phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn vị";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Nhà phân phối";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // fThongTinThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 577);
            this.Controls.Add(this.panel1);
            this.Name = "fThongTinThucPham";
            this.Text = "fThongTinThucPham";
            this.Load += new System.EventHandler(this.fThongTinThucPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Thoat;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.SimpleButton btn_CN;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private System.Windows.Forms.ComboBox cbb_npp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txtmatp;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbb_timkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}