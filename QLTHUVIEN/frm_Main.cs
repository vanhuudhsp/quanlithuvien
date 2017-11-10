using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.Controls;

namespace QLTHUVIEN
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void office2007StartButton1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem3_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            ribbonBar1.Dock = DockStyle.Top;
        }

        private void bt_Thong_Tin_Doc_Gia_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Bạn Đọc");
            frm_BANDOC  f_BANDOC = new frm_BANDOC();
            f_BANDOC.Dock = DockStyle.Fill;
            f_BANDOC.FormBorderStyle = FormBorderStyle.None;
            f_BANDOC.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_BANDOC);
            f_BANDOC.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void tabControl1_TabItemClose(object sender, TabStripActionEventArgs e)
        {
          
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Nhập sách");
            
            frm_NHAPSACH  f_NHAPSACH = new frm_NHAPSACH();
            f_NHAPSACH.Dock = DockStyle.Fill;
            f_NHAPSACH.FormBorderStyle = FormBorderStyle.None;
            f_NHAPSACH.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_NHAPSACH);
            f_NHAPSACH.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void bt_Thoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Tra_Cuu_Click(object sender, EventArgs e)
        {

            TabItem tab = tabControl1.CreateTab("Tra cứu sách");

            frm_TRACUUSACH  f_TRACUUSACH = new frm_TRACUUSACH();
            f_TRACUUSACH.Dock = DockStyle.Fill;
            f_TRACUUSACH.FormBorderStyle = FormBorderStyle.None;
            f_TRACUUSACH.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_TRACUUSACH);
            f_TRACUUSACH.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Tra cứu sách");

            frm_MUONSACH  f_MUONSACH = new frm_MUONSACH();
            f_MUONSACH.Dock = DockStyle.Fill;
            f_MUONSACH.FormBorderStyle = FormBorderStyle.None;
            f_MUONSACH.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_MUONSACH);
            f_MUONSACH.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }

        private void btTK_MuonSach_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Thống Kê Mượn Sách");

            frm_ThongKe  f_THONGKE = new frm_ThongKe();
            f_THONGKE.Dock = DockStyle.Fill;
            f_THONGKE.FormBorderStyle = FormBorderStyle.None;
            f_THONGKE.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_THONGKE);
            f_THONGKE.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }
    }
}
