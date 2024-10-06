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

using System.Windows.Forms;
using PhanMemQuanLyKhoThietBi.Controllers;

namespace PhanMemQuanLyKhoThietBi.Views
{
    public partial class HHLHH : Form
    {
            
        private string _maLHH;
        private HangHoaControllers _hangHoaController;
        public HHLHH(string maLHH)
        {
            InitializeComponent();
            _maLHH = maLHH;
            _hangHoaController = new HangHoaControllers();
        }

        public void HHLHH_Load_1(object sender, EventArgs e)
        {
            HienThiHangHoaTheoLHH();
        }

        private void HienThiHangHoaTheoLHH()
        {
            try
            {
                DataTable data = _hangHoaController.LayHangHoaTheoLHH(_maLHH);

                if (data != null && data.Rows.Count > 0)
                {
                    gridviewHangHoa.DataSource = data;

                    gridviewHangHoa.Columns[0].HeaderText = "Mã hàng hóa";
                    gridviewHangHoa.Columns[1].HeaderText = "Tên hàng hóa";
                    gridviewHangHoa.Columns[2].HeaderText = "Số lượng";
                    gridviewHangHoa.Columns[3].HeaderText = "Giá nhập";
                    gridviewHangHoa.Columns[4].HeaderText = "Giá xuất";

                    int totalWidth = gridviewHangHoa.Width;

                    gridviewHangHoa.Columns[0].Width = (int)(totalWidth * 0.20);
                    gridviewHangHoa.Columns[1].Width = (int)(totalWidth * 0.30);
                    gridviewHangHoa.Columns[2].Width = (int)(totalWidth * 0.20);
                    gridviewHangHoa.Columns[3].Width = (int)(totalWidth * 0.15);
                    gridviewHangHoa.Columns[4].Width = (int)(totalWidth * 0.15);

                    gridviewHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho mã LHH này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
