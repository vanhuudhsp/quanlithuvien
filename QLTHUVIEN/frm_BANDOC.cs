using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLTHUVIEN.LOP;

namespace QLTHUVIEN
{
    public partial class frm_BANDOC : Form
    {
        
        public frm_BANDOC()
        {
            InitializeComponent();
        }

        bool cap_nhat = false ;
        XL_BANDOC Bang_BANDOC;
        BindingManagerBase DS_BANDOC;
        private void frm_BANDOC_Load(object sender, EventArgs e)
        {
            Bang_BANDOC = new LOP.XL_BANDOC();
            Bang_BANDOC.Columns["MaThe"].ReadOnly = true;
            
            dgv_BANDOC.DataSource = Bang_BANDOC;
            
            txtMaThe.DataBindings.Add("text", Bang_BANDOC, "MaThe");
            txtTenBanDoc.DataBindings.Add("text", Bang_BANDOC, "TenBanDoc");
            txtDiaChi.DataBindings.Add("text", Bang_BANDOC, "DiaChi");
            txtSoDT.DataBindings.Add("text", Bang_BANDOC, "SoDT");
            
            DS_BANDOC = this.BindingContext[Bang_BANDOC];
            DS_BANDOC.PositionChanged += DS_BANDOC_PositionChanged;
 
            An_hien_nut_lenh(false);
            
        }

        private void bt_Ve_dau_Click(object sender, EventArgs e)
        { DS_BANDOC.Position = 0; }

        private void bt_Ve_cuoi_Click(object sender, EventArgs e)
        { DS_BANDOC.Position = DS_BANDOC.Count - 1; }

        private void bt_Next_Click(object sender, EventArgs e)
        { DS_BANDOC.Position += 1; }

        private void bt_previous_Click(object sender, EventArgs e)
        {
            DS_BANDOC.Position -= 1;
        }
        private void An_hien_nut_lenh(bool capnhat)
        {
            bt_them.Enabled = !capnhat ;
            bt_Xoa.Enabled = !capnhat;
            bt_sua.Enabled = !capnhat;
            bt_Ghi.Enabled = capnhat;
            bt_Khong_Ghi.Enabled = capnhat;
        }

       
        private void bt_them_Click(object sender, EventArgs e)
        {

            An_hien_nut_lenh(true);

            DS_BANDOC.AddNew();

            //Phat sinh ma the
            SqlConnection cnn = new SqlConnection(LOP.XL_BANG.Chuoi_lien_ket);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Phat_sinh_ma_the";
            cmd.Parameters.Add("MaThe", System.Data.SqlDbType.VarChar, 6);
            cmd.Parameters["MaThe"].Direction = System.Data.ParameterDirection.ReturnValue;
            cmd.ExecuteScalar();
            //
            DataRowView dr = (DataRowView)DS_BANDOC.Current;
            dr["MaThe"] = cmd.Parameters["MaThe"].Value.ToString();
            txtMaThe.Text = cmd.Parameters["MaThe"].Value.ToString();
            //
            cnn.Close();
            cap_nhat = true;
        }
        private void bt_Xoa_Click(object sender, EventArgs e)
        {

            DS_BANDOC.RemoveAt(DS_BANDOC.Position);
            if (!Bang_BANDOC.Ghi())
                MessageBox.Show("Xóa thất bại!");
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            An_hien_nut_lenh(true);
            cap_nhat = true;
        }

        private void bt_Khong_Ghi_Click(object sender, EventArgs e)
        {
            DS_BANDOC.CancelCurrentEdit();
            Bang_BANDOC.RejectChanges();
            An_hien_nut_lenh(false);
            cap_nhat = false;
        }
       
        private void bt_Ghi_Click(object sender, EventArgs e)
        {
            try
            {
                DS_BANDOC.EndCurrentEdit();
                Bang_BANDOC.Ghi();
                An_hien_nut_lenh(false);
                cap_nhat = false;
               
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void DS_BANDOC_PositionChanged(object sender, EventArgs e)
        {
           if (cap_nhat == true)
           {
               bt_Khong_Ghi_Click(sender, e);
           }
        }

        private void dgv_BANDOC_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cap_nhat = true;
        }
    }
}
