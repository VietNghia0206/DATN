using System;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PhanMemQuanLyKhoThietBi.Controllers;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PhanMemQuanLyKhoThietBi.Views
{
    public partial class frmBaoCaoTonKho : Form
    {
        public frmBaoCaoTonKho()
        {
            InitializeComponent();
            btnPhieuTonKho.Click += new EventHandler(btnPhieuTonKho_Click);
            DanhSachLHH();
            DanhSachNCC();
        }

        BCTonKhoControllers db = new BCTonKhoControllers();
        NCCControllers dbNCC = new NCCControllers();
        LHHControllers dbLHH = new LHHControllers();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void HienThiHangHoa()
        {

            gridview.DataSource = db.HienThi();

            gridview.Columns[0].HeaderText = "Mã hàng hóa";
            gridview.Columns[1].HeaderText = "Tên hàng hóa";
            gridview.Columns[2].HeaderText = "Mã NCC";
            gridview.Columns[3].HeaderText = "Tên NCC";
            gridview.Columns[4].HeaderText = "Mã LHH";
            gridview.Columns[5].HeaderText = "Tên LHH";
            gridview.Columns[6].HeaderText = "Đơn vị";
            gridview.Columns[7].HeaderText = "Giá nhập";
            gridview.Columns[8].HeaderText = "Giá xuất";
            gridview.Columns[9].HeaderText = "Tồn kho";

            int totalWidth = gridview.Width;

            gridview.Columns[0].Width = (int)(totalWidth * 0.10);
            gridview.Columns[1].Width = (int)(totalWidth * 0.10);
            gridview.Columns[2].Width = (int)(totalWidth * 0.10);
            gridview.Columns[3].Width = (int)(totalWidth * 0.10);
            gridview.Columns[4].Width = (int)(totalWidth * 0.10);
            gridview.Columns[5].Width = (int)(totalWidth * 0.10);
            gridview.Columns[6].Width = (int)(totalWidth * 0.10);
            gridview.Columns[7].Width = (int)(totalWidth * 0.10);
            gridview.Columns[8].Width = (int)(totalWidth * 0.10);
            gridview.Columns[9].Width = (int)(totalWidth * 0.10);
        }

        private void DanhSachLHH()
        {
            DataTable dt = dbLHH.HienThiX("");
            cboMaLHH.DataSource = dt;
            cboMaLHH.DisplayMember = "TenLHH";
            cboMaLHH.ValueMember = "MaLHH";
        }

        private void DanhSachNCC()
        {
            DataTable dt = dbNCC.HienThiX("");
            cboMaNCC.DataSource = dt;
            cboMaNCC.DisplayMember = "TenNCC";
            cboMaNCC.ValueMember = "MaNCC";
        }

        private void Search()
        {
            try
            {
                string MaHH = "";
                string TenHH = "";
                string TenNCC = "";
                string LHH = "";
                int TK = 0;
                int TK1 = 0;
                int Nhap = 0;
                int Nhap1 = 0;
                int Xuat = 0;
                int Xuat1 = 0;
                MaHH = txtMaHH.Text;
                TenHH = txtTenHH.Text;
                TenNCC = cboMaNCC.SelectedValue.ToString();
                LHH = cboMaLHH.SelectedValue.ToString();
                if (txtTonKho.Text == "")
                {
                    TK = 0;
                }
                else
                {
                    TK = int.Parse(txtTonKho.Text.ToString());
                }

                if (txtTonKho1.Text == "")
                {
                    TK1 = 2147483647;
                }
                else
                {
                    TK1 = int.Parse(txtTonKho1.Text.ToString());
                }

                if (txtNhap.Text == "")
                {
                    Nhap = 0;
                }
                else
                {
                    Nhap = int.Parse(txtNhap.Text.ToString());
                }

                if (txtNhap1.Text == "")
                {
                    Nhap1 = 2147483647;
                }
                else
                {
                    Nhap1 = int.Parse(txtNhap1.Text.ToString());
                }

                if (txtXuat.Text == "")
                {
                    Xuat = 0;
                }
                else
                {
                    Xuat = int.Parse(txtXuat.Text.ToString());
                }

                if (txtXuat1.Text == "")
                {
                    Xuat1 = 2147483647;
                }
                else
                {
                    Xuat1 = int.Parse(txtXuat1.Text.ToString());
                }


                gridview.DataSource = db.Search(MaHH, TenHH, TenNCC, LHH, TK, TK1, Nhap, Nhap1, Xuat, Xuat1);

                gridview.Columns[0].HeaderText = "Mã hàng hóa";
                gridview.Columns[1].HeaderText = "Tên hàng hóa";
                gridview.Columns[2].HeaderText = "Mã NCC";
                gridview.Columns[3].HeaderText = "Tên NCC";
                gridview.Columns[4].HeaderText = "Mã LHH";
                gridview.Columns[5].HeaderText = "Tên LHH";
                gridview.Columns[6].HeaderText = "Đơn vị";
                gridview.Columns[7].HeaderText = "Giá nhập";
                gridview.Columns[8].HeaderText = "Giá xuất";
                gridview.Columns[9].HeaderText = "Tồn kho";

                int totalWidth = gridview.Width;

                gridview.Columns[0].Width = (int)(totalWidth * 0.10);
                gridview.Columns[1].Width = (int)(totalWidth * 0.10);
                gridview.Columns[2].Width = (int)(totalWidth * 0.10);
                gridview.Columns[3].Width = (int)(totalWidth * 0.10);
                gridview.Columns[4].Width = (int)(totalWidth * 0.10);
                gridview.Columns[5].Width = (int)(totalWidth * 0.10);
                gridview.Columns[6].Width = (int)(totalWidth * 0.10);
                gridview.Columns[7].Width = (int)(totalWidth * 0.10);
                gridview.Columns[8].Width = (int)(totalWidth * 0.10);
                gridview.Columns[9].Width = (int)(totalWidth * 0.10);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi giá trị nhập", "Thông báo");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtNhap.Text = "";
            txtTonKho.Text = "";
            DanhSachLHH();
            DanhSachNCC();
            txtTonKho1.Text = "";
            txtXuat.Text = "";
            txtXuat1.Text = "";
            txtNhap.Text = "";
            txtNhap1.Text = "";
            HienThiHangHoa();
        }

        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            HienThiHangHoa();
        }

        private void btnPhieuTonKho_Click(object sender, EventArgs e)
        {
            XRpTonKho report = new XRpTonKho();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.ShowDialog();
        }

        private void btnTonKhoIt_Click(object sender, EventArgs e)
        {
            DataTable dt = db.Warn();

            DataView dv = new DataView(dt);

            gridview.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XRpTonKhoIt report = new XRpTonKhoIt();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }

        private void tbnTKT_Click(object sender, EventArgs e)
        {
            frmTKThang frm = new frmTKThang();
            frm.ShowDialog();
        }
    }
}
