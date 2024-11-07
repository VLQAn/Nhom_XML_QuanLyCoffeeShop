using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_QuanLyCoffeeShop.UI
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            panel_viewBar.BackColor = ColorTranslator.FromHtml("#482e1d");
            panel_titile.BackColor = ColorTranslator.FromHtml("#f0daae");
            panel_app_name.BackColor = ColorTranslator.FromHtml("#895d2b");

            BackColor = ColorTranslator.FromHtml("#f0daae");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new QuanLyDoanhThu(), "DOANH THU");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new QuanLySanPham(), "QUẢN LÝ SẢN PHẨM");
        }

        private void ShowFormInPanel(Form formToShow, string tenMuc)
        {
            // Xóa tất cả các control hiện tại trong panel_Content
            this.panel_Content.Controls.Clear();

            // Thiết lập form con
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;

            // Thêm form vào panel và hiển thị
            this.panel_Content.Controls.Add(formToShow);
            formToShow.Show();

            // Cập nhật tên mục
            label_TenMuc.Text = tenMuc;
        }
    }
}
