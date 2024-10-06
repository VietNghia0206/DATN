using PhanMemQuanLyKhoThietBi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhoThietBi.Controllers
{
    public class BCTonKhoControllers
    {
        public DataTable HienThi()
        {
            string Query = "SELECT a.MaHH,a.TenHH,a.MaNCC,c.TenNCC,a.MaLHH,b.TenLHH, a.DonVi,DonGia,GiaXuat,TonKho FROM HangHoa a INNER JOIN LoaiHangHoa b ON a.MaLHH = b.MaLHH INNER JOIN NhaCungCap c ON a.MaNCC = c.MaNCC";
            return ConnectSQL.Load(Query);
        }

        public DataTable Search(string MaHH, string TenHH, string TenNCC, string TenLHH, int TonKho, int TonKho1, int DonGia, int DonGia1, int GiaXuat, int GiaXuat1)
        {
            string Query = "SELECT a.MaHH,a.TenHH,a.MaNCC,c.TenNCC,a.MaLHH,b.TenLHH, a.DonVi,DonGia,GiaXuat,TonKho FROM HangHoa a INNER JOIN LoaiHangHoa b ON a.MaLHH = b.MaLHH INNER JOIN NhaCungCap c ON a.MaNCC = c.MaNCC  WHERE a.MaHH LIKE N'%" + MaHH + "%' ";
            Query += " AND a.TenHH LIKE N'%" + TenHH + "%' AND c.MaNCC LIKE N'%" + TenNCC + "%' AND b.MaLHH LIKE N'%" + TenLHH + "%'";
            Query += " AND DonGia > " + DonGia + " " +
                " And DonGia < " + DonGia1 +
                " AND TonKho >" + TonKho +
                " AND TonKho < " + TonKho1 +
                " And GiaXuat > " + GiaXuat +
                " AND GiaXuat <" + GiaXuat1 + "";
            return ConnectSQL.Load(Query);
        }

        public DataTable Warn()
        {
            string query = @"
                SELECT 
                    a.MaHH,
                    a.TenHH,
                    a.MaNCC,
                    c.TenNCC,
                    a.MaLHH,
                    b.TenLHH,
                    a.DonVi,
                    a.DonGia,
                    a.GiaXuat,
                    a.TonKho 
                FROM 
                    HangHoa a 
                INNER JOIN 
                    LoaiHangHoa b ON a.MaLHH = b.MaLHH 
                INNER JOIN 
                    NhaCungCap c ON a.MaNCC = c.MaNCC
                WHERE 
                    (a.TonKho < 500 AND a.DonVi = 'M') OR 
                    (a.TonKho < 20 AND a.DonVi = 'Cái') OR 
                    (a.TonKho < 30 AND a.DonVi <> 'M' AND a.DonVi <> 'Cái');";
            return ConnectSQL.Load(query);
        }

    }
}
