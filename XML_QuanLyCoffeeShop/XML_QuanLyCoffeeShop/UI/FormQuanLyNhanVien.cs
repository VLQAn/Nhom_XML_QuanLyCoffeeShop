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
    public partial class FormQuanLyNhanVien : Form
    {
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            panel_viewBar.BackColor = ColorTranslator.FromHtml("#482e1d");
            panel_titile.BackColor = ColorTranslator.FromHtml("#f0daae");
            panel_app_name.BackColor = ColorTranslator.FromHtml("#895d2b");

            BackColor = ColorTranslator.FromHtml("#f0daae");
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbo_input_GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_input_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_input_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormQuanLyKhachHang quanLyKh = new FormQuanLyKhachHang();
            quanLyKh.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 quanLySp = new Form1();
            quanLySp.Show();
            this.Hide();
        }
    }
}
