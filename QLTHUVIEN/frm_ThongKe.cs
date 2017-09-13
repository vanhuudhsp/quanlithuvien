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

namespace QLTHUVIEN
{
    public partial class frm_ThongKe : Form
    {
        public frm_ThongKe()
        {
            InitializeComponent();
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            rptMUONSACH rpt = new rptMUONSACH();
            DataSet ds = new DataSet();
            string query = "Select b.MaThe, b.TenBanDoc, s.MaSach, s.TuaDe, s.TacGia, NgayMuon, NgayTra "
                           +" from (SACH s inner join MUONSACH m on s.MaSach = m.MaSach) " 
                           +  " inner join BANDOC b on m.MaThe = b.MaThe "
                           +" where NgayTra is Null";
            SqlDataAdapter da = new SqlDataAdapter( query , XL_BANG.Chuoi_lien_ket);
            da.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
