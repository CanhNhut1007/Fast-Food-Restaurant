namespace Fast_Food_Restaurant
{
    partial class fKetNoiServer
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
            this.combobox_TenServer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txt_database = new System.Windows.Forms.TextBox();
            this.btn_connect_sql = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết Nối Server";
            // 
            // combobox_TenServer
            // 
            this.combobox_TenServer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_TenServer.FormattingEnabled = true;
            this.combobox_TenServer.Location = new System.Drawing.Point(309, 97);
            this.combobox_TenServer.Name = "combobox_TenServer";
            this.combobox_TenServer.Size = new System.Drawing.Size(168, 24);
            this.combobox_TenServer.TabIndex = 1;
            this.combobox_TenServer.Text = "----Chọn Tên Server----";
            this.combobox_TenServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_TenServer_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Server : ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(199, 155);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(110, 16);
            this.label.TabIndex = 3;
            this.label.Text = "Tên Database : ";
            // 
            // txt_database
            // 
            this.txt_database.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_database.Location = new System.Drawing.Point(309, 149);
            this.txt_database.Name = "txt_database";
            this.txt_database.Size = new System.Drawing.Size(168, 23);
            this.txt_database.TabIndex = 4;
            // 
            // btn_connect_sql
            // 
            this.btn_connect_sql.Image = global::Fast_Food_Restaurant.Properties.Resources.connect_icon;
            this.btn_connect_sql.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_connect_sql.Location = new System.Drawing.Point(191, 212);
            this.btn_connect_sql.Name = "btn_connect_sql";
            this.btn_connect_sql.Size = new System.Drawing.Size(116, 57);
            this.btn_connect_sql.TabIndex = 5;
            this.btn_connect_sql.Text = "Kết nối đến SQL";
            this.btn_connect_sql.Click += new System.EventHandler(this.btn_connect_sql_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = global::Fast_Food_Restaurant.Properties.Resources.delete_2_icon;
            this.btn_Exit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Exit.Location = new System.Drawing.Point(370, 212);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(116, 57);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // fKetNoiServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(723, 417);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_connect_sql);
            this.Controls.Add(this.txt_database);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combobox_TenServer);
            this.Controls.Add(this.label1);
            this.Name = "fKetNoiServer";
            this.Text = "fKetNoiServer";
            this.Load += new System.EventHandler(this.fKetNoiServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_TenServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt_database;
        private DevExpress.XtraEditors.SimpleButton btn_connect_sql;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
    }
}