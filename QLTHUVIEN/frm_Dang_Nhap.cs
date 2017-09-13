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
            txtServerName.Text = "localhost";
            cb_Authentication.SelectedIndex = 0;
        }

        private void cb_Authentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hide = true;
            if (cb_Authentication.SelectedIndex == 0)
                hide = false;
            txtUserName.Enabled = hide;
            txtPassword.Enabled = hide;
        }

        private void bt_Dang_Nhap_Click(object sender, EventArgs e)
        {
            if (cb_Authentication.SelectedIndex == 0)
                LOP.XL_BANG.Chuoi_lien_ket = "Data Source="+ txtServerName.Text  + 
                                             ";Initial Catalog=QLTHUVIEN;Integrated Security=True";
            else
                LOP.XL_BANG.Chuoi_lien_ket = "Data Source=" + txtServerName.Text + ";Initial Catalog=QLTHUVIEN;User ID="+ 
                                             txtUserName.Text + ";Password="+txtPassword.Text ;
            SqlConnection cnn = new SqlConnection(LOP.XL_BANG.Chuoi_lien_ket);
            try
            {
                cnn.Open();
                MessageBox.Show("Kết nối thành công!");
                cnn.Close();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
