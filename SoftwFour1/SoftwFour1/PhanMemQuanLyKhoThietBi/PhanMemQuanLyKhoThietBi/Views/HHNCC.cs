using System;
using System.Data;
using System.Windows.Forms;
using PhanMemQuanLyKhoThietBi.Controllers;

namespace PhanMemQuanLyKhoThietBi.Views
{
    public partial class HHNCC : Form
    {
        private string _maNCC;
        private HangHoaControllers _hangHoaController;

        public HHNCC(string maNCC)
        {
            InitializeComponent();
            _maNCC = maNCC;
            _hangHoaController = new HangHoaControllers();
        }

        private void HienThiHangHoaTheoNCC()
        {
            try
            {
                DataTable data = _hangHoaController.LayHangHoaTheoNCC(_maNCC);

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
                    MessageBox.Show("Không có dữ liệu cho mã NCC này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


        private void HHNCC_Load_1(object sender, EventArgs e)
        {
            HienThiHangHoaTheoNCC();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
