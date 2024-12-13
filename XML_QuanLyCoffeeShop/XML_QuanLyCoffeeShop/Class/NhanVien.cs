using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace XML_QuanLyCoffeeShop.Class
{
    class NhanVien
    {
        FileXml Fxml = new FileXml();
      
        public void themNV(string IDNhanVien, string HoTen, string GioiTinh, string NgaySinh, string SoNha, string TenDuong, string QuanHuyen, string TinhThanhPho, string CCCD, string Email, string SDT, string NgayBatDauLamViec)
        {
            string noiDung = "<NhanVien>" +
                    "<IDNhanVien>" + IDNhanVien + "</IDNhanVien>" +
                    "<HoTen>" + HoTen + "</HoTen>" +
                    "<GioiTinh>" + GioiTinh + "</GioiTinh>" +
                    "<NgaySinh>" + NgaySinh + "</NgaySinh>" +
                    "<SoNha>" + SoNha + "</SoNha>" +
                    "<TenDuong>" + TenDuong + "</TenDuong>" +
                    "<QuanHuyen>" + QuanHuyen + "</QuanHuyen>" +
                    "<TinhThanhPho>" + TinhThanhPho + "</TinhThanhPho>" +
                    "<CCCD>" + CCCD + "</CCCD>" +
                    "<Email>" + Email + "</Email>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<NgayBatDauLamViec>" + NgayBatDauLamViec + "</NgayBatDauLamViec>" +
                    "</NhanVien>";

            Fxml.Them("NhanVien.xml", noiDung);

        }

        public void suaNV(string IDNhanVien, string HoTen, string GioiTinh, string NgaySinh, string SoNha, string TenDuong, string QuanHuyen, string TinhThanhPho, string CCCD, string Email, string SDT, string NgayBatDauLamViec)
        {
            string noiDung =
                     "<IDNhanVien>" + IDNhanVien + "</IDNhanVien>" +
                     "<HoTen>" + HoTen + "</HoTen>" +
                     "<GioiTinh>" + GioiTinh + "</GioiTinh>" +
                     "<NgaySinh>" + NgaySinh + "</NgaySinh>" +
                     "<SoNha>" + SoNha + "</SoNha>" +
                     "<TenDuong>" + TenDuong + "</TenDuong>" +
                     "<QuanHuyen>" + QuanHuyen + "</QuanHuyen>" +
                     "<TinhThanhPho>" + TinhThanhPho + "</TinhThanhPho>" +
                     "<CCCD>" + CCCD + "</CCCD>" +
                     "<Email>" + Email + "</Email>" +
                     "<SDT>" + SDT + "</SDT>" +
                     "<NgayBatDauLamViec>" + NgayBatDauLamViec + "</NgayBatDauLamViec>";

            Fxml.Sua("NhanVien.xml", "NhanVien", "IDNhanVien", IDNhanVien, noiDung);
        }

        public void xoaNV(string IDNhanVien)
        {
            Fxml.Xoa("NhanVien.xml", "NhanVien", "IDNhanVien", IDNhanVien);
        }

    }
}
