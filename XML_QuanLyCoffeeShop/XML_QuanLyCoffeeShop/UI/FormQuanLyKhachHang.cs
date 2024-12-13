using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using XML_QuanLyCoffeeShop.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;

namespace XML_QuanLyCoffeeShop.UI
{
    public partial class FormQuanLyKhachHang : Form
    {
        KhachHang kh = new KhachHang();
        FileXml Fxml = new FileXml();
        string IDKhachHang, HoTen, NgaySinh, GioiTinh, CCCD, SDT, DiaChi;

        public FormQuanLyKhachHang()
        {
            InitializeComponent();

            BackColor = ColorTranslator.FromHtml("#f0daae");
        }

        public void hienthiKhachHang()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("KhachHang.xml");
            dgv_KhachHang.DataSource = dt;

            dgv_KhachHang.Columns["IDKhachHang"].HeaderText = "Mã KH";
            dgv_KhachHang.Columns["HoTen"].HeaderText = "Họ Tên";
            dgv_KhachHang.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgv_KhachHang.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgv_KhachHang.Columns["CCCD"].HeaderText = "CCCD";
            dgv_KhachHang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgv_KhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";

        }
        public void LoadDuLieu()
        {
            IDKhachHang = txt_input_Id.Text;
            HoTen = txt_input_HoTen.Text;
            NgaySinh = date_input_NgaySinh.Text;
            GioiTinh = cbo_input_GioiTinh.Text;
            CCCD = txt_input_CCCD.Text;
            SDT = txt_input_Sdt.Text;
            DiaChi = txt_input_DiaChi.Text;
        }

        private void InitCboData()
        {
            cbo_input_GioiTinh.Items.Clear();
            cbo_input_GioiTinh.Items.Add("Nam");
            cbo_input_GioiTinh.Items.Add("Nữ");
            cbo_input_GioiTinh.Items.Add("Khác");

            cbo_input_GioiTinh.SelectedIndex = 0;
        }


        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            hienthiKhachHang();
            InitCboData();
            dgv_KhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgv_KhachHang.CurrentRow.Index;

