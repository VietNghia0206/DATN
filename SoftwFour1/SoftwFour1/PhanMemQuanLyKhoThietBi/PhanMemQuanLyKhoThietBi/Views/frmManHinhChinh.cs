using PhanMemQuanLyKhoThietBi.Models;
using PhanMemQuanLyKhoThietBi.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PhanMemQuanLyKhoThietBi
{
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
            LoadDuBaoNhuCau();
            LoadKHTiemNang();
            LoadCanTakeCare();
            //var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            //var screenHeight = Screen.PrimaryScreen.Bounds.Height;

            //// Hiển thị thông báo
            //MessageBox.Show($"Kích thước màn hình: {screenWidth} x {screenHeight}", "Thông báo");
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmDangNhap.manv == "ADMIN")
            {
                frmNhanVien frm = new frmNhanVien();
                frm.Show();
            }
            else MessageBox.Show("Nhân viên không có quyền truy cập chức năng quản lý nhân viên");
        }

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
                    SELECT TOP 10 
    HangHoa.MaHH, 
    HangHoa.TenHH, 
    SUM(ChiTietXuatKho.SoLuong) AS TongSoLuongBan, 
    SUM(ChiTietXuatKho.SoLuong * HangHoa.GiaXuat) AS DoangThu
FROM ChiTietXuatKho
INNER JOIN HangHoa ON ChiTietXuatKho.MaHH = HangHoa.MaHH
GROUP BY HangHoa.MaHH, HangHoa.TenHH
ORDER BY DoangThu DESC;";

                DataTable dt = ConnectSQL.Load(query);
                dgvBanChay.DataSource = dt;

                string query1 = @"
                    SELECT TOP 10 
    HangHoa.MaHH, 
    HangHoa.TenHH, 
    SUM(ChiTietXuatKho.SoLuong) AS TongSoLuongBan, 
    SUM(ChiTietXuatKho.SoLuong * HangHoa.GiaXuat) AS DoangThu
FROM ChiTietXuatKho
INNER JOIN HangHoa ON ChiTietXuatKho.MaHH = HangHoa.MaHH
GROUP BY HangHoa.MaHH, HangHoa.TenHH
ORDER BY DoangThu ASC;";

                DataTable dt1 = ConnectSQL.Load(query1);
                dgvCham.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu dự báo nhu cầu: " + ex.Message);
            }
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNCC frm = new frmNCC();
            frm.Show();
        }

        private void danhMụcLoạiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLHH frm = new frmLHH();
            frm.Show();
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            frm.Show();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.Show();
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapKho frm = new frmNhapKho();
            frm.Show();
        }

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXuatKho frm = new frmXuatKho();
            frm.Show();
        }

        private void báoCáoTồnKhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoTonKho frm = new frmBaoCaoTonKho();
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
                
                
            }
            else
                return;
        }

        private void frmDuBao_Click(object sender, EventArgs e)
        {
            frmDuBao frm = new frmDuBao();
            frm.Show();
        }
    }
}
