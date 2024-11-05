using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XML_QuanLyCoffeeShop.UI;


namespace XML_QuanLyCoffeeShop
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel_viewBar.BackColor = ColorTranslator.FromHtml("#482e1d");
            panel_titile.BackColor = ColorTranslator.FromHtml("#f0daae");
            panel_app_name.BackColor = ColorTranslator.FromHtml("#895d2b");

            BackColor = ColorTranslator.FromHtml("#f0daae");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_titile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormQuanLyKhachHang quanLyKh = new FormQuanLyKhachHang();
            quanLyKh.Show();
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
