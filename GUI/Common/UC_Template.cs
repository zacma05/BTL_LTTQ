using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ.GUI.Common
{
    public partial class UC_Template : UserControl
    {
        public event EventHandler<string> MenuClicked;
        private bool isCollapsed = false;
        private bool isTextVisible = false; // Biến trạng thái mới

        private Timer animationTimer;
        private int targetWidth;
        private const int ANIMATION_SPEED_DIVISOR = 6;
        private const int MAX_WIDTH = 400;
        private const int MIN_WIDTH = 100;

        // Mốc để thay đổi text/icon (khoảng 2/3 của MAX_WIDTH)
        private const int TEXT_TRIGGER_WIDTH = 270;

        public UC_Template()
        {
            InitializeComponent();

            animationTimer = new Timer();
            animationTimer.Interval = 15;
            animationTimer.Tick += AnimationTimer_Tick;

            // Thiết lập trạng thái ban đầu (mở rộng)
            isCollapsed = false;
            isTextVisible = true;
            targetWidth = MAX_WIDTH;
            SnapToWidth(false);       // Cài đặt Width ban đầu
            UpdateMenuVisuals(false); // Cài đặt Text/Icon ban đầu
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ToggleMenu();
        }

        private void ToggleMenu()
        {
            isCollapsed = !isCollapsed;
            targetWidth = isCollapsed ? MIN_WIDTH : MAX_WIDTH;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int distance = targetWidth - panelMenu.Width;

            if (Math.Abs(distance) < 3)
            {
                // Animation kết thúc, dừng timer và "snap" về đúng vị trí
                animationTimer.Stop();
                SnapToWidth(isCollapsed);
                UpdateMenuVisuals(isCollapsed); // Đảm bảo trạng thái cuối cùng chính xác
                isTextVisible = !isCollapsed; // Đồng bộ trạng thái
            }
            else
            {
                // Animation đang chạy
                int step = (distance / ANIMATION_SPEED_DIVISOR) + (distance > 0 ? 1 : -1);

                panelMenu.Width += step;
                this.Width += step;

                // *** LOGIC THAY ĐỔI TEXT/ICON GIỮA ANIMATION ***

                // 1. Nếu đang THU GỌN, text VẪN HIỆN, và Width < mốc
                if (isCollapsed && isTextVisible && panelMenu.Width < TEXT_TRIGGER_WIDTH)
                {
                    UpdateMenuVisuals(true); // Ẩn text, căn giữa icon
                    isTextVisible = false;
                }
                // 2. Nếu đang MỞ RỘNG, text ĐANG ẨN, và Width > mốc
                else if (!isCollapsed && !isTextVisible && panelMenu.Width > TEXT_TRIGGER_WIDTH)
                {
                    UpdateMenuVisuals(false); // Hiện text, căn trái icon
                    isTextVisible = true;
                }
            }
        }

        // HÀM MỚI: Chỉ cập nhật Width (không animation)
        private void SnapToWidth(bool collapse)
        {
            int width = collapse ? MIN_WIDTH : MAX_WIDTH;
            this.Width = width;
            panelMenu.Width = width;
        }

        // HÀM MỚI: Chỉ cập nhật Text, Icon, Padding
        private void UpdateMenuVisuals(bool collapse)
        {
            if (collapse) // Thu gọn (ẩn text, căn giữa icon)
            {
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    if (menuButton != btnMenu)
                    {
                        menuButton.Text = "";
                        menuButton.ImageAlign = ContentAlignment.MiddleCenter; // Yêu cầu của bạn
                        menuButton.Padding = new Padding(0);
                    }
                }
            }
            else // Mở rộng (hiện text, căn trái icon)
            {
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    if (menuButton != btnMenu)
                    {
                        menuButton.Text = "  " + menuButton.Tag?.ToString();
                        menuButton.ImageAlign = ContentAlignment.MiddleLeft; // Yêu cầu của bạn
                        menuButton.Padding = new Padding(10, 0, 0, 0);
                    }
                }
            }
        }

        // Hàm xử lý click chung
        private void MenuButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            MenuClicked?.Invoke(this, btn.Tag?.ToString());

            // Không tự động đóng menu nữa (hoặc bạn có thể giữ nếu muốn)
            // if (!isCollapsed)
            // {
            //     ToggleMenu();
            // }
        }

        // Cập nhật hàm AutoAdjust để dùng hàm mới
        public void AutoAdjustByWindowSize(int formWidth)
        {
            if (formWidth < 900 && !isCollapsed)
            {
                SnapToWidth(true);
                UpdateMenuVisuals(true);
                isCollapsed = true;
                isTextVisible = false;
                targetWidth = MIN_WIDTH;
            }
            else if (formWidth >= 900 && isCollapsed)
            {
                SnapToWidth(false);
                UpdateMenuVisuals(false);
                isCollapsed = false;
                isTextVisible = true;
                targetWidth = MAX_WIDTH;
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            MenuClicked?.Invoke(this, "TrangChu");
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            MenuClicked?.Invoke(this, "SinhVien");
        }

        private void btnHocPhan_Click(object sender, EventArgs e)
        {
            MenuClicked?.Invoke(this, "HocPhan");
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            MenuClicked?.Invoke(this, "NhapDiem");
        }

        private void btnTKBC_Click(object sender, EventArgs e)
        {
            MenuClicked?.Invoke(this, "TKBC");
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            MenuClicked?.Invoke(this, "TaiKhoan");
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            MenuClicked?.Invoke(this, "XemDiem");
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            MenuClicked?.Invoke(this, "Khoa");
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            MenuClicked?.Invoke(this, "ThongTin");
        }
    }
}
