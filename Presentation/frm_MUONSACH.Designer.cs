namespace QLTHUVIEN
{
    partial class frm_MUONSACH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMUONSACH = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cbMaThe = new System.Windows.Forms.ComboBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenBanDoc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTuaDe = new System.Windows.Forms.TextBox();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btKhongGhi = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btTraSach = new System.Windows.Forms.Button();
            this.btMuonSach = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMUONSACH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(346, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "XỬ LÝ MƯỢN TRẢ SÁCH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMUONSACH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(22, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 265);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách đang mượn";
            // 
            // dgvMUONSACH
            // 
            this.dgvMUONSACH.AllowUserToAddRows = false;
            this.dgvMUONSACH.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMUONSACH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvMUONSACH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMUONSACH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaThe,
            this.MaSach,
            this.TuDe,
            this.TacGia,
            this.NgayMuon,
            this.NgayTra});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMUONSACH.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvMUONSACH.Location = new System.Drawing.Point(16, 22);
            this.dgvMUONSACH.Name = "dgvMUONSACH";
            this.dgvMUONSACH.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMUONSACH.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvMUONSACH.Size = new System.Drawing.Size(742, 231);
            this.dgvMUONSACH.TabIndex = 0;
            this.dgvMUONSACH.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMUONSACH_DataBindingComplete);
            this.dgvMUONSACH.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvMUONSACH_DefaultValuesNeeded);
            this.dgvMUONSACH.SelectionChanged += new System.EventHandler(this.dgvMUONSACH_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MaThe
            // 
            this.MaThe.DataPropertyName = "MaThe";
            this.MaThe.HeaderText = "Mã Thẻ";
            this.MaThe.Name = "MaThe";
            this.MaThe.ReadOnly = true;
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
            this.TuDe.ReadOnly = true;
            this.TuDe.Width = 200;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            this.TacGia.Width = 150;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.cbMaThe);
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenBanDoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(22, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 98);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đọc giả";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(320, 57);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(278, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // cbMaThe
            // 
            this.cbMaThe.FormattingEnabled = true;
            this.cbMaThe.Location = new System.Drawing.Point(94, 21);
            this.cbMaThe.Name = "cbMaThe";
            this.cbMaThe.Size = new System.Drawing.Size(109, 21);
            this.cbMaThe.TabIndex = 4;
            this.cbMaThe.SelectedIndexChanged += new System.EventHandler(this.cbMaThe_SelectedIndexChanged);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(94, 57);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(109, 20);
            this.txtSoDT.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đọc giả : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã thẻ :";
            // 
            // txtTenBanDoc
            // 
            this.txtTenBanDoc.Location = new System.Drawing.Point(320, 21);
            this.txtTenBanDoc.Name = "txtTenBanDoc";
            this.txtTenBanDoc.Size = new System.Drawing.Size(278, 20);
            this.txtTenBanDoc.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dNgayTra);
            this.groupBox3.Controls.Add(this.dNgayMuon);
            this.groupBox3.Controls.Add(this.txtTacGia);
            this.groupBox3.Controls.Add(this.txtTuaDe);
            this.groupBox3.Controls.Add(this.cbMaSach);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(22, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 85);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết mượn trả sách";
            // 
            // dNgayTra
            // 
            this.dNgayTra.Enabled = false;
            this.dNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgayTra.Location = new System.Drawing.Point(497, 54);
            this.dNgayTra.Name = "dNgayTra";
            this.dNgayTra.Size = new System.Drawing.Size(101, 20);
            this.dNgayTra.TabIndex = 7;
            // 
            // dNgayMuon
            // 
            this.dNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgayMuon.Location = new System.Drawing.Point(320, 54);
            this.dNgayMuon.Name = "dNgayMuon";
            this.dNgayMuon.Size = new System.Drawing.Size(100, 20);
            this.dNgayMuon.TabIndex = 6;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(94, 53);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(109, 20);
            this.txtTacGia.TabIndex = 5;
            // 
            // txtTuaDe
            // 
            this.txtTuaDe.Location = new System.Drawing.Point(320, 23);
            this.txtTuaDe.Name = "txtTuaDe";
            this.txtTuaDe.Size = new System.Drawing.Size(278, 20);
            this.txtTuaDe.TabIndex = 4;
            // 
            // cbMaSach
            // 
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(94, 23);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(109, 21);
            this.cbMaSach.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(434, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ngày trả : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày mượn: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên sách : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tác giả : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã sách : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btKhongGhi);
            this.groupBox4.Controls.Add(this.btGhi);
            this.groupBox4.Controls.Add(this.btSua);
            this.groupBox4.Controls.Add(this.btTraSach);
            this.groupBox4.Controls.Add(this.btMuonSach);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new System.Drawing.Point(654, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 189);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thao tác";
            // 
            // btKhongGhi
            // 
            this.btKhongGhi.Location = new System.Drawing.Point(21, 141);
            this.btKhongGhi.Name = "btKhongGhi";
            this.btKhongGhi.Size = new System.Drawing.Size(92, 23);
            this.btKhongGhi.TabIndex = 4;
            this.btKhongGhi.Text = "Không Ghi";
            this.btKhongGhi.UseVisualStyleBackColor = true;
            this.btKhongGhi.Click += new System.EventHandler(this.btKhongGhi_Click);
            // 
            // btGhi
            // 
            this.btGhi.Location = new System.Drawing.Point(21, 112);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(92, 23);
            this.btGhi.TabIndex = 3;
            this.btGhi.Text = "Ghi";
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(21, 83);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(92, 23);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btTraSach
            // 
            this.btTraSach.Location = new System.Drawing.Point(21, 54);
            this.btTraSach.Name = "btTraSach";
            this.btTraSach.Size = new System.Drawing.Size(92, 23);
            this.btTraSach.TabIndex = 1;
            this.btTraSach.Text = "Trả Sách";
            this.btTraSach.UseVisualStyleBackColor = true;
            this.btTraSach.Click += new System.EventHandler(this.btTraSach_Click);
            // 
            // btMuonSach
            // 
            this.btMuonSach.Location = new System.Drawing.Point(21, 24);
            this.btMuonSach.Name = "btMuonSach";
            this.btMuonSach.Size = new System.Drawing.Size(92, 23);
            this.btMuonSach.TabIndex = 0;
            this.btMuonSach.Text = "Mượn Sách";
            this.btMuonSach.UseVisualStyleBackColor = true;
            this.btMuonSach.Click += new System.EventHandler(this.btMuonSach_Click);
            // 
            // frm_MUONSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 534);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_MUONSACH";
            this.Text = "Mượn Trả Sách";
            this.Load += new System.EventHandler(this.frm_MUONSACH_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMUONSACH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMUONSACH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cbMaThe;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenBanDoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dNgayTra;
        private System.Windows.Forms.DateTimePicker dNgayMuon;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTuaDe;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btMuonSach;
        private System.Windows.Forms.Button btKhongGhi;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTraSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
    }
}