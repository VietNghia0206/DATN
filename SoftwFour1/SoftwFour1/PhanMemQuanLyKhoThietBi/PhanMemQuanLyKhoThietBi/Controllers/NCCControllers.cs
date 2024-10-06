using PhanMemQuanLyKhoThietBi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhoThietBi.Controllers
{
    public class NCCControllers
    {
        public DataTable HienThi(string TenNCC)
        {
            string Query = "select * from NhaCungCap WHERE TenNCC LIKE N'%" + TenNCC + "%' and MaNCC NOT LIKE ''";
            return ConnectSQL.Load(Query);
        }

        public DataTable HienThiX(string TenNCC)
        {
            string Query = "select * from NhaCungCap WHERE TenNCC LIKE N'%" + TenNCC + "%'";
            return ConnectSQL.Load(Query);
        }

        public void Them(string MaNCC, string TenNCC, string DienThoai, string DiaChi)
        {
            if (CheckExits(MaNCC) == 1)
            {
                throw new Exception("Mã nhà cung cấp đã tồn tại.");
            }

            string query = "INSERT INTO NhaCungCap (MaNCC, TenNCC, DienThoai, DiaChi) " +
                           "VALUES ('" + MaNCC + "', N'" + TenNCC + "', '" + DienThoai + "', N'" + DiaChi + "')";
            ConnectSQL.ExecuteNonQuery(query);
        }

        public void Sua(string MaNCC, string TenNCC, string DienThoai, string DiaChi)
        {
            string Query = "UPDATE NhaCungCap SET MaNCC = '" + MaNCC + "',TenNCC=N'" + TenNCC + "',DienThoai='" + DienThoai + "',DiaChi =N'" + DiaChi + "' WHERE MaNCC = '" + MaNCC + "'";
            ConnectSQL.ExecuteNonQuery(Query);
        }
        public void Xoa(string MaNCC)
        {
            string query = "DELETE FROM NhaCungCap WHERE MaNCC = '" + MaNCC + "'";
            ConnectSQL.ExecuteNonQuery(query);
        }

        public int CheckExits(string MaNCC)
        {
            string query = "SELECT COUNT(*) FROM NhaCungCap WHERE MaNCC = '" + MaNCC + "'";
            DataTable dt = ConnectSQL.Load(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return count > 0 ? 1 : 0;
        }

    }
}
