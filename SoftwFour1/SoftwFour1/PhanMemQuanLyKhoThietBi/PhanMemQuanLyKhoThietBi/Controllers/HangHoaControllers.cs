using PhanMemQuanLyKhoThietBi.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PhanMemQuanLyKhoThietBi.Controllers
{
    public class HangHoaControllers
    {
        public DataTable HienThi(string TenHH)
        {
            string Query = "SELECT MaHH,TenHH,MaLHH,MaNCC,DonVi,TonKho,DonGia,GiaXuat,AnhHH FROM HangHoa WHERE TenHH LIKE N'%" + TenHH + "%'";
            return ConnectSQL.Load(Query);
        }

        public DataTable HienThiX(string TenHH, string MaLHH, string MaNCC)
        {
            string Query = "SELECT MaHH,TenHH,MaLHH,MaNCC,DonVi,TonKho,DonGia,GiaXuat,AnhHH FROM HangHoa WHERE TenHH LIKE N'%" + TenHH + "%' and MaLHH LIKE N'%" + MaLHH + "%' and MaNCC Like N'%" + MaNCC + "%'  ";
            return ConnectSQL.Load(Query);
        }

        public DataTable ShowDB()
        {
            string Query = "SELECT MaHH,TenHH,MaLHH,MaNCC,DonVi,TonKho,DonGia,GiaXuat,AnhHH FROM HangHoa ";
            return ConnectSQL.Load(Query);
        }

        public DataTable HienThiHangHoaXuatKho(string TenHH)
        {
            string sqlString = "SELECT MaHH, TenHH, MaLHH, TonKho, GiaXuat, MaNCC FROM HangHoa WHERE TenHH LIKE N'%" + TenHH + "%'";
            return ConnectSQL.Load(sqlString);
        }

        public DataTable SearchHangHoaXuatKho(string TenHH, string MaLHH, string MaNCC)
        {
            string sqlString = "SELECT MaHH, TenHH, MaLHH, TonKho, GiaXuat, MaNCC FROM HangHoa WHERE TenHH LIKE N'%" + TenHH + "%' and MaLHH LIKE N'%" + MaLHH + "%' and MaNCC Like N'%" + MaNCC + "%'  ";
            return ConnectSQL.Load(sqlString);
        }


        public DataTable HienThiHangHoaNhapKho(string TenHH, string MaNCC)
        {
            string sqlString = "SELECT MaHH, TenHH, MaLHH, TonKho, DonGia, MaNCC FROM HangHoa WHERE TenHH LIKE N'%" + TenHH + "%' AND MaNCC like N'%" + MaNCC + "'";
            return ConnectSQL.Load(sqlString);
        }

        public void Them(string MaHH, string TenHH, decimal TonKho, decimal DonGia, string MaLHH, string MaNCC, decimal GiaXuat, byte[] AnhHH,string DonVi)
        {
            string Query = "INSERT INTO HangHoa (MaHH, TenHH, TonKho, DonGia, MaLHH, DonVi, MaNCC, GiaXuat, AnhHH) " +
                           "VALUES (@MaHH, @TenHH, @TonKho, @DonGia, @MaLHH, @DonVi, @MaNCC, @GiaXuat, @AnhHH)";

            using (SqlConnection connection = new SqlConnection(ConnectSQL.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@MaHH", MaHH);
                command.Parameters.AddWithValue("@TenHH", TenHH);
                command.Parameters.AddWithValue("@TonKho", TonKho);
                command.Parameters.AddWithValue("@DonGia", DonGia);
                command.Parameters.AddWithValue("@MaLHH", MaLHH);
                command.Parameters.AddWithValue("@DonVi", DonVi);
                command.Parameters.AddWithValue("@MaNCC", MaNCC);
                command.Parameters.AddWithValue("@GiaXuat", GiaXuat);
                command.Parameters.AddWithValue("@AnhHH", (object)AnhHH ?? DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Sua(string MaHH, string TenHH, decimal TonKho, decimal DonGia, string MaLHH, string MaNCC, decimal GiaXuat, byte[] AnhHH, string DonVi)
        {
            string Query = "UPDATE HangHoa SET TenHH = @TenHH, TonKho = @TonKho, DonGia = @DonGia, " +
                           "MaLHH = @MaLHH, DonVi=@Donvi , MaNCC = @MaNCC, GiaXuat = @GiaXuat, AnhHH = @AnhHH " +
                           "WHERE MaHH = @MaHH";

            using (SqlConnection connection = new SqlConnection(ConnectSQL.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@MaHH", MaHH);
                command.Parameters.AddWithValue("@TenHH", TenHH);
                command.Parameters.AddWithValue("@TonKho", TonKho);
                command.Parameters.AddWithValue("@DonGia", DonGia);
                command.Parameters.AddWithValue("@MaLHH", MaLHH);
                command.Parameters.AddWithValue("@DonVi", DonVi);
                command.Parameters.AddWithValue("@MaNCC", MaNCC);
                command.Parameters.AddWithValue("@GiaXuat", GiaXuat);
                command.Parameters.AddWithValue("@AnhHH", (object)AnhHH ?? DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }



        public void Xoa(string MaHH)
        {
            string Query = "DELETE FROM HangHoa WHERE MaHH = '" + MaHH + "'";
            ConnectSQL.ExecuteNonQuery(Query);
        }

        public int CheckExits(string MaHH)
        {
            string Query = "SELECT * FROM HangHoa WHERE MaHH = '" + MaHH + "'";
            DataTable dt = ConnectSQL.Load(Query);
            return dt != null && dt.Rows.Count > 0 ? 1 : 0;
        }

        public DataTable LayHangHoaTheoNCC(string maNCC)
        {
            string query = $"SELECT maHH,tenHH,tonkho,dongia,giaxuat FROM HangHoa WHERE MaNCC = '{maNCC}'";
            return ConnectSQL.Load(query); 
        }

        public DataTable LayHangHoaTheoLHH(string maLHH)
        {
            string query = $"SELECT maHH,tenHH,tonkho,dongia,giaxuat FROM HangHoa WHERE MaLHH = '{maLHH}'";
            return ConnectSQL.Load(query);
        }

        public DataTable LayDonGiaXuat(string MaHH)
        {
            string Query = "SELECT GiaXuat FROM HangHoa WHERE MaHH = '" + MaHH + "'";
            return ConnectSQL.Load(Query);
        }

        public DataTable LayDonGia(string MaHH)
        {
            string Query = "SELECT DonGia FROM HangHoa WHERE MaHH = '" + MaHH + "'";
            return ConnectSQL.Load(Query);
        }

        public DataTable ThongKe()
        {
            string Query = "WITH MonthlyData AS (\r\n    SELECT \r\n        YEAR(NgayHD) AS Year,\r\n        MONTH(NgayHD) AS Month,\r\n        SUM(TongTien) AS ChiPhiMua\r\n    FROM NhapKho\r\n    GROUP BY YEAR(NgayHD), MONTH(NgayHD)\r\n),\r\nMonthlySales AS (\r\n    SELECT \r\n        YEAR(NgayBan) AS Year,\r\n        MONTH(NgayBan) AS Month,\r\n        SUM(TongTien) AS DoanhThu\r\n    FROM XuatKho\r\n    GROUP BY YEAR(NgayBan), MONTH(NgayBan)\r\n)\r\nSELECT \r\n    COALESCE(md.Year, ms.Year) AS Year,\r\n    COALESCE(md.Month, ms.Month) AS Month,\r\n    COALESCE(md.ChiPhiMua, 0) AS ChiPhiMua,\r\n    COALESCE(ms.DoanhThu, 0) AS DoanhThu,\r\n    COALESCE(ms.DoanhThu, 0) - COALESCE(md.ChiPhiMua, 0) AS LoiNhuan\r\nFROM MonthlyData md\r\nFULL OUTER JOIN MonthlySales ms ON md.Year = ms.Year AND md.Month = ms.Month\r\nORDER BY Year, Month; ";
            return ConnectSQL.Load(Query);
        }

        public DataTable TimKiemHangHoa(string tenHangHoa)
        {
            string query = "SELECT * FROM HangHoa WHERE TenHH LIKE '%' + @TenHangHoa + '%'";
            object[] parameters = new object[] { tenHangHoa };
            return ConnectSQL.Instance.ExecuteQuery(query, parameters);
        }

    }
}
