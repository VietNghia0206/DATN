using DevExpress.XtraReports.UI;
using PhanMemQuanLyKhoThietBi.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhoThietBi.Views
{
    public partial class frmTKThang : Form
    {
        private HangHoaControllers _hangHoaController;
        public frmTKThang()
        {
            InitializeComponent();
            _hangHoaController = new HangHoaControllers();
        }

        private void TKThang_Load_1(object sender, EventArgs e)
        {
            ThongKe();
        }

        private void ThongKe()
        {
            try
            {
                DataTable data = _hangHoaController.ThongKe();

                if (data != null && data.Rows.Count > 0)
                {
                    gridviewHangHoa.DataSource = data;

                    gridviewHangHoa.Columns[0].HeaderText = "Năm";
                    gridviewHangHoa.Columns[1].HeaderText = "Tháng";
                    gridviewHangHoa.Columns[2].HeaderText = "Chi phí";
                    gridviewHangHoa.Columns[3].HeaderText = "doanh thu";
                    gridviewHangHoa.Columns[4].HeaderText = "lợi nhuận";

                    int totalWidth = gridviewHangHoa.Width;

                    gridviewHangHoa.Columns[0].Width = (int)(totalWidth * 0.10);
                    gridviewHangHoa.Columns[1].Width = (int)(totalWidth * 0.10);
                    gridviewHangHoa.Columns[2].Width = (int)(totalWidth * 0.25);
                    gridviewHangHoa.Columns[3].Width = (int)(totalWidth * 0.25);
                    gridviewHangHoa.Columns[4].Width = (int)(totalWidth * 0.30);

                    gridviewHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TKM report = new TKM();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }
    }
}
