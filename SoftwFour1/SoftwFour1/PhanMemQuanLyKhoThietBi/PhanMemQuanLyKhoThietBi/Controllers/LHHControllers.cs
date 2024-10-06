using PhanMemQuanLyKhoThietBi.Models;
using System;
using System.Data;

namespace PhanMemQuanLyKhoThietBi.Controllers
{
    public class LHHControllers
    {
        public DataTable HienThi(string TenLHH)
        {
            string Query = "SELECT * FROM LoaiHangHoa WHERE TenLHH LIKE N'%" + TenLHH + "%' and MaLHH NOT LIKE ''";
            return ConnectSQL.Load(Query);
        }

        public DataTable HienThiX(string TenLHH)
        {
            string Query = "SELECT * FROM LoaiHangHoa WHERE TenLHH LIKE N'%" + TenLHH + "%'";
            return ConnectSQL.Load(Query);
        }

        public void Them(string MaLHH, string TenLHH)
        {
            string Query = "INSERT INTO LoaiHangHoa(MaLHH, TenLHH) VALUES ('" + MaLHH + "', N'" + TenLHH + "')";
            ConnectSQL.ExecuteNonQuery(Query);
        }

        public void Sua(string MaLHH, string TenLHH)
        {
            string Query = "UPDATE LoaiHangHoa SET TenLHH = N'" + TenLHH + "' WHERE MaLHH = '" + MaLHH + "'";
            ConnectSQL.ExecuteNonQuery(Query);
        }

        public void Xoa(string MaLHH)
        {
            if (HasRelatedProducts(MaLHH)>0)
            {
                throw new Exception("Không thể xóa loại hàng hóa này vì còn sản phẩm liên quan.");
            }

            string Query = "DELETE FROM LoaiHangHoa WHERE MaLHH = '" + MaLHH + "'";
            ConnectSQL.ExecuteNonQuery(Query);
        }

        public int CheckExits(string MaLHH)
        {
            int i = 0;
            string Query = "SELECT * FROM LoaiHangHoa WHERE MaLHH = '" + MaLHH + "'";
            DataTable dt = ConnectSQL.Load(Query);
            if (dt != null && dt.Rows.Count > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
            return i;
        }

        private int HasRelatedProducts(string MaLHH)
        {
            string Query = "SELECT * FROM HangHoa WHERE MaLHH = '" + MaLHH + "'";
            DataTable dt = ConnectSQL.Load(Query);
            return dt.Rows.Count;
        }
    }
}
