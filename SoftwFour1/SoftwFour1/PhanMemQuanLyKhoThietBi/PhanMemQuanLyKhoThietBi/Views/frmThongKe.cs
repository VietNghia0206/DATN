
using DevExpress.XtraReports.UI;
using PhanMemQuanLyKhoThietBi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyKhoThietBi.Views
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    h.MaHH AS [Mã hàng hóa],
                    h.TenHH AS [Tên hàng hóa],
                    ISNULL(SUM(cn.SoLuong), 0) AS [Số Lượng Nhập],
                    ISNULL(SUM(cx.SoLuong), 0) AS [Số Lượng Xuất],
                    ISNULL(SUM(cn.ThanhTien), 0) AS [Chi Phí],
                    ISNULL(SUM(cx.ThanhTien), 0) AS [Doanh Thu],
                    ISNULL(SUM(cx.ThanhTien), 0) - ISNULL(SUM(cn.ThanhTien), 0) AS [Lợi Nhuận]
                FROM HangHoa h
                LEFT JOIN ChiTietNhapKho cn ON h.MaHH = cn.MaHH AND cn.MaHD IN (
                    SELECT MaHD FROM NhapKho WHERE NgayHD BETWEEN @NgayHD1 AND @NgayHD2
                )
                LEFT JOIN ChiTietXuatKho cx ON h.MaHH = cx.MaHH AND cx.MaHD IN (
                    SELECT MaHD FROM XuatKho WHERE NgayBan BETWEEN @NgayHD1 AND @NgayHD2
                )
                GROUP BY h.MaHH, h.TenHH";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@NgayHD1", dtNgayHD1.Value },
                    { "@NgayHD2", dtNgayHD2.Value }
                };

            DataTable dt = ConnectSQL.Instance.ExecuteQueryNew(query, parameters);

            dtGVThongKe.DataSource = dt;

            dtGVThongKe.Columns["Mã hàng hóa"].Width = 100;
            dtGVThongKe.Columns["Tên hàng hóa"].Width = 200;
            dtGVThongKe.Columns["Số Lượng Nhập"].Width = 120;
            dtGVThongKe.Columns["Số Lượng Xuất"].Width = 120;
            dtGVThongKe.Columns["Chi Phí"].Width = 120;
            dtGVThongKe.Columns["Doanh Thu"].Width = 120;
            dtGVThongKe.Columns["Lợi Nhuận"].Width = 120;

            decimal tongNhap = 0, tongXuat = 0, tongChiPhi = 0, tongDoanhThu = 0, tongLoiNhuan = 0;

            foreach (DataRow row in dt.Rows)
            {
                tongNhap += Convert.ToDecimal(row["Số Lượng Nhập"]);
                tongXuat += Convert.ToDecimal(row["Số Lượng Xuất"]);
                tongChiPhi += Convert.ToDecimal(row["Chi Phí"]);
                tongDoanhThu += Convert.ToDecimal(row["Doanh Thu"]);
                tongLoiNhuan += Convert.ToDecimal(row["Lợi Nhuận"]);
            }

            lblTongNhap.Text = $"{tongNhap:N0}";
            lblTongXuat.Text = $"{tongXuat:N0}";
            lblTongChiPhi.Text = $"{tongChiPhi:N0}";
            lblTongDoanhThu.Text = $"{tongDoanhThu:N0}";
            lblTongLoiNhuan.Text = $"{tongLoiNhuan:N0}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XRpThongKe report = new XRpThongKe();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
