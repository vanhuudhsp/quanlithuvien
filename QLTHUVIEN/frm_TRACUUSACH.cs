using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTHUVIEN.LOP;
using System.Collections;
namespace QLTHUVIEN
{
    public partial class frm_TRACUUSACH : Form
    {
        public frm_TRACUUSACH()
        {
            InitializeComponent();
        }
        XL_SACH Bang_SACH;
        XL_NHAXUATBAN Bang_NHAXUATBAN;
        XL_THELOAI Bang_THELOAI;
        private void frm_TRACUUSACH_Load(object sender, EventArgs e)
        {
            Bang_SACH = new XL_SACH();
            Bang_THELOAI = new XL_THELOAI();
            Bang_NHAXUATBAN = new XL_NHAXUATBAN();
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { Bang_SACH, Bang_NHAXUATBAN, Bang_THELOAI });
            DataRelation qh_NHAXUATBAN_SACH = 
                         new DataRelation("FK_NHAXUATBAN_SACH", Bang_NHAXUATBAN.Columns["MaNXB"], Bang_SACH.Columns["MaNXB"]);
            DataRelation qh_THELOAI_SACH = 
                         new DataRelation("FK_THELOAI_SACH", Bang_THELOAI.Columns["MaTL"], Bang_SACH.Columns["MaTL"]);
            ds.Relations.AddRange(new DataRelation[] { qh_NHAXUATBAN_SACH, qh_THELOAI_SACH });
            DataColumn cot_TenNXB = new DataColumn("TenNXB", Type.GetType("System.String"), "Parent(FK_NHAXUATBAN_SACH).TenNXB");
            DataColumn cot_TenTL = new DataColumn("TenTL", Type.GetType("System.String"), "Parent(FK_THELOAI_SACH).TenTL");
            Bang_SACH.Columns.AddRange(new DataColumn[] { cot_TenNXB, cot_TenTL });
            cbNXB.DataSource = Bang_NHAXUATBAN;
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "MaNXB";
            cbMaTL.DataSource = Bang_THELOAI;
            cbMaTL.DisplayMember = "TenTL";
            cbMaTL.ValueMember = "MaTL";
            dgvSACH.DataSource = Bang_SACH;
            Nhap_moi();
        }
        private void Nhap_moi()
        {
            txtMaSach.Text = "";
            txtTuaDe.Text = "";
            txtTacGia.Text = "";
            txtSoLuong.Text = "";
            cbMaTL.SelectedIndex = -1;
            cbNXB.SelectedIndex = -1;

        }
        private void btNhapMoi_Click(object sender, EventArgs e)
        {
            Nhap_moi();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string chuoi_DK = "";
            ArrayList mang_DK = new ArrayList();
            if (txtMaSach.Text != "")
                mang_DK.Add("MaSach LIKE '*" + txtMaSach.Text + "*'"); 
            if (txtTuaDe.Text != "")
                mang_DK.Add("TuaDe LIKE '*" + txtTuaDe.Text + "*'");
            if (txtTacGia.Text != "")
                mang_DK.Add("TacGia LIKE '*" + txtTacGia.Text + "*'");
            if (txtSoLuong.Text != "")
                mang_DK.Add("SoLuong = " + txtSoLuong.Text);
            if (cbNXB.SelectedIndex  != -1)
                mang_DK.Add("MaNXB LIKE '*" + cbNXB.SelectedValue + "*'");
            if (cbMaTL.SelectedIndex != -1)
                mang_DK.Add("MaTL LIKE '*" + cbMaTL.SelectedValue + "*'");
            if (mang_DK.Count > 0)
            {
                for (int i = 0; i < mang_DK.Count; i++)
                    if (i == 0) chuoi_DK = mang_DK[i].ToString();
                    else chuoi_DK += " AND " + mang_DK[i];
            }
            Bang_SACH.Loc_du_lieu(chuoi_DK); 
        }
    }
}
