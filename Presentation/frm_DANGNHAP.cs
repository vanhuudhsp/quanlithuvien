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
    public partial class frm_DANGNHAP : Form
    {

       


        public frm_DANGNHAP()
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

        public frm_MAIN parentForm;

        public frm_MAIN setParentForm
        {
            set { parentForm = value; }
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
                    parentForm.logIn(txtUserName.Text);
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
