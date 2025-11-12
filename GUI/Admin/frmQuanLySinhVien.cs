using BTL_LTTQ.GUI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ.GUI.Admin
{
    public partial class frmQuanLySinhVien : Form
    {
        UC_Template sidebar;

        public frmQuanLySinhVien()
        {
            InitializeComponent();
            sidebar = new UC_Template();
            sidebar.Dock = DockStyle.Left;
            sidebar.MenuClicked += Sidebar_MenuClicked;
            this.Controls.Add(sidebar);

            this.Resize += FrmQuanLySinhVien_Resize; // Gắn sự kiện resize
        }

        private void FrmQuanLySinhVien_Resize(object sender, EventArgs e)
        {
            sidebar.AutoAdjustByWindowSize(this.Width);
        }

        private void Sidebar_MenuClicked(object sender, string buttonName)
        {
            //switch (buttonName)
            //{
            //    case "btnTrangChu":
            //        LoadContent(new UC_TrangChu());
            //        break;
            //    case "btnSinhVien":
            //        LoadContent(new UC_QuanLySinhVien());
            //        break;
            //    case "btnMonHoc":
            //        LoadContent(new UC_QuanLyMonHoc());
            //        break;
            //    case "btnThongKe":
            //        LoadContent(new UC_ThongKe());
            //        break;
            //}
        }

        private void LoadContent(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbHoTen_Click(object sender, EventArgs e)
        {

        }
    }
}
