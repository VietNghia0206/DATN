using PhanMemQuanLyKhoThietBi.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyKhoThietBi.Views
{
    public partial class frmXuatKhoInfor : Form
    {
        public frmXuatKhoInfor()
        {
            InitializeComponent();
            DanhSachLHH1();
            DanhSachNCC1();
        }

        HangHoaControllers dbmp = new HangHoaControllers();
        KhachHangControllers dbkh = new KhachHangControllers();
        XuatKhoControllers dbhd = new XuatKhoControllers();
        LHHControllers dbLHH = new LHHControllers();
        NCCControllers dbNCC = new NCCControllers();

        private void frmXuatKhoInfor_Load(object sender, EventArgs e)
        {
            DanhSachKhachHang();
            HienThiHangHoa();
            if (frmXuatKho.save == true)
            {
                GenCode();
                HienThiChiTietXuatKho();
                txtTongTien.Text = "0 VND";
                txtmanv.Text = frmDangNhap.tennv;
            }
            else
            {
                //cbomakh.Enabled = false;
                txtTenKH.Enabled = false;
                //cbomakh.SelectedValue = frmXuatKho.makh;
                txtMaKH.Enabled = false;
                txtDienThoai.Enabled = false;
                GrvKH.Enabled = false;
                txtmahd.Text = frmXuatKho.mahd;
                txtmanv.Text = frmDangNhap.tennv;
                dtNgayHD.Value = frmXuatKho.ngayban;
                HienThiChiTietXuatKho();
                TongTienXuatKho();
            }
        }

        private void DanhSachLHH1()
        {

            DataTable dt1 = dbLHH.HienThiX("");
            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cho Loại Hàng Hóa.");
                return;
            }
            TenLHH.DataSource = dt1; // Nếu cần thiết lập khác, có thể sử dụng DataTable khác
            TenLHH.DisplayMember = "TenLHH";
            TenLHH.ValueMember = "MaLHH";

            // Chỉ khi có đủ dữ liệu
            if (dt1.Rows.Count > 1)
            {
                TenLHH.SelectedIndex = 1;
            }
        }

        private void DanhSachNCC1()
        {

            DataTable dt1 = dbNCC.HienThiX("");
            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cho Nhà Cung Cấp.");
                return;
            }
            TenNCC.DataSource = dt1; // Nếu cần thiết lập khác, có thể sử dụng DataTable khác
            TenNCC.DisplayMember = "TenNCC";
            TenNCC.ValueMember = "MaNCC";

            // Chỉ khi có đủ dữ liệu
            if (dt1.Rows.Count > 1)
            {
                TenNCC.SelectedIndex = 1;
            }
        }

        private void GenCode()
        {
            string sTemp = "PXK_" + DateTime.Now.ToString("yyMMddhhmmss");
            txtmahd.Text = sTemp;
        }

        private void DanhSachKhachHang()
        {
            //DataTable dt = new DataTable();
            //dt = dbkh.HienThi("");
            //cbomakh.DataSource = dt;
            //cbomakh.DisplayMember = "tenkh";
            //cbomakh.ValueMember = "makh";
            DataTable dt = dbkh.TimKiem(txtMaKH.Text, txtTenKH.Text, txtDienThoai.Text);
            GrvKH.DataSource = dt;

            //GrvKH.DataSource = dbkh.TimKiem(txtMaKH.Text,txtTenKH.Text,txtDienThoai.Text);
            //foreach (DataGridViewColumn column in GrvKH.Columns)
            //{
            //    MessageBox.Show(column.Name); // In ra tên cột
            //}

            GrvKH.Columns["MaKH"].HeaderText = "Mã KH";
            GrvKH.Columns["TenKH"].HeaderText = "Tên KH";
            GrvKH.Columns["DienThoai"].HeaderText = "Điện thoại";

            int totalWidth = GrvKH.Width;

            GrvKH.Columns[0].Width = (int)(totalWidth * 0.20);
            GrvKH.Columns[1].Width = (int)(totalWidth * 0.40);
            GrvKH.Columns[2].Width = (int)(totalWidth * 0.40);
       
        }

        private void HienThiHangHoa()
        {
            DataTable dt = new DataTable();
            dt = dbmp.HienThiHangHoaXuatKho(txttenhh.Text);
            grdHangHoa.DataSource = dt;

            grdHangHoa.Columns[0].HeaderText = "Mã hàng hóa";
            grdHangHoa.Columns[1].HeaderText = "Tên hàng hóa";
            grdHangHoa.Columns[2].HeaderText = "Mã loại hàng hóa";
            grdHangHoa.Columns[3].HeaderText = "Tồn kho";
            grdHangHoa.Columns[4].HeaderText = "Giá xuất";
            grdHangHoa.Columns[5].HeaderText = "Mã nhà cung cấp";

            int totalWidth = grdHangHoa.Width;

            grdHangHoa.Columns[0].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[1].Width = (int)(totalWidth * 0.25);
            grdHangHoa.Columns[2].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[3].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[4].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[5].Width = (int)(totalWidth * 0.10);
        }


        private void HienThiChiTietXuatKho()
        {
            DataTable dt = new DataTable();
            dt = dbhd.HienThiChiTietXuatKho(txtmahd.Text);
            grdCTHD.DataSource = dt;

            grdCTHD.Columns[0].HeaderText = "Mã hóa đơn";
            grdCTHD.Columns[1].HeaderText = "Mã hàng hóa";
            grdCTHD.Columns[2].HeaderText = "Tên hàng hóa";
            grdCTHD.Columns[3].HeaderText = "Giá xuất";
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

        private void Search(string TenHH, string MaLHH, string MaNCC)
        {
            DataTable dt = new DataTable();
            dt = dbmp.SearchHangHoaXuatKho(TenHH, MaLHH, MaNCC);
            grdHangHoa.DataSource = dt;

            grdHangHoa.Columns[0].HeaderText = "Mã hàng hóa";
            grdHangHoa.Columns[1].HeaderText = "Tên hàng hóa";
            grdHangHoa.Columns[2].HeaderText = "Mã loại hàng hóa";
            grdHangHoa.Columns[3].HeaderText = "Tồn kho";
            grdHangHoa.Columns[4].HeaderText = "Giá xuất";
            grdHangHoa.Columns[5].HeaderText = "Mã nhà cung cấp";

            int totalWidth = grdHangHoa.Width;

            grdHangHoa.Columns[0].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[1].Width = (int)(totalWidth * 0.25);
            grdHangHoa.Columns[2].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[3].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[4].Width = (int)(totalWidth * 0.15);
            grdHangHoa.Columns[5].Width = (int)(totalWidth * 0.10);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Search(txttenhh.Text, TenLHH.SelectedValue.ToString(), TenNCC.SelectedValue.ToString());
            txttenhh.Text = "";
            TenNCC.SelectedIndex = 1;
            TenLHH.SelectedIndex = 1;
        }

        public void TongTienXuatKho()
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
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo");
                
            }
            else
            {
                try
                {
                    if (grdHangHoa.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có hàng hóa để tạo phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DataGridViewRow row = this.grdHangHoa.Rows[grdHangHoa.CurrentCell.RowIndex];
                    string MaHD = txtmahd.Text;
                    string MaKH = txtMaKH.Text;
                    string MaHH = row.Cells[0].Value.ToString();
                    decimal SoLuong = nmsoluong.Value;

                    DataTable dt = dbmp.LayDonGiaXuat(MaHH);
                    decimal GiaXuat = 0;
                    if (dt.Rows.Count > 0)
                    {
                        GiaXuat = decimal.Parse(dt.Rows[0]["GiaXuat"].ToString());
                    }
                    decimal ThanhTien = GiaXuat * SoLuong;

                    if (dbhd.CheckExitsXuatKho(txtmahd.Text) == 1)
                    {
                        //MessageBox.Show("txtMaKH: " + txtMaKH.Text);
                        dbhd.ThemXuatKho(MaHD, MaKH, dtNgayHD.Value.ToString("yyyy/MM/dd"), frmDangNhap.manv, decimal.Parse(txtTongTien.Text.Replace(" VND", "")));
                    }
                    else
                    {
                        if (txtTongTien.Text == "")
                        {
                            txtTongTien.Text = "0 VND";
                        }
                        dbhd.SuaXuatKho(MaHD, MaKH, dtNgayHD.Value.ToString("yyyy/MM/dd"), frmDangNhap.manv, decimal.Parse(txtTongTien.Text.Replace(" VND", "")));
                    }

                    if (dbhd.KiemTraHangHoaTonKho(MaHD, MaHH) < nmsoluong.Value)
                    {
                        MessageBox.Show("Tồn kho của sản phẩm này không đủ để xuất bán.");
                        return;
                    }

                    if (dbhd.CheckExits(MaHD, MaHH) == 0)
                    {
                        dbhd.CapNhatSoLuongTienChiTietXuatKho(MaHD, MaHH, SoLuong);
                    }
                    else
                    {
                        dbhd.ThemChiTietXuatKho(MaHD, MaHH, SoLuong, ThanhTien);
                    }
                    dbhd.UpdateTongTien(MaHD);
                    HienThiChiTietXuatKho();
                    TongTienXuatKho();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại!", "Thông báo");
                }
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txttenhh.Text = "";
            HienThiHangHoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.grdCTHD.Rows[grdCTHD.CurrentCell.RowIndex];
            dbhd.XoaChiTietXuatKho(txtmahd.Text, row.Cells[1].Value.ToString());
            HienThiChiTietXuatKho();
            TongTienXuatKho();
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

        private void frmXuatKhoInfor_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbhd.XoaXuatKhoKhongTonTaiTrongChiTietXuatKho();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtmahd_TextChanged(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nmsoluong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grdHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttenhh_TextChanged(object sender, EventArgs e)
        {
            //Search(txttenhh.Text, TenLHH.SelectedValue.ToString(), TenNCC.SelectedValue.ToString());
            //txttenhh.Text = "";
            //TenNCC.SelectedIndex = 1;
            //TenLHH.SelectedIndex = 1;

            Search(txttenhh.Text, TenLHH.SelectedValue.ToString(), TenNCC.SelectedValue.ToString());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void grdCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dtNgayHD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            DanhSachKhachHang();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            DanhSachKhachHang();
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            DanhSachKhachHang();
        }

        private void GrvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //DataGridViewRow row = this.GrvKH.Rows[GrvKH.CurrentCell.RowIndex];
                DataGridViewRow row = this.GrvKH.Rows[e.RowIndex];

                //MessageBox.Show("MaKH: " + row.Cells[0].Value + " " + row.Cells[0].Value?.GetType());
                //MessageBox.Show("TenKH: " + row.Cells[1].Value + " " + row.Cells[1].Value?.GetType());
                //MessageBox.Show("DienThoai: " + row.Cells[2].Value + " " + row.Cells[2].Value?.GetType());

                var tenKHValue = row.Cells[1].Value?.ToString();
                var dienThoaiValue = row.Cells[2].Value?.ToString();

                //MessageBox.Show("Giá trị TenKH trước khi gán: " + tenKHValue);
                //MessageBox.Show("Giá trị DienThoai trước khi gán: " + dienThoaiValue);

                txtMaKH.Text = row.Cells[0].Value?.ToString() ?? "Không có giá trị";
                txtTenKH.Text = tenKHValue ?? ""; // Gán giá trị vào txtTenKH
                txtDienThoai.Text = dienThoaiValue ?? ""; // Gán giá trị vào txtDienThoai

                

                //txtMaKH.Text = row.Cells[0].Value?.ToString() ?? "Không có giá trị";
                //txtTenKH.Text = row.Cells[1].Value?.ToString() ?? ""; // Kiểm tra chữ hoa chữ thường
                //txtDienThoai.Text = row.Cells[2].Value?.ToString() ?? "";
                //txtTenKH.Text = "Test";
                //txtDienThoai.Text = row.Cells[1].Value.ToString();

                //MessageBox.Show("txtMaKH: " + txtMaKH.Text);
                //MessageBox.Show("txtTenKH: " + txtTenKH.Text);
                //MessageBox.Show("txtDienThoai: " + txtDienThoai.Text);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TenLHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(
        txttenhh.Text,
        TenLHH.SelectedValue != null ? TenLHH.SelectedValue.ToString() : "1",
        TenNCC.SelectedValue != null ? TenNCC.SelectedValue.ToString() : "1");  
        }

        private void TenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(
        txttenhh.Text,
        TenLHH.SelectedValue != null ? TenLHH.SelectedValue.ToString() : "1",
        TenNCC.SelectedValue != null ? TenNCC.SelectedValue.ToString() : "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDienThoai.Text = "";
        }
    }
}
