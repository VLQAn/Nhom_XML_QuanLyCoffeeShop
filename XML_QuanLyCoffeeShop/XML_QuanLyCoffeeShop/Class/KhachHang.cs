using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML_QuanLyCoffeeShop.Class
{
    class KhachHang
    {
        FileXml Fxml = new FileXml();
        public void themKH(string IDKhachHang,  string HoTen, string NgaySinh, string GioiTinh, string CCCD, string SDT, string DiaChi)
        {
            string noiDung = "<KhachHang>" +
                     "<IDKhachHang>" + IDKhachHang + "</IDKhachHang>" +
                     "<HoTen>" + HoTen + "</HoTen>" +
                     "<NgaySinh>" + NgaySinh + "</NgaySinh>" +
                     "<GioiTinh>" + GioiTinh + "</GioiTinh>" +
                     "<CCCD>" + CCCD + "</CCCD>" +
                     "<SDT>" + SDT + "</SDT>" +
                     "<DiaChi>" + DiaChi + "</DiaChi>" +
                     "</KhachHang>";

            Fxml.Them("KhachHang.xml", noiDung);
        }
        public void suaKH(string IDKhachHang, string HoTen, string NgaySinh, string GioiTinh, string CCCD, string SDT, string DiaChi)
        {

            string noiDung =
                   "<IDKhachHang>" + IDKhachHang + "</IDKhachHang>" +
                   "<HoTen>" + HoTen + "</HoTen>" +
                   "<NgaySinh>" + NgaySinh + "</NgaySinh>" +
                   "<GioiTinh>" + GioiTinh + "</GioiTinh>" +
                   "<CCCD>" + CCCD + "</CCCD>" +
                   "<SDT>" + SDT + "</SDT>" +
                   "<DiaChi>" + DiaChi + "</DiaChi>";

            Fxml.Sua("KhachHang.xml", "KhachHang", "IDKhachHang", IDKhachHang, noiDung);

        }
        public void xoaKH(string IDKhachHang)
        {
            Fxml.Xoa("KhachHang.xml", "KhachHang", "IDKhachHang", IDKhachHang);
        }
    }
}
