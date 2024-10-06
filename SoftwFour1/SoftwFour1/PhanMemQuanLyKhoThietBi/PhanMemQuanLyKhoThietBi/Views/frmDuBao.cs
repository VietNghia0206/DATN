using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DevExpress.XtraReports.UI;
using PhanMemQuanLyKhoThietBi.Models;  

namespace PhanMemQuanLyKhoThietBi.Views
{
    public partial class frmDuBao : Form
    {
        public frmDuBao()
        {
            InitializeComponent();
            LoadDuBaoNhuCau();
            LoadKHTiemNang();
            LoadCanTakeCare();
           
            //LoadDuBaoTangTruong();
        }



        //private void LoadDuBaoTangTruong()
        //{
        //    string query = @"
        //        WITH MonthlyRevenue AS (
        //            SELECT 
        //                DATEPART(MONTH, NgayBan) AS Month,
        //                SUM(TongTien) AS Revenue
        //            FROM XuatKho
        //            WHERE YEAR(NgayBan) = YEAR(GETDATE())
        //            GROUP BY DATEPART(MONTH, NgayBan)
        //        )
        //        SELECT 
        //            M.Month,
        //            ISNULL(R.Revenue, 0) AS Revenue
        //        FROM (VALUES 
        //            (1), (2), (3), (4), (5), (6), (7), (8), (9), (10), (11), (12)
        //        ) M(Month)
        //        LEFT JOIN MonthlyRevenue R ON M.Month = R.Month
        //        ORDER BY M.Month
        //    ";

        //    DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
        //    DataTable resultTable = new DataTable();
        //    resultTable.Columns.Add("Tháng", typeof(string));
        //    resultTable.Columns.Add("Dự báo doanh thu", typeof(int));
        //    resultTable.Columns.Add("Dự báo doanh thu tăng trưởng", typeof(int));
        //    resultTable.Columns.Add("% tăng trưởng", typeof(decimal));

        //    decimal previousMonthRevenue = 0;
        //    decimal forecastGrowth = 0;

        //    for (int i = 0; i < 12; i++)
        //    {
        //        string month = (i + 1).ToString();
        //        decimal revenue = 0;

        //        DataRow[] rows = dt.Select($"Month = {month}");
        //        if (rows.Length > 0)
        //        {
        //            revenue = Convert.ToDecimal(rows[0]["Revenue"]);
        //            if (revenue > 0 && i > 0)
        //            {
        //                forecastGrowth = revenue - previousMonthRevenue;
        //            }
        //        }
        //        else
        //        {
        //            revenue = previousMonthRevenue + forecastGrowth;
        //        }

        //        decimal forecastRevenue = revenue + forecastGrowth;
        //        decimal growthPercent = (previousMonthRevenue == 0) ? 0 : (forecastGrowth / previousMonthRevenue) * 100;

        //        resultTable.Rows.Add(
        //            "Tháng " + month,
        //            (int)Math.Round(revenue),
        //            (int)Math.Round(forecastGrowth),
        //            Math.Round(growthPercent, 2)
        //        );

        //        previousMonthRevenue = revenue;
        //    }

        //    dgvDuBaoTangTruong.DataSource = resultTable;

        //}

        private void LoadCanTakeCare()
        {
            string queryLowRevenueCustomers = @"
                SELECT TOP 10
                    kh.TenKH AS TenKhachHang,
                    ISNULL(SUM(xk.TongTien), 0) AS DoanhSo
                FROM KhachHang kh
                LEFT JOIN XuatKho xk ON kh.MaKH = xk.MaKH
                GROUP BY kh.TenKH
                ORDER BY DoanhSo ASC
            ";

            DataTable dtLowRevenueCustomers = ConnectSQL.Instance.ExecuteQuery(queryLowRevenueCustomers);
            dgvCanTakecare.DataSource = dtLowRevenueCustomers;

            dgvCanTakecare.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dgvCanTakecare.Columns["DoanhSo"].HeaderText = "Chi tiêu";

        }

        private void LoadKHTiemNang()
        {
            string queryTopCustomers = @"
                SELECT 
                    kh.TenKH AS TenKhachHang,
                    SUM(xk.TongTien) AS DoanhSo
                FROM XuatKho xk
                INNER JOIN KhachHang kh ON xk.MaKH = kh.MaKH
                GROUP BY kh.TenKH
                ORDER BY DoanhSo DESC
            ";

            DataTable dtTopCustomers = ConnectSQL.Instance.ExecuteQuery(queryTopCustomers);
            dgvKHTiemNang.DataSource = dtTopCustomers;

            dgvKHTiemNang.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dgvKHTiemNang.Columns["DoanhSo"].HeaderText = "Chi tiêu";

        }

        private void LoadDuBaoNhuCau()
        {
            try
            {
                string query = @"
                    SELECT TOP 10 HangHoa.MaHH, HangHoa.TenHH, SUM(ChiTietXuatKho.SoLuong) AS TongSoLuongBan
                    FROM ChiTietXuatKho
                    INNER JOIN HangHoa ON ChiTietXuatKho.MaHH = HangHoa.MaHH
                    GROUP BY HangHoa.MaHH, HangHoa.TenHH
                    ORDER BY TongSoLuongBan DESC";

                DataTable dt = ConnectSQL.Load(query);

                dgvBanChay.DataSource = dt;

                chartDuBaoNhuCau.Series.Clear();
                chartDuBaoNhuCau.Titles.Clear();

                Series series = new Series
                {
                    Name = "NhuCau",
                    ChartType = SeriesChartType.Pie
                };

                chartDuBaoNhuCau.Series.Add(series);

                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(row["TenHH"].ToString(), row["TongSoLuongBan"]);
                }

                chartDuBaoNhuCau.Series["NhuCau"]["PieLabelStyle"] = "Outside";  

                chartDuBaoNhuCau.Legends.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu dự báo nhu cầu: " + ex.Message);
            }
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            XRpTonKhoIt report = new XRpTonKhoIt();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            RpTop10 report = new RpTop10();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        } 
    }
}
