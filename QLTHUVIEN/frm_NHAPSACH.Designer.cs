namespace QLTHUVIEN
{
    partial class frm_NHAPSACH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btKhong_ghi = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btSua_sach = new System.Windows.Forms.Button();
            this.btHuy_sach = new System.Windows.Forms.Button();
            this.btNhap_sach = new System.Windows.Forms.Button();
            this.dNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbMaTL = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTuaDe = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSACH = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSACH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btKhong_ghi);
            this.groupBox1.Controls.Add(this.btGhi);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dNgayNhap);
            this.groupBox1.Controls.Add(this.cbMaTL);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.cbNXB);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTuaDe);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(25, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btKhong_ghi
            // 
            this.btKhong_ghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhong_ghi.Location = new System.Drawing.Point(726, 93);
            this.btKhong_ghi.Name = "btKhong_ghi";
            this.btKhong_ghi.Size = new System.Drawing.Size(75, 23);
            this.btKhong_ghi.TabIndex = 10;
            this.btKhong_ghi.Text = "Không ghi";
            this.btKhong_ghi.UseVisualStyleBackColor = true;
            this.btKhong_ghi.Click += new System.EventHandler(this.btKhong_ghi_Click);
            // 
            // btGhi
            // 
            this.btGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhi.Location = new System.Drawing.Point(726, 55);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(75, 23);
            this.btGhi.TabIndex = 9;
            this.btGhi.Text = "Ghi";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btSua_sach);
            this.groupBox3.Controls.Add(this.btHuy_sach);
            this.groupBox3.Controls.Add(this.btNhap_sach);
            this.groupBox3.Location = new System.Drawing.Point(598, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(101, 129);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // btSua_sach
            // 
            this.btSua_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua_sach.Location = new System.Drawing.Point(6, 92);
            this.btSua_sach.Name = "btSua_sach";
            this.btSua_sach.Size = new System.Drawing.Size(88, 23);
            this.btSua_sach.TabIndex = 2;
            this.btSua_sach.Text = "Sửa sách";
            this.btSua_sach.UseVisualStyleBackColor = true;
            this.btSua_sach.Click += new System.EventHandler(this.btSua_sach_Click);
            // 
            // btHuy_sach
            // 
            this.btHuy_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy_sach.Location = new System.Drawing.Point(6, 55);
            this.btHuy_sach.Name = "btHuy_sach";
            this.btHuy_sach.Size = new System.Drawing.Size(88, 23);
            this.btHuy_sach.TabIndex = 1;
            this.btHuy_sach.Text = "Hủy sách";
            this.btHuy_sach.UseVisualStyleBackColor = true;
            this.btHuy_sach.Click += new System.EventHandler(this.btHuy_sach_Click);
            // 
            // btNhap_sach
            // 
            this.btNhap_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhap_sach.Location = new System.Drawing.Point(6, 20);
            this.btNhap_sach.Name = "btNhap_sach";
            this.btNhap_sach.Size = new System.Drawing.Size(88, 23);
            this.btNhap_sach.TabIndex = 0;
            this.btNhap_sach.Text = "Nhập sách";
            this.btNhap_sach.UseVisualStyleBackColor = true;
            this.btNhap_sach.Click += new System.EventHandler(this.btNhap_sach_Click);
            // 
            // dNgayNhap
            // 
            this.dNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgayNhap.Location = new System.Drawing.Point(435, 111);
            this.dNgayNhap.Name = "dNgayNhap";
            this.dNgayNhap.Size = new System.Drawing.Size(110, 20);
            this.dNgayNhap.TabIndex = 7;
            // 
            // cbMaTL
            // 
            this.cbMaTL.FormattingEnabled = true;
            this.cbMaTL.Location = new System.Drawing.Point(253, 110);
            this.cbMaTL.Name = "cbMaTL";
            this.cbMaTL.Size = new System.Drawing.Size(93, 21);
            this.cbMaTL.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(82, 111);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(88, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // cbNXB
            // 
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(336, 74);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(209, 21);
            this.cbNXB.TabIndex = 4;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(82, 74);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(155, 20);
            this.txtTacGia.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhà xuất bản : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày Nhập : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thể loại : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tác giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sách :";
            // 
            // txtTuaDe
            // 
            this.txtTuaDe.Location = new System.Drawing.Point(253, 39);
            this.txtTuaDe.Name = "txtTuaDe";
            this.txtTuaDe.Size = new System.Drawing.Size(292, 20);
            this.txtTuaDe.TabIndex = 1;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(82, 39);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(88, 20);
            this.txtMaSach.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSACH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(27, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 291);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết nhập sách";
            // 
            // dgvSACH
            // 
            this.dgvSACH.AllowUserToAddRows = false;
            this.dgvSACH.AllowUserToDeleteRows = false;
            this.dgvSACH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSACH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSach,
            this.TuDe,
            this.MaNXB,
            this.TacGia,
            this.SoLuong,
            this.NgayNhap,
            this.MaTL});
            this.dgvSACH.Location = new System.Drawing.Point(9, 18);
            this.dgvSACH.Name = "dgvSACH";
            this.dgvSACH.ReadOnly = true;
            this.dgvSACH.Size = new System.Drawing.Size(897, 258);
            this.dgvSACH.TabIndex = 0;
            this.dgvSACH.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSACH_DataBindingComplete);
            this.dgvSACH.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvSACH_DefaultValuesNeeded);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TuDe
            // 
            this.TuDe.DataPropertyName = "TuaDe";
            this.TuDe.HeaderText = "Tên Sách";
            this.TuDe.Name = "TuDe";
            this.TuDe.Width = 200;
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaNXB.DefaultCellStyle = dataGridViewCellStyle13;
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.ReadOnly = true;
            this.MaNXB.Width = 75;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle14;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NgayNhap.DefaultCellStyle = dataGridViewCellStyle15;
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // MaTL
            // 
            this.MaTL.DataPropertyName = "MaTL";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaTL.DefaultCellStyle = dataGridViewCellStyle16;
            this.MaTL.HeaderText = "Mã Thể Loại";
            this.MaTL.Name = "MaTL";
            this.MaTL.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "NHẬP SÁCH";
            // 
            // frm_NHAPSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 519);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_NHAPSACH";
            this.Text = "Nhập sách";
            this.Load += new System.EventHandler(this.frm_NHAP_SACH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSACH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuaDe;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btSua_sach;
        private System.Windows.Forms.Button btHuy_sach;
        private System.Windows.Forms.Button btNhap_sach;
        private System.Windows.Forms.DateTimePicker dNgayNhap;
        private System.Windows.Forms.ComboBox cbMaTL;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btKhong_ghi;
        private System.Windows.Forms.DataGridView dgvSACH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
    }
}