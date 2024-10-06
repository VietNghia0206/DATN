﻿using PhanMemQuanLyKhoThietBi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhoThietBi.Controllers
{
    public class DangNhapControllers
    {
        public DataTable DangNhap(string manv, string matkhau)
        {
            string Query = "select * from nhanvien where manv='" + manv + "' and matkhau='" + matkhau + "'";
            return ConnectSQL.Load(Query);
        }
        public DataTable TenTK(string manv)
        {
            string Query = "select tennv from nhanvien where manv='" + manv + "'";
            return ConnectSQL.Load(Query);
        }
        public DataTable HienThi(string tennv)
        {
            string Query = "select manv,tennv,MatKhau,DienThoai,DiaChi from nhanvien WHERE tennv LIKE N'%" + tennv + "%'";
            return ConnectSQL.Load(Query);
        }
        public void Them(string manv, string tennv, string matkhau, string DienThoai, string DiaChi)
        {
            string Query = "INSERT INTO nhanvien(manv,tennv,matkhau,DienThoai,DiaChi)  VALUES ( '" + manv + "',N'" + tennv + "',N'" + matkhau + "','" + DienThoai + "',N'" + DiaChi + "')";
            ConnectSQL.ExecuteNonQuery(Query);
        }
        public void Sua(string manv, string tennv, string matkhau, string DienThoai, string DiaChi)
        {
            string Query = "UPDATE nhanvien SET manv = '" + manv + "',tennv=N'" + tennv + "',matkhau = N'" + matkhau + "',DienThoai='" + DienThoai + "',DiaChi =N'" + DiaChi + "' WHERE manv = '" + manv + "'";
            ConnectSQL.ExecuteNonQuery(Query);
        }
        public void Xoa(string manv)
        {
            string Query = string.Format(@"DELETE nhanvien WHERE manv = '" + manv + "'");
            ConnectSQL.ExecuteNonQuery(Query);
        }
        public int CheckExits(string manv)
        {
            int i = 0;
            string Querys = "SELECT * FROM nhanvien WHERE manv = '" + manv + "'";
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
    }
}
