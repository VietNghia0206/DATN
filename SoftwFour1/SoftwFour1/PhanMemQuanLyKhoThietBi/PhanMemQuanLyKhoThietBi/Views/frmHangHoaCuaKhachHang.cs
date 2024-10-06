using PhanMemQuanLyKhoThietBi.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyKhoThietBi.Views
{
    public partial class frmHangHoaCuaKhachHang : Form
    {
        private XuatKhoControllers xuatKhoControllers = new XuatKhoControllers();
        private string maKhachHang;

        public frmHangHoaCuaKhachHang(string maKhachHang)
        {
            InitializeComponent();
            this.maKhachHang = maKhachHang;
        }

        private void frmHangHoaCuaKhachHang_Load(object sender, EventArgs e)
        {
            HienThiSPDaMua();
        }

        private void HienThiSPDaMua()
        {
            DataTable dtHoaDon = xuatKhoControllers.HienThiXuatKho("19000101", "99991231");
            DataTable dtSPDaMua = new DataTable();
            dtSPDaMua.Columns.Add("Mã Sản Phẩm");
            dtSPDaMua.Columns.Add("Tên Sản Phẩm");
            dtSPDaMua.Columns.Add("Đơn Giá");
            dtSPDaMua.Columns.Add("Số Lượng");
            dtSPDaMua.Columns.Add("Thành Tiền");

            foreach (DataRow row in dtHoaDon.Rows)
            {
                string maHD = row["MaHD"].ToString();
                string maKH = row["makh"].ToString();

                if (maKH == maKhachHang)
                {
                    DataTable dtChiTiet = xuatKhoControllers.HienThiChiTietXuatKho(maHD);
                    foreach (DataRow chiTietRow in dtChiTiet.Rows)
                    {
                        dtSPDaMua.Rows.Add(
                            chiTietRow["MaHH"],
                            chiTietRow["tenhh"],
                            chiTietRow["GiaXuat"],
                            chiTietRow["SoLuong"],
                            chiTietRow["ThanhTien"]
                        );
                    }
                }
            }

            dgvSPDaMua.DataSource = dtSPDaMua;

            int totalWidth = dgvSPDaMua.Width;

            dgvSPDaMua.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSPDaMua.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSPDaMua.Columns[2].HeaderText = "Đơn Giá";
            dgvSPDaMua.Columns[3].HeaderText = "Số Lượng";
            dgvSPDaMua.Columns[4].HeaderText = "Thành Tiền";

            dgvSPDaMua.Columns[0].Width = (int)(totalWidth * 0.20);
            dgvSPDaMua.Columns[1].Width = (int)(totalWidth * 0.30);
            dgvSPDaMua.Columns[2].Width = (int)(totalWidth * 0.15);
            dgvSPDaMua.Columns[3].Width = (int)(totalWidth * 0.10);
            dgvSPDaMua.Columns[4].Width = (int)(totalWidth * 0.25);

            dgvSPDaMua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
