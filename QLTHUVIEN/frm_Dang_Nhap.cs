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
using BusinessLogic;
using DataAccess;
using System.Configuration;
using System.Data.SqlClient;
namespace QLTHUVIEN
{
    public partial class frm_Dang_Nhap : Form
    {
        public frm_Dang_Nhap()
        {
            InitializeComponent();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Dang_Nhap_Load(object sender, EventArgs e)
        {
            
        }

        
        private void bt_Dang_Nhap_Click(object sender, EventArgs e)
        {
            XL_BANG.Chuoi_lien_ket = "Data Source=.;Initial Catalog=QLTHUVIEN;Integrated Security=True";
            try
            {
                XL_TAIKHOAN tk = new XL_TAIKHOAN("select * from TAIKHOAN where TenTK ='" + txtUserName.Text
                + "' and MatKhau ='" + txtPassword.Text + "'");
                if(tk.Rows.Count>0)
                {
                    frm_Main f_Main = new frm_Main();
                    f_Main.StartPosition = FormStartPosition.CenterParent;
                    f_Main.ShowDialog(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập sai UserName và Password!!!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
