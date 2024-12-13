using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using XML_QuanLyCoffeeShop.Class;

namespace XML_QuanLyCoffeeShop.UI
{
    public partial class FormQuanLyNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        FileXml Fxml = new FileXml();
        string IDNhanVien, HoTen, GioiTinh, NgaySinh, SoNha,
            TenDuong, QuanHuyen, TinhThanhPho, CCCD, Email,
            SDT, NgayBatDauLamViec;

        private void btn_TimNhanVien_Click(object sender, EventArgs e)
        {
            string tenTimKiem = txt_input_Ten_TimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tenTimKiem))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = Fxml.HienThi("NhanVien.xml");
                var ketQua = dt.AsEnumerable()
                               .Where(row => row.Field<string>("HoTen").ToLower().Contains(tenTimKiem))
                               .CopyToDataTable();

                dgv_NhanVien.DataSource = ketQua;
                if (ketQua.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            hienthiNhanVien();
        }

        private void btn_XemTrenWeb_Click(object sender, EventArgs e)
        {
            try
            {
                string xmlPath = Application.StartupPath + @"\NhanVien.xml";
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
                                        "</style>"+
                                        "<body>");
                htmlBuilder.Append("<h2 style='text-align: center;'>Danh sách nhân viên</h2>");
                htmlBuilder.Append("<table border='1' style='border-collapse: collapse; width: 100%;'>");
                htmlBuilder.Append("<tr>" +
                                        "<th>Mã NV</th>" +
                                        "<th>Họ và Tên</th>" +
                                        "<th>Giới Tính</th>" +
                                        "<th>Ngày Sinh</th>" +
                                        "<th>Số Nhà</th>" +
                                        "<th>Tên Đường</th>" +
                                        "<th>Quận/Huyện</th>" +
                                        "<th>Tỉnh/Thành Phố</th>" +
                                        "<th>CCCD</th>" +
                                        "<th>Email</th>" +
                                        "<th>Số Điện Thoại</th>" +
                                        "<th>Ngày Bắt Đầu Làm Việc</th>" +
                                    "</tr>");

                foreach (var nhanVien in xDoc.Descendants("NhanVien"))
                {
                    htmlBuilder.Append("<tr>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("IDNhanVien")?.Value}</td>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("HoTen")?.Value}</td>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("GioiTinh")?.Value}</td>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("NgaySinh")?.Value}</td>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("SoNha")?.Value}</td>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("TenDuong")?.Value}</td>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("QuanHuyen")?.Value}</td>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("TinhThanhPho")?.Value}</td>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("CCCD")?.Value}</td>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("Email")?.Value}</td>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("SDT")?.Value}</td>");
                    htmlBuilder.Append($"<td>{nhanVien.Element("NgayBatDauLamViec")?.Value}</td>");
                    htmlBuilder.Append("</tr>");
                }

                htmlBuilder.Append("</table>");
                htmlBuilder.Append("</body></html>");

                // Lưu HTML vào file tạm
                string tempHtmlPath = Application.StartupPath + @"\NhanVien.html";
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

        public FormQuanLyNhanVien()
        {
            InitializeComponent();


            BackColor = ColorTranslator.FromHtml("#f0daae");
        }

        public void hienthiNhanVien()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("NhanVien.xml");
            dgv_NhanVien.DataSource = dt;

            dgv_NhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgv_NhanVien.Columns[1].HeaderText = "Họ và Tên";
            dgv_NhanVien.Columns[2].HeaderText = "Giới Tính";
            dgv_NhanVien.Columns[3].HeaderText = "Ngày Sinh";
            dgv_NhanVien.Columns[4].HeaderText = "Số Nhà";
            dgv_NhanVien.Columns[5].HeaderText = "Tên Đường";
            dgv_NhanVien.Columns[6].HeaderText = "Quận/Huyện";
            dgv_NhanVien.Columns[7].HeaderText = "Tỉnh/Thành Phố";
            dgv_NhanVien.Columns[8].HeaderText = "CCCD";
            dgv_NhanVien.Columns[9].HeaderText = "Email";
            dgv_NhanVien.Columns[10].HeaderText = "Số Điện Thoại";
            dgv_NhanVien.Columns[11].HeaderText = "Ngày Bắt Đầu Làm Việc";
        }
        public void LoadDuLieu()
        {
            IDNhanVien = txt_input_Id.Text;
            HoTen = txt_input_HoTen.Text;
            NgaySinh = date_input_NgaySinh.Text;
            GioiTinh = cbo_input_GioiTinh.Text;
            SoNha = txt_input_SoNha.Text;
            TenDuong = txt_input_TenDuong.Text;
            QuanHuyen = txt_input_QuanHuyen.Text;
            TinhThanhPho = txt_input_TinhThanhPho.Text;
            CCCD = txt_input_Cccd.Text;
            Email = txt_input_Email.Text;
            SDT = txt_input_Sdt.Text;
            NgayBatDauLamViec = date_input_NgayBatDau.Text;

        }
        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgv_NhanVien.CurrentRow.Index;

            txt_input_Id.Text = dgv_NhanVien.Rows[d].Cells[0].Value.ToString();
            txt_input_HoTen.Text = dgv_NhanVien.Rows[d].Cells[1].Value.ToString();
            cbo_input_GioiTinh.Text = dgv_NhanVien.Rows[d].Cells[2].Value.ToString();
            date_input_NgaySinh.Text = dgv_NhanVien.Rows[d].Cells[3].Value.ToString();
            txt_input_SoNha.Text = dgv_NhanVien.Rows[d].Cells[4].Value.ToString();
            txt_input_TenDuong.Text = dgv_NhanVien.Rows[d].Cells[5].Value.ToString();
            txt_input_QuanHuyen.Text = dgv_NhanVien.Rows[d].Cells[6].Value.ToString();
            txt_input_TinhThanhPho.Text = dgv_NhanVien.Rows[d].Cells[7].Value.ToString();
            txt_input_Cccd.Text = dgv_NhanVien.Rows[d].Cells[8].Value.ToString();
            txt_input_Email.Text = dgv_NhanVien.Rows[d].Cells[9].Value.ToString();
            txt_input_Sdt.Text = dgv_NhanVien.Rows[d].Cells[10].Value.ToString();
            date_input_NgayBatDau.Text = dgv_NhanVien.Rows[d].Cells[11].Value.ToString();
        }


        private void InitCboData()
        {
            cbo_input_GioiTinh.Items.Clear();
            cbo_input_GioiTinh.Items.Add("Nam");
            cbo_input_GioiTinh.Items.Add("Nữ");
            cbo_input_GioiTinh.Items.Add("Khác");

            cbo_input_GioiTinh.SelectedIndex = 0;
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            hienthiNhanVien();
            InitCboData();
            dgv_NhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btn_ThemNhanVien_Click(object sender, EventArgs e)
        {
            LoadDuLieu();

            try
            {
                DateTime dtNgaySinh = DateTime.Parse(date_input_NgaySinh.Text);
                DateTime dtNgayBatDau = DateTime.Parse(date_input_NgayBatDau.Text);

                string sql = $"INSERT INTO tbNHANVIEN (HoTen, GioiTinh, NgaySinh, SoNha, TenDuong, QuanHuyen, TinhThanhPho, CCCD, Email, SDT, NgayBatDauLamViec) " +
                             $"VALUES (N'{HoTen}', N'{GioiTinh}', '{NgaySinh}', '{SoNha}', N'{TenDuong}', N'{QuanHuyen}', N'{TinhThanhPho}', '{CCCD}', '{Email}', '{SDT}', '{NgayBatDauLamViec}')";

                IDNhanVien = Fxml.InsertOrUpDateSQL(sql).ToString();

                nv.themNV(IDNhanVien, HoTen, GioiTinh, dtNgaySinh.ToString("yyyy-MM-dd"), SoNha, TenDuong, QuanHuyen, TinhThanhPho, CCCD, Email, SDT, dtNgayBatDau.ToString("yyyy-MM-dd"));
                MessageBox.Show("Thêm nhân viên thành công!");
                hienthiNhanVien();
                txt_input_Id.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_SuaNhanVien_Click(object sender, EventArgs e)
        {
            {
                LoadDuLieu();

                if (string.IsNullOrEmpty(IDNhanVien))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime dtNgaySinh = DateTime.Parse(NgaySinh);
                DateTime dtNgayBatDau = DateTime.Parse(NgayBatDauLamViec);

                string sql = $"UPDATE tbNHANVIEN " +
                             $"SET HoTen = N'{HoTen}', " +
                             $"GioiTinh = N'{GioiTinh}', " +
                             $"NgaySinh = '{dtNgaySinh:yyyy-MM-dd}', " +
                             $"SoNha = '{SoNha}', " +
                             $"TenDuong = N'{TenDuong}', " +
                             $"QuanHuyen = N'{QuanHuyen}', " +
                             $"TinhThanhPho = N'{TinhThanhPho}', " +
                             $"CCCD = '{CCCD}', " +
                             $"Email = '{Email}', " +
                             $"SDT = '{SDT}', " +
                             $"NgayBatDauLamViec = '{dtNgayBatDau:yyyy-MM-dd}' " +
                             $"WHERE IDNhanVien = '{IDNhanVien}'";

                Fxml.InsertOrUpDateSQL(sql);

                nv.suaNV(txt_input_Id.Text, txt_input_HoTen.Text, cbo_input_GioiTinh.Text, dtNgaySinh.ToString("dd-MM-yyyy"), txt_input_SoNha.Text, txt_input_TenDuong.Text, txt_input_QuanHuyen.Text, txt_input_TinhThanhPho.Text, txt_input_Cccd.Text, txt_input_Email.Text, txt_input_Sdt.Text, dtNgayBatDau.ToString("dd-MM-yyyy"));
                MessageBox.Show("Cập nhật nhân viên thành công!");
                hienthiNhanVien();
            }

        }

        private void btn_XoaNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_input_Id.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    nv.xoaNV(txt_input_Id.Text);
                    string sql = $"DELETE FROM tbNHANVIEN WHERE IDNhanVien = '{txt_input_Id.Text}'";
                    Fxml.InsertOrUpDateSQL(sql).ToString();
                    MessageBox.Show("Xóa nhân viên thành công!");

                    hienthiNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SanPham_Click(object sender, EventArgs e)
        {
            Form1 quanLySp = new Form1();
            quanLySp.Show();
            this.Hide();
        }

        private void KhachHang_Click(object sender, EventArgs e)
        {
            FormQuanLyKhachHang quanLyKh = new FormQuanLyKhachHang();
            quanLyKh.Show();
            this.Hide();
        }


    }
}
