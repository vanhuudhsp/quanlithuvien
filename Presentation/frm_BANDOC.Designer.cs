namespace QLTHUVIEN
{
    partial class frm_BANDOC
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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenBanDoc = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_BANDOC = new System.Windows.Forms.DataGridView();
            this.MaThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBanDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_previous = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_Ve_cuoi = new System.Windows.Forms.Button();
            this.bt_Ve_dau = new System.Windows.Forms.Button();
            this.bt_Ghi = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Khong_Ghi = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BANDOC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenBanDoc);
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(this.txtMaThe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bạn đọc";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(329, 52);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(236, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTenBanDoc
            // 
            this.txtTenBanDoc.Location = new System.Drawing.Point(329, 21);
            this.txtTenBanDoc.Name = "txtTenBanDoc";
            this.txtTenBanDoc.Size = new System.Drawing.Size(236, 20);
            this.txtTenBanDoc.TabIndex = 6;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(112, 52);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(105, 20);
            this.txtSoDT.TabIndex = 5;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Enabled = false;
            this.txtMaThe.Location = new System.Drawing.Point(112, 21);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(105, 20);
            this.txtMaThe.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điện Thoại : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Bạn Đọc : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Thẻ : ";
            // 
            // dgv_BANDOC
            // 
            this.dgv_BANDOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BANDOC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThe,
            this.TenBanDoc,
            this.DiaChi,
            this.SoDT});
            this.dgv_BANDOC.Location = new System.Drawing.Point(27, 209);
            this.dgv_BANDOC.Name = "dgv_BANDOC";
            this.dgv_BANDOC.Size = new System.Drawing.Size(669, 234);
            this.dgv_BANDOC.TabIndex = 1;
            // 
            // MaThe
            // 
            this.MaThe.DataPropertyName = "MaThe";
            this.MaThe.HeaderText = "Mã Thẻ";
            this.MaThe.Name = "MaThe";
            this.MaThe.ReadOnly = true;
            // 
            // TenBanDoc
            // 
            this.TenBanDoc.DataPropertyName = "TenBanDoc";
            this.TenBanDoc.HeaderText = "Tên Bạn Đọc";
            this.TenBanDoc.Name = "TenBanDoc";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Điện Thoại";
            this.SoDT.Name = "SoDT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_next);
            this.groupBox2.Controls.Add(this.bt_previous);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_Ve_cuoi);
            this.groupBox2.Controls.Add(this.bt_Ve_dau);
            this.groupBox2.Controls.Add(this.bt_Ghi);
            this.groupBox2.Controls.Add(this.bt_Xoa);
            this.groupBox2.Controls.Add(this.bt_Khong_Ghi);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Location = new System.Drawing.Point(28, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(108, 19);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(45, 23);
            this.bt_next.TabIndex = 9;
            this.bt_next.Text = ">";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // bt_previous
            // 
            this.bt_previous.Location = new System.Drawing.Point(61, 19);
            this.bt_previous.Name = "bt_previous";
            this.bt_previous.Size = new System.Drawing.Size(44, 23);
            this.bt_previous.TabIndex = 8;
            this.bt_previous.Text = "<";
            this.bt_previous.UseVisualStyleBackColor = true;
            this.bt_previous.Click += new System.EventHandler(this.bt_previous_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(423, 19);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 7;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_Ve_cuoi
            // 
            this.bt_Ve_cuoi.Location = new System.Drawing.Point(159, 19);
            this.bt_Ve_cuoi.Name = "bt_Ve_cuoi";
            this.bt_Ve_cuoi.Size = new System.Drawing.Size(54, 23);
            this.bt_Ve_cuoi.TabIndex = 6;
            this.bt_Ve_cuoi.Text = ">>";
            this.bt_Ve_cuoi.UseVisualStyleBackColor = true;
            this.bt_Ve_cuoi.Click += new System.EventHandler(this.bt_Ve_cuoi_Click);
            // 
            // bt_Ve_dau
            // 
            this.bt_Ve_dau.Location = new System.Drawing.Point(6, 19);
            this.bt_Ve_dau.Name = "bt_Ve_dau";
            this.bt_Ve_dau.Size = new System.Drawing.Size(49, 23);
            this.bt_Ve_dau.TabIndex = 5;
            this.bt_Ve_dau.Text = "<<";
            this.bt_Ve_dau.UseVisualStyleBackColor = true;
            this.bt_Ve_dau.Click += new System.EventHandler(this.bt_Ve_dau_Click);
            // 
            // bt_Ghi
            // 
            this.bt_Ghi.Location = new System.Drawing.Point(504, 19);
            this.bt_Ghi.Name = "bt_Ghi";
            this.bt_Ghi.Size = new System.Drawing.Size(75, 23);
            this.bt_Ghi.TabIndex = 3;
            this.bt_Ghi.Text = "Ghi";
            this.bt_Ghi.UseVisualStyleBackColor = true;
            this.bt_Ghi.Click += new System.EventHandler(this.bt_Ghi_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(342, 19);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_Xoa.TabIndex = 2;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Khong_Ghi
            // 
            this.bt_Khong_Ghi.Location = new System.Drawing.Point(585, 19);
            this.bt_Khong_Ghi.Name = "bt_Khong_Ghi";
            this.bt_Khong_Ghi.Size = new System.Drawing.Size(75, 23);
            this.bt_Khong_Ghi.TabIndex = 1;
            this.bt_Khong_Ghi.Text = "Không Ghi";
            this.bt_Khong_Ghi.UseVisualStyleBackColor = true;
            this.bt_Khong_Ghi.Click += new System.EventHandler(this.bt_Khong_Ghi_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(261, 19);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH BẠN ĐỌC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(31, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Danh sách bạn đọc";
            // 
            // frm_BANDOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 512);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_BANDOC);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_BANDOC";
            this.Text = "BAN ĐỌC";
            this.Load += new System.EventHandler(this.frm_BANDOC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BANDOC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_BANDOC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_Ghi;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Khong_Ghi;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenBanDoc;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Ve_cuoi;
        private System.Windows.Forms.Button bt_Ve_dau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_previous;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBanDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
    }
}