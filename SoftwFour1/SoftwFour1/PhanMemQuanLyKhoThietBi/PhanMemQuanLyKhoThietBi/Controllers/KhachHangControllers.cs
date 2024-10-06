using DevExpress.Xpo.DB.Helpers;
using PhanMemQuanLyKhoThietBi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhoThietBi.Controllers
{
    public class KhachHangControllers
    {
        public DataTable HienThi(string searchText)
        {
            string query = "SELECT * FROM KhachHang WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                if (searchText.All(char.IsDigit))
                {
                    query += " AND DienThoai LIKE @searchText";
                }
                else if (searchText.Split(' ').Length > 1)
                {
                    query += " AND TenKH LIKE @searchText";
                }
                else
                {
                    query += " AND DiaChi LIKE @searchText";
                }
            }

            return ConnectSQL.Instance.ExecuteQuery(query, new object[] { "%" + searchText + "%" });
        }

        public void Xoa(string MaKH)
        {
            string str = string.Format(@"DELETE KhachHang WHERE MaKH = '" + MaKH + "'");
            ConnectSQL.ExecuteNonQuery(str);
        }
        public void Them(string MaKH, string TenKH, string DienThoai, string DiaChi)
        {
            string str = "INSERT INTO KhachHang(MaKH,TenKH,DienThoai,DiaChi)  VALUES ( '" + MaKH + "',N'" + TenKH + "','" + DienThoai + "',N'" + DiaChi + "')";
            ConnectSQL.ExecuteNonQuery(str);
        }
        public void Sua(string MaKH, string TenKH, string DienThoai, string DiaChi)
        {
            string str = "UPDATE KhachHang SET MaKH = '" + MaKH + "',TenKH=N'" + TenKH + "',DienThoai = N'" + DienThoai + "',DiaChi = N'" + DiaChi + "' WHERE MaKH = '" + MaKH + "'";
            ConnectSQL.ExecuteNonQuery(str);
        }
        public int CheckExits(string MaKH)
        {
            int i = 0;
            string Querys = "SELECT * FROM KhachHang WHERE MaKH = '" + MaKH + "'";
            DataTable dt = ConnectSQL.Load(Querys);
            if (dt != null || dt.Rows.Count > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
            return i;
        }

        public DataTable TimKiem(string MaKH, string TenKH, string DienThoai)
        {
            string Query = "SELECT MaKH, TenKH, DienThoai FROM KhachHang WHERE 1=1 " +
               "AND MaKH LIKE '%" + MaKH + "%' " +
               "AND TenKH LIKE '%" + TenKH + "%' " +
               "AND DienThoai LIKE '%" + DienThoai + "%'";

            DataTable result = ConnectSQL.Load(Query);

            //foreach (DataColumn column in result.Columns)
            //{
            //    MessageBox.Show(column.ColumnName);
            //}

            return result;
        }
    }
}