            txt_input_Id.Text = dgv_KhachHang.Rows[d].Cells[0].Value.ToString();
            txt_input_HoTen.Text = dgv_KhachHang.Rows[d].Cells[1].Value.ToString();
            date_input_NgaySinh.Text = dgv_KhachHang.Rows[d].Cells[2].Value.ToString();
            cbo_input_GioiTinh.Text = dgv_KhachHang.Rows[d].Cells[3].Value.ToString();
            txt_input_CCCD.Text = dgv_KhachHang.Rows[d].Cells[4].Value.ToString();
            txt_input_Sdt.Text = dgv_KhachHang.Rows[d].Cells[5].Value.ToString();
            txt_input_DiaChi.Text = dgv_KhachHang.Rows[d].Cells[6].Value.ToString();
        }

        private void btn_XoaKhachHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_input_Id.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa khách hàng này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    kh.xoaKH(txt_input_Id.Text);
                    string sql = $"DELETE FROM tbKHACHHANG WHERE IDKhachHang = '{txt_input_Id.Text}'";
                    Fxml.InsertOrUpDateSQL(sql).ToString();
                    MessageBox.Show("Xóa khách hàng thành công!");

                    hienthiKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi xóa khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_TimKhachHang_Click(object sender, EventArgs e)
        {
            string tenTimKiem = txt_input_Ten_TimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tenTimKiem))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = Fxml.HienThi("KhachHang.xml");
                var ketQua = dt.AsEnumerable()
                               .Where(row => row.Field<string>("HoTen").ToLower().Contains(tenTimKiem))
                               .CopyToDataTable();

                dgv_KhachHang.DataSource = ketQua;
                if (ketQua.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            hienthiKhachHang();
        }

        private void btn_XemTrenWeb_Click(object sender, EventArgs e)
        {
            try
            {
                string xmlPath = Application.StartupPath + @"\KhachHang.xml";
                XDocument xDoc = XDocument.Load(xmlPath);

                StringBuilder htmlBuilder = new StringBuilder();
                htmlBuilder.Append("<html>" +
                                         "<head>" +
                                            "<title>Danh sách nhân viên</title>" +
                                         "</head>" +
                                         "<style>" +
                                             "table{" +
                                                 "border:solid 1px black;" +
                                                 "border-collapse:collapse;" +
                                                 "padding: 10px" +
                                             "}" +
                                             "td{" +
                                                 "border:solid 1px black;" +
                                                 "text-align: center" +
                                             "}" +
                                             "th {" +
                                                 "background-color: #895d2b;" +
                                                 "color:#fff" +
                                             "}" +
                                         "</style>" +
                                         "<body>");
                htmlBuilder.Append("<h2 style='text-align: center;'>Danh sách khách hàng</h2>");
                htmlBuilder.Append("<table border='1' style='border-collapse: collapse; width: 100%;'>");
                htmlBuilder.Append("<tr>" +
                                        "<th>Mã KH</th>" +
                                        "<th>Họ Tên</th>" +
                                        "<th>Ngày Sinh</th>" +
                                        "<th>Giới Tính</th>" +
                                        "<th>CCCD</th>" +
                                        "<th>SĐT</th>" +
                                        "<th>Địa Chỉ</th>" +
                                    "</tr>");

                foreach (var khachHang in xDoc.Descendants("KhachHang"))
                {
                    htmlBuilder.Append("<tr>");
                    htmlBuilder.Append($"<td>{khachHang.Element("IDKhachHang")?.Value}</td>");
                    htmlBuilder.Append($"<td>{khachHang.Element("HoTen")?.Value}</td>");
                    htmlBuilder.Append($"<td>{khachHang.Element("NgaySinh")?.Value}</td>");
                    htmlBuilder.Append($"<td>{khachHang.Element("GioiTinh")?.Value}</td>");
                    htmlBuilder.Append($"<td>{khachHang.Element("CCCD")?.Value}</td>");
                    htmlBuilder.Append($"<td>{khachHang.Element("SDT")?.Value}</td>");
                    htmlBuilder.Append($"<td>{khachHang.Element("DiaChi")?.Value}</td>");
                    htmlBuilder.Append("</tr>");
                }

                htmlBuilder.Append("</table>");
                htmlBuilder.Append("</body></html>");

                // Lưu HTML vào file tạm
                string tempHtmlPath = Application.StartupPath + @"\KhachHang.html";
                File.WriteAllText(tempHtmlPath, htmlBuilder.ToString(), Encoding.UTF8);

                Process.Start(new ProcessStartInfo
                {
                    FileName = tempHtmlPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txt_input_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            LoadDuLieu();

            DateTime dt = DateTime.Parse(date_input_NgaySinh.Text);
            string sql = $"INSERT INTO tbKHACHHANG (HoTen, NgaySinh, GioiTinh, CCCD, SDT, DiaChi) " +
                     $"VALUES (N'{HoTen}', '{NgaySinh}', N'{GioiTinh}', '{CCCD}', '{SDT}', N'{DiaChi}')";

            IDKhachHang = Fxml.InsertOrUpDateSQL(sql).ToString();

            kh.themKH(IDKhachHang, HoTen, dt.ToString("dd-MM-yyyy"), GioiTinh, CCCD, SDT, DiaChi);
            MessageBox.Show("Thêm khách hàng thành công!");
            hienthiKhachHang();
            txt_input_Id.Focus();
        }

        private void btn_SuaKhachHang_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            if (string.IsNullOrEmpty(IDKhachHang))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime dt = DateTime.Parse(NgaySinh);

            string sql = $"UPDATE tbKHACHHANG " +
                         $"SET HoTen = N'{HoTen}', NgaySinh = '{dt:yyyy-MM-dd}', GioiTinh = N'{GioiTinh}', " +
                         $"CCCD = '{CCCD}', SDT = '{SDT}', DiaChi = N'{DiaChi}' " +
                         $"WHERE IDKhachHang = '{IDKhachHang}'";

            Fxml.InsertOrUpDateSQL(sql);

            kh.suaKH(txt_input_Id.Text, txt_input_HoTen.Text, dt.ToString("dd-MM-yyyy"), cbo_input_GioiTinh.Text, txt_input_CCCD.Text, txt_input_Sdt.Text, txt_input_DiaChi.Text);
            MessageBox.Show("Cập nhật khách hàng thành công!");
            hienthiKhachHang();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
