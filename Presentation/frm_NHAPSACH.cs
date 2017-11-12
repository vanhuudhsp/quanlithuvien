using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;
using System.Data.SqlClient;
namespace QLTHUVIEN
{
    public partial class frm_NHAPSACH : Form
    {
        public frm_NHAPSACH()
        {
            InitializeComponent();
        }
        XL_SACH Bang_SACH;
        XL_NHAXUATBAN Bang_NHAXUATBAN;
        XL_THELOAI Bang_THELOAI;
        BindingManagerBase DS_SACH;
        private void frm_NHAP_SACH_Load(object sender, EventArgs e)
        {
            Bang_SACH = new XL_SACH();
            Bang_THELOAI = new XL_THELOAI();
            Bang_NHAXUATBAN = new XL_NHAXUATBAN();
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { Bang_SACH, Bang_NHAXUATBAN, Bang_THELOAI });
            DataRelation qh_NHAXUATBAN_SACH = new DataRelation("FK_NHAXUATBAN_SACH", Bang_NHAXUATBAN.Columns["MaNXB"], Bang_SACH.Columns["MaNXB"]);
            DataRelation qh_THELOAI_SACH = new DataRelation("FK_THELOAI_SACH", Bang_THELOAI.Columns["MaTL"], Bang_SACH.Columns["MaTL"]);
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
           
            txtMaSach.DataBindings.Add("text", Bang_SACH, "MaSach");
            txtTuaDe.DataBindings.Add("text", Bang_SACH, "TuaDe");
            txtTacGia.DataBindings.Add("text", Bang_SACH, "TacGia");
            txtSoLuong.DataBindings.Add("text", Bang_SACH, "SoLuong");
            dNgayNhap.DataBindings.Add("text", Bang_SACH, "NgayNhap");
            cbNXB.DataBindings.Add("SelectedValue", Bang_SACH, "MaNXB");
            cbMaTL.DataBindings.Add("SelectedValue", Bang_SACH, "MaTL");
         
           
            DS_SACH = this.BindingContext[Bang_SACH];
            An_hien_nut_lenh(false);
        }
        private void An_hien_nut_lenh(bool capnhat)
        {
            btNhap_sach.Enabled = !capnhat;
            btHuy_sach.Enabled = !capnhat;
            btSua_sach.Enabled = !capnhat;
            btGhi.Enabled = capnhat;
            btKhong_ghi.Enabled = capnhat;
        }

        private void btNhap_sach_Click(object sender, EventArgs e)
        {

            An_hien_nut_lenh(true);
            DS_SACH.AddNew();
        }
       
        private void btKhong_ghi_Click(object sender, EventArgs e)
        {
            DS_SACH.CancelCurrentEdit();
            Bang_SACH.RejectChanges();
            An_hien_nut_lenh(false);
            
        }

        private void btSua_sach_Click(object sender, EventArgs e)
        {
            An_hien_nut_lenh(true);
        }

        private void btHuy_sach_Click(object sender, EventArgs e)
        {
            DS_SACH.RemoveAt(DS_SACH.Position);
            if (!Bang_SACH.Ghi())
                MessageBox.Show("Xóa thất bại!");
        }
        private void btGhi_Click(object sender, EventArgs e)
        {
            try
            {
                DS_SACH.EndCurrentEdit();
                Bang_SACH.Ghi();
                An_hien_nut_lenh(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
