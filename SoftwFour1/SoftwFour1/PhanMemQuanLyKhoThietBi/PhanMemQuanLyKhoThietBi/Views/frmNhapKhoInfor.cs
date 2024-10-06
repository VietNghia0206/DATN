using PhanMemQuanLyKhoThietBi.Controllers;
using PhanMemQuanLyKhoThietBi.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyKhoThietBi.Views
{
    public partial class frmNhapKhoInfor : Form
    {
        
        public Boolean ischeck = true;

        public frmNhapKhoInfor()
        {
            InitializeComponent();
        }

        HangHoaControllers dbmp = new HangHoaControllers();
        NCCControllers dbncc = new NCCControllers();
        NhapKhoControllers dbhd = new NhapKhoControllers();
        DataTable dtct = new DataTable();

        private void frmNhapKhoInfor_Load(object sender, EventArgs e)
        {
            DanhSachNCC();
            HienThiHangHoa();
            if (frmNhapKho.save == true)
            {
                GenCode();
                HienThiChiTietNhapKho();
                txtTongTien.Text = "0 VND";
                txtmanv.Text = frmDangNhap.tennv;
            }
            else
            {
                cbomancc.Enabled = false;
                cbomancc.SelectedValue = frmNhapKho.mancc;
                txtmahd.Text = frmNhapKho.mahd;
                txtmanv.Text = frmDangNhap.tennv;
                dtNgayHD.Value = frmNhapKho.NgayHD;
                HienThiChiTietNhapKho();
                TongTienNhapKho();
            }
        }

        private void GenCode()
        {
            string sTemp = "PXK_" + DateTime.Now.ToString("yyMMddhhmmss");
            txtmahd.Text = sTemp;
        }

        private void DanhSachNCC()
        {
            DataTable dt = new DataTable();
            dt = dbncc.HienThi("");
            cbomancc.DataSource = dt;
            cbomancc.DisplayMember = "tenncc";
            cbomancc.ValueMember = "mancc";
        }

        private void HienThiHangHoa()
        {
            DataTable dt = new DataTable();
            dt = dbmp.HienThiHangHoaNhapKho(txttenhh.Text, cbomancc.SelectedValue.ToString());
            grdHangHoa.DataSource = dt;

            grdHangHoa.Columns[0].HeaderText = "Mã hàng hóa";
            grdHangHoa.Columns[1].HeaderText = "Tên hàng hóa";
            grdHangHoa.Columns[2].HeaderText = "Mã loại hàng hóa";
            grdHangHoa.Columns[3].HeaderText = "Tồn kho";
            grdHangHoa.Columns[4].HeaderText = "Đơn giá";
            grdHangHoa.Columns[5].HeaderText = "Mã nhà cung cấp";

            int totalWidth = grdHangHoa.Width;

            grdHangHoa.Columns[0].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[1].Width = (int)(totalWidth * 0.25);
            grdHangHoa.Columns[2].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[3].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[4].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[5].Width = (int)(totalWidth * 0.10);
        }


        private void HienThiChiTietNhapKho()
        {
            DataTable dt = new DataTable();
            dt = dbhd.HienThiChiTietNhapKho(txtmahd.Text);
            grdCTHD.DataSource = dt;

            grdCTHD.Columns[0].HeaderText = "Mã hóa đơn";
            grdCTHD.Columns[1].HeaderText = "Mã hàng hóa";
            grdCTHD.Columns[2].HeaderText = "Tên hàng hóa";
            grdCTHD.Columns[3].HeaderText = "Đơn giá";
            grdCTHD.Columns[4].HeaderText = "Số lượng";
            grdCTHD.Columns[5].HeaderText = "Thành tiền";

            int totalWidth = grdCTHD.Width;

            grdCTHD.Columns[0].Width = (int)(totalWidth * 0.20);
            grdCTHD.Columns[1].Width = (int)(totalWidth * 0.15);
            grdCTHD.Columns[2].Width = (int)(totalWidth * 0.25);
            grdCTHD.Columns[3].Width = (int)(totalWidth * 0.15);
            grdCTHD.Columns[4].Width = (int)(totalWidth * 0.15);
            grdCTHD.Columns[5].Width = (int)(totalWidth * 0.10);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiHangHoa();
        }

        public void TongTienNhapKho()
        {
            if (grdCTHD.Rows.Count == 0)
            {
                return;
            }
            decimal thanhtien = 0;
            for (int i = 0; i < grdCTHD.Rows.Count; i++)
            {
                thanhtien += decimal.Parse(grdCTHD.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            txtTongTien.Text = thanhtien.ToString("#,###") + " VND";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (grdHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có hàng hóa để tạo phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow row = this.grdHangHoa.Rows[grdHangHoa.CurrentCell.RowIndex];
            string MaHD = txtmahd.Text;
            string MaHH = row.Cells[0].Value.ToString();
            decimal SoLuong = nmsoluong.Value;

            DataTable dt = dbmp.LayDonGia(MaHH);
            decimal DonGia = 0;
            if (dt.Rows.Count > 0)
            {
                DonGia = decimal.Parse(dt.Rows[0]["DonGia"].ToString());
            }
            decimal ThanhTien = DonGia * SoLuong;

            if (dbhd.CheckExitsNhapKho(txtmahd.Text) == 1)
            {
                dbhd.ThemNhapKho(MaHD, cbomancc.SelectedValue.ToString(), dtNgayHD.Value.ToString("yyyy/MM/dd"), frmDangNhap.manv, decimal.Parse(txtTongTien.Text.Replace(" VND", "")));
            }
            else
            {
                if(txtTongTien.Text == "")
                {
                    txtTongTien.Text = "0 VND";
                }
                dbhd.SuaNhapKho(MaHD, cbomancc.SelectedValue.ToString(), dtNgayHD.Value.ToString("yyyy/MM/dd"), frmDangNhap.manv, decimal.Parse(txtTongTien.Text.Replace(" VND", "")));
            }



            if (dbhd.CheckExits(MaHD, MaHH) == 0)
            {
                dbhd.CapNhatSoLuongTienChiTietNhapKho(MaHD, MaHH, SoLuong);
            }
            else
            {
                dbhd.ThemChiTietNhapKho(MaHD, MaHH, SoLuong, ThanhTien);
            }
            dbhd.UpdateTongTien(MaHD);
            HienThiChiTietNhapKho();
            TongTienNhapKho();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txttenhh.Text = "";
            HienThiHangHoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaHD = txtmahd.Text;
                DataGridViewRow row = this.grdCTHD.Rows[grdCTHD.CurrentCell.RowIndex];
                if (row != null)
                {
                    dbhd.XoaChiTietNhapKho(txtmahd.Text, row.Cells[1].Value.ToString());
                    HienThiChiTietNhapKho();
                    TongTienNhapKho();
                    dbhd.UpdateTongTien(MaHD);
                }
                else MessageBox.Show("Không có hàng hóa để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi khi thực hiện chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoiNCC()
        {
            try
            {
                string MaHD = txtmahd.Text;

                {
                    dbhd.DoiNCC(txtmahd.Text);
                    HienThiChiTietNhapKho();
                    TongTienNhapKho();
                    dbhd.UpdateTongTien(MaHD);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi khi thực hiện chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (grdCTHD.Rows.Count == 0)
            {
                return;
            }
            try
            {
                DialogResult ok = MessageBox.Show("Bạn có muốn tính tiền cho khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ok == DialogResult.Yes)
                {
                    MessageBox.Show("TỔNG SỐ TIỀN THANH TOÁN LÀ " + txtTongTien.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    for (int i = 0; i < grdCTHD.Rows.Count; i++)
                    {
                        dbhd.UpdateTonKho(decimal.Parse(grdCTHD.Rows[i].Cells["SoLuong"].Value.ToString()), grdCTHD.Rows[i].Cells["MaHH"].Value.ToString());
                    }
                    dbhd.UpdateTrangThaiSauThanhToan(txtmahd.Text);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmNhapKhoInfor_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbhd.XoaNhapKhoKhongTonTaiTrongChiTietNhapKho();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbomancc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiHangHoa();
            DoiNCC();
        }

        private void Ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
