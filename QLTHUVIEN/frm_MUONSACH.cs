using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTHUVIEN.LOP;
using System.Data.SqlClient;
namespace QLTHUVIEN
{
    public partial class frm_MUONSACH : Form
    {
        public frm_MUONSACH()
        {
            InitializeComponent();
        }
        XL_BANDOC bang_BANDOC;
        XL_SACH bang_SACH;
        XL_MUONSACH bang_MUONSACH;
        BindingManagerBase DS_MUON_SACH;
        private void frm_MUONSACH_Load(object sender, EventArgs e)
        {
            bang_MUONSACH = new XL_MUONSACH();
            bang_BANDOC = new XL_BANDOC();
            bang_SACH = new XL_SACH();

            cbMaThe.DataSource = bang_BANDOC;
            cbMaThe.DisplayMember = "MaThe";
            cbMaThe.ValueMember = "MaThe";
            txtTenBanDoc.DataBindings.Add("text", bang_BANDOC, "TenBanDoc");
            txtSoDT.DataBindings.Add("text", bang_BANDOC, "SoDT");
            txtDiaChi.DataBindings.Add("text", bang_BANDOC, "DiaChi");

            cbMaSach.DataSource = bang_SACH;
            cbMaSach.DisplayMember = "MaSach";
            cbMaSach.ValueMember = "MaSach";
            txtTuaDe.DataBindings.Add("text", bang_SACH, "TuaDe");
            txtTacGia.DataBindings.Add("text", bang_SACH, "TacGia");
            

            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { bang_MUONSACH, bang_SACH });
            DataRelation qh = new DataRelation("FR_SACH_MUONSACH", bang_SACH.Columns["MaSach"], bang_MUONSACH.Columns["MaSach"]);
            ds.Relations.Add(qh);
            DataColumn cot_TuaDe = new DataColumn("TuaDe", Type.GetType("System.String"), "Parent(FR_SACH_MUONSACH).TuaDe");
            DataColumn cot_TacGia = new DataColumn("TacGia", Type.GetType("System.String"), "Parent(FR_SACH_MUONSACH).TacGia");
            bang_MUONSACH.Columns.AddRange(new DataColumn[] { cot_TuaDe, cot_TacGia });


            cbMaSach.DataBindings.Add("SelectedValue", bang_MUONSACH, "MaSach");
            dNgayMuon.DataBindings.Add("text", bang_MUONSACH, "NgayMuon");
            dNgayTra.DataBindings.Add("text", bang_MUONSACH, "NgayTra");

            dgvMUONSACH.DataSource = bang_MUONSACH;
            DS_MUON_SACH = this.BindingContext[bang_MUONSACH];
            
            cbMaThe_SelectedIndexChanged(sender, e);
        }

        private void cbMaThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            bang_MUONSACH.DefaultView.RowFilter = "MaThe ='" + cbMaThe.SelectedValue.ToString() + "' and NgayTra is Null";

        }

        private void dgvMUONSACH_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvMUONSACH_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            dgvMUONSACH.Rows[e.Row.Index].Cells["STT"].Value = e.Row.Index + 1;
        }

        private void dgvMUONSACH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvMUONSACH.Rows)
            {
                r.Cells["STT"].Value = r.Index + 1;
            }
        }
        private void An_hien_nut_lenh(bool capnhat)
        {
            btMuonSach.Enabled = !capnhat;
            btTraSach.Enabled = !capnhat;
            btSua.Enabled = !capnhat;
            btGhi.Enabled = capnhat;
            btKhongGhi.Enabled = capnhat;
        }

        private void btMuonSach_Click(object sender, EventArgs e)
        {
            An_hien_nut_lenh(true);
            DS_MUON_SACH.AddNew();
            DataRowView dr = (DataRowView)DS_MUON_SACH.Current;
            dr["MaThe"] = cbMaThe.SelectedValue;
        }

        private void btTraSach_Click(object sender, EventArgs e)
        {
            An_hien_nut_lenh(true);
            dNgayTra.Enabled = true;
            dNgayMuon.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            An_hien_nut_lenh(true);
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            try
            {
                DS_MUON_SACH.EndCurrentEdit();
                bang_MUONSACH.Ghi();
                An_hien_nut_lenh(false);
                dNgayTra.Enabled = false;
                dNgayMuon.Enabled = true;        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btKhongGhi_Click(object sender, EventArgs e)
        {
            DS_MUON_SACH.CancelCurrentEdit();
            bang_MUONSACH.RejectChanges();
            An_hien_nut_lenh(false);
            dNgayTra.Enabled = false;
            dNgayMuon.Enabled = true; 
        }

      

        
    }
}
