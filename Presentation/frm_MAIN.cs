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
    public partial class frm_MAIN : Form
    {
       


             
        public frm_MAIN()
        {
            InitializeComponent();
            showFormDangNhap();
        }

        private void showFormDangNhap()
        {
            frm_DANGNHAP fDangNhap = new frm_DANGNHAP();
            fDangNhap.setParentForm = this;
            fDangNhap.StartPosition = FormStartPosition.CenterScreen;
            fDangNhap.ShowDialog();
        }

        public void logIn(string tenNV)
        {
            btnHome.Text = "Phần Mềm Quản Lý Thư Viện - Xin chào " + tenNV;
            btnDangNhap.Text = "Đăng xuất";
            btnDangNhap.Image = QLTHUVIEN.Properties.Resources.logout;

            tabBanDoc.Enabled = true;
            tabSach.Enabled = true;
            tabMuonTraSach.Enabled = true;
            tabThongKe.Enabled = true;

            
        }
        private void logOut()
        {
            btnHome.Text = "Phần Mềm Quản Lý Thư Viện";
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.Image = QLTHUVIEN.Properties.Resources.login;
            tabBanDoc.Enabled = false;
            tabSach.Enabled = false;
            tabMuonTraSach.Enabled = false;
            tabThongKe.Enabled = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
          
            ribbonBar1.Dock = DockStyle.Top;
        }

        private void bt_Thong_Tin_Doc_Gia_Click(object sender, EventArgs e)
        {
            TabItem tab = tabMain.CreateTab("Bạn Đọc");
            frm_BANDOC  f_BANDOC = new frm_BANDOC();
            f_BANDOC.Dock = DockStyle.Fill;
            f_BANDOC.FormBorderStyle = FormBorderStyle.None;
            f_BANDOC.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_BANDOC);
            f_BANDOC.Show();
            tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
        }
        private void buttonItem18_Click(object sender, EventArgs e)
        {
            TabItem tab = tabMain.CreateTab("Nhập sách");
            
            frm_NHAPSACH  f_NHAPSACH = new frm_NHAPSACH();
            f_NHAPSACH.Dock = DockStyle.Fill;
            f_NHAPSACH.FormBorderStyle = FormBorderStyle.None;
            f_NHAPSACH.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_NHAPSACH);
            f_NHAPSACH.Show();
            tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
        }

        private void bt_Thoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Tra_Cuu_Click(object sender, EventArgs e)
        {

            TabItem tab = tabMain.CreateTab("Tra cứu sách");

            frm_TRACUUSACH  f_TRACUUSACH = new frm_TRACUUSACH();
            f_TRACUUSACH.Dock = DockStyle.Fill;
            f_TRACUUSACH.FormBorderStyle = FormBorderStyle.None;
            f_TRACUUSACH.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_TRACUUSACH);
            f_TRACUUSACH.Show();
            tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            TabItem tab = tabMain.CreateTab("Tra cứu sách");

            frm_MUONSACH  f_MUONSACH = new frm_MUONSACH();
            f_MUONSACH.Dock = DockStyle.Fill;
            f_MUONSACH.FormBorderStyle = FormBorderStyle.None;
            f_MUONSACH.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_MUONSACH);
            f_MUONSACH.Show();
            tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
        }

        private void btTK_MuonSach_Click(object sender, EventArgs e)
        {
            TabItem tab = tabMain.CreateTab("Thống Kê Mượn Sách");

            frm_THONGKE  f_THONGKE = new frm_THONGKE();
            f_THONGKE.Dock = DockStyle.Fill;
            f_THONGKE.FormBorderStyle = FormBorderStyle.None;
            f_THONGKE.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_THONGKE);
            f_THONGKE.Show();
            tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(btnDangNhap.Text=="Đăng nhập")
            {
                showFormDangNhap();
            }else
            {
                logOut();
            }

        }
    }
}
