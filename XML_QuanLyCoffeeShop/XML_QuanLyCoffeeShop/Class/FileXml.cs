using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Diagnostics;
using System.Drawing;


namespace XML_QuanLyCoffeeShop.Class
{
    class FileXml
    {
        public static string Conn = @"Data Source=PROPERTY;Initial Catalog=dbQUANLYCOFFEESHOP;Integrated Security=True";

        public DataTable HienThi(string file)
        {
            DataTable dt = new DataTable();
            string FilePath = Application.StartupPath + "\\" + file;
            if (File.Exists(FilePath))
            {
                FileStream fsReadXML = new FileStream(FilePath, FileMode.Open);
                dt.ReadXml(fsReadXML);
                fsReadXML.Close();
            }
            else
            {
                //MessageBox.Show("File XML '" + file + "' không tồn tại");

            }

            return dt;
        }
        public void TaoXML(string bang)
        {
            SqlConnection con = new SqlConnection(Conn);
            con.Open();
            string sql = "Select* from " + bang;
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable("'" + bang + "'");
            ad.Fill(dt);
            dt.WriteXml(Application.StartupPath + "\\" + bang + ".xml", XmlWriteMode.WriteSchema);
        }

        public void Them(string duongDan, string noiDung)
        {
            XmlTextReader reader = new XmlTextReader(duongDan);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();
            XmlNode currNode;
            XmlDocumentFragment docFrag = doc.CreateDocumentFragment();
            docFrag.InnerXml = noiDung;
            currNode = doc.DocumentElement;
            currNode.InsertAfter(docFrag, currNode.LastChild);
            doc.Save(duongDan);
        }
        public void Xoa(string duongDan, string tenFileXML, string xoaTheoTruong, string giaTriTruong)
        {
            string fileName = Application.StartupPath + "\\" + duongDan;
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode nodeCu = doc.SelectSingleNode("NewDataSet/" + tenFileXML + "[" + xoaTheoTruong + "='" + giaTriTruong + "']");
            doc.DocumentElement.RemoveChild(nodeCu);
            doc.Save(fileName);
        }

        public void Sua(string duongDan, string tenFile, string suaTheoTruong, string giaTriTruong, string noiDung)
        {

            XmlTextReader reader = new XmlTextReader(duongDan);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();
            XmlNode oldHang;
            XmlElement root = doc.DocumentElement;
            oldHang = root.SelectSingleNode("/NewDataSet/" + tenFile + "[" + suaTheoTruong + "='" + giaTriTruong + "']");
            XmlElement newhang = doc.CreateElement(tenFile);
            newhang.InnerXml = noiDung;
            root.ReplaceChild(newhang, oldHang);
            doc.Save(duongDan);
        }
        public int InsertOrUpDateSQL(string sql)
        {
            int lastID = -1;
            SqlConnection con = new SqlConnection(Conn);
            con.Open();
            if (sql.Contains("INSERT"))
            {
                SqlCommand cmd = new SqlCommand(sql + ";SELECT SCOPE_IDENTITY();", con);
                lastID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            return lastID;

            con.Close();
        }
    }
}
