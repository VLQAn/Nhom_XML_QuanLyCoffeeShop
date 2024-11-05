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
    public partial class FormQuanLyKhachHang : Form
    {
        public FormQuanLyKhachHang()
        {

            InitializeComponent();
            panel_viewBar.BackColor = ColorTranslator.FromHtml("#482e1d");
            panel_titile.BackColor = ColorTranslator.FromHtml("#f0daae");
            panel_app_name.BackColor = ColorTranslator.FromHtml("#895d2b");

            BackColor = ColorTranslator.FromHtml("#f0daae");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 quanLySp = new Form1();
            quanLySp.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormQuanLyNhanVien quanLyNv = new FormQuanLyNhanVien();
            quanLyNv.Show();
            this.Hide();
        }
    }
}
