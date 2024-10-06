using DevExpress.CodeParser;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Xpo.DB.Helpers;
using PhanMemQuanLyKhoThietBi.Models;
using PhanMemQuanLyKhoThietBi.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhoThietBi.Controllers
{
    public class NhapKhoControllers
    {
        public DataTable HienThiNhapKho(string NgayHD, string NgayHD2)
        {
            string Query = "select MaHD,NgayHD,a.mancc,c.tenncc,a.manv,b.tennv,TongTien,trangthai FROM NhapKho a INNER JOIN nhanvien b ON a.manv = b.manv INNER JOIN NhaCungCap c ON a.mancc = c.mancc WHERE CONVERT(varchar,NgayHD,112) BETWEEN '" + NgayHD + "' AND '" + NgayHD2 + "'";
            return ConnectSQL.Load(Query);
        }
        public DataTable HienThiChiTietNhapKho(string MaHD)
        {
            string Query = "select a.MaHD,a.MaHH,b.tenhh,a.DonGia,a.SoLuong,a.ThanhTien from ChiTietNhapKho a INNER JOIN HangHoa b ON a.MaHH = b.MaHH WHERE a.MaHD = '" + MaHD + "'";
            return ConnectSQL.Load(Query);
        }
        public void ThemNhapKho(string MaHD, string mancc, string NgayHD, string manv, decimal TongTien)
        {
            string Query = "INSERT INTO NhapKho(MaHD,mancc,NgayHD,manv,TongTien,trangthai)  VALUES ( '" + MaHD + "','" + mancc + "','" + NgayHD + "','" + manv + "'," + TongTien + ",N'Chưa thanh toán')";
            ConnectSQL.ExecuteNonQuery(Query);
        }

        public void ThemChiTietNhapKho(string MaHD, string MaHH, decimal SoLuong, decimal ThanhTien)
        {
            string QueryGetDonGia = "SELECT DonGia FROM HangHoa WHERE MaHH = '" + MaHH + "'";
            DataTable dt = ConnectSQL.Load(QueryGetDonGia);
            decimal DonGia = 0;  // Đổi tên biến để tránh trùng lặp
            if (dt.Rows.Count > 0)
            {
                DonGia = decimal.Parse(dt.Rows[0]["DonGia"].ToString());
            }

            string Query = "INSERT INTO ChiTietNhapKho(MaHD, MaHH, DonGia, SoLuong, ThanhTien) VALUES ('" + MaHD + "', '" + MaHH + "', " + DonGia + ", " + SoLuong + ", " + ThanhTien + ")";
            ConnectSQL.ExecuteNonQuery(Query);
        }
        public void SuaNhapKho(string MaHD, string mancc, string NgayHD, string manv, decimal TongTien)
        {
            string Query = "UPDATE NhapKho SET mancc = '" + mancc + "', NgayHD = '" + NgayHD + "',manv='" + manv + "',TongTien =" + TongTien + " WHERE MaHD='" + MaHD + "'";
            ConnectSQL.ExecuteNonQuery(Query);
        }
        public void Xoa(string MaHD)
        {
            string Query = string.Format(@"DELETE ChiTietNhapKho WHERE MaHD = '" + MaHD + "'");
            Query += string.Format(@"DELETE NhapKho WHERE MaHD = '" + MaHD + "'");
            ConnectSQL.ExecuteNonQuery(Query);
        }
        public void XoaChiTietNhapKho(string MaHD, string MaHH)
        {
            string Query = string.Format(@"DELETE ChiTietNhapKho WHERE MaHD = '" + MaHD + "' AND MaHH = '" + MaHH + "'");
            ConnectSQL.ExecuteNonQuery(Query);
        }

        public void DoiNCC(string MaHD)
        {
            string Query = string.Format(@"DELETE ChiTietNhapKho WHERE MaHD = '" + MaHD + "'");
            ConnectSQL.ExecuteNonQuery(Query);
        }

        public void XoaNhapKhoKhongTonTaiTrongChiTietNhapKho()
        {
            string s = "DELETE NhapKho WHERE MaHD NOT IN (SELECT MaHD From ChiTietNhapKho)";
            ConnectSQL.ExecuteNonQuery(s);
        }
        public void UpdateTonKho(decimal soluong, string MaHH)
        {
            string s = "UPDATE HangHoa SET TonKho =  TonKho + " + soluong + " WHERE MaHH = '" + MaHH + "'";
            ConnectSQL.ExecuteNonQuery(s);
        }
        public void UpdateTrangThaiSauThanhToan(string MaHD)
        {
            string s = "UPDATE NhapKho SET trangthai =  N'Đã thanh toán' WHERE MaHD = '" + MaHD + "'";
            ConnectSQL.ExecuteNonQuery(s);
        }
        public void UpdateTongTien(string MaHD)
        {
            string Query = "UPDATE NhapKho SET TongTien = ISNULL((SELECT SUM(ThanhTien) FROM ChiTietNhapKho WHERE MaHD = '" + MaHD + "'), 0) WHERE MaHD = '" + MaHD + "'; ";
            ConnectSQL.ExecuteNonQuery(Query);
        }

        public void CapNhatSoLuongTienChiTietNhapKho(string MaHD, string MaHH, decimal SoLuong)
        {
            string QueryGetDonGia = "SELECT DonGia FROM HangHoa WHERE MaHH = '" + MaHH + "'";
            DataTable dt = ConnectSQL.Load(QueryGetDonGia);
            decimal DonGia = 0;
            if (dt.Rows.Count > 0)
            {
                DonGia = decimal.Parse(dt.Rows[0]["DonGia"].ToString());
            }

            string sqlUpdate = "UPDATE ChiTietNhapKho SET SoLuong = SoLuong + " + SoLuong + " WHERE MaHD = '" + MaHD + "' AND MaHH = '" + MaHH + "'";
            sqlUpdate += " UPDATE ChiTietNhapKho SET ThanhTien = SoLuong * " + DonGia + " WHERE MaHD = '" + MaHD + "' AND MaHH = '" + MaHH + "'";
            ConnectSQL.ExecuteNonQuery(sqlUpdate);
        }

        public decimal KiemTraHangHoaTonKho(string mahd, string MaHH)
        {
            decimal i = 0;
            string Querys = "  DECLARE @x INT, @x1 INT,@x2 INT";
            Querys += "  SET @x1 = (SELECT TonKho FROM HangHoa WHERE MaHH = '" + MaHH + "')";
            Querys += "  SET @x2 = (SELECT SoLuong FROM ChiTietNhapKho WHERE mahd = '" + mahd + "' AND MaHH = '" + MaHH + "')";
            Querys += " IF @x1 IS NULL SET @x1 = 0";
            Querys += "  IF @x2 IS NULL SET @x2 = 0";
            Querys += " SET @x = @x1 - @x2";
            Querys += "  SELECT @x as x";
            DataTable dt = ConnectSQL.Load(Querys);
            if (dt.Rows.Count > 0)
            {
                i = decimal.Parse(dt.Rows[0][0].ToString());
            }
            return i;
        }
        public int CheckExits(string MaHD, string MaHH)
        {
            int i = 0;
            string s = "SELECT * FROM ChiTietNhapKho WHERE MaHD = '" + MaHD + "' AND MaHH = '" + MaHH + "'";
            DataTable dt = ConnectSQL.Load(s);
            if (dt == null || dt.Rows.Count > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
            return i;
        }
        public int CheckExitsNhapKho(string MaHD)
        {
            int i = 0;
            string s = "SELECT * FROM NhapKho WHERE MaHD = '" + MaHD + "'";
            DataTable dt = ConnectSQL.Load(s);
            if (dt == null || dt.Rows.Count > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
            return i;
        }

        public DataTable GetChiTietNhapKhoForReport(string MaHD)
        {
            string query = "EXEC sp_GetChiTietNhapKho @MaHD";
            object[] parameters = new object[] { MaHD };
            return ConnectSQL.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable GetNhapKhoForReport(DateTime NgayHD1, DateTime NgayHD2)
        {
            string query = "EXEC GetHangHoaReport @NgayHD1 DATETIME, @NgayHD2";
            object[] parameters = new object[] { NgayHD1, NgayHD2 };
            return ConnectSQL.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable GetHoaDonNhapKhoForReport(DateTime dtNgayHD1, DateTime dtNgayHD2)
        {
            string query = "EXEC sp_NhapKho @dtNgayHD1 DATETIME, @dtNgayHD2";
            object[] parameters = new object[] { dtNgayHD1, dtNgayHD2 };
            return ConnectSQL.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable LayDonGia(string MaHH)
        {
            string Query = "SELECT DonGia FROM HangHoa WHERE MaHH = '" + MaHH + "'";
            return ConnectSQL.Load(Query);
        }

    }
}
