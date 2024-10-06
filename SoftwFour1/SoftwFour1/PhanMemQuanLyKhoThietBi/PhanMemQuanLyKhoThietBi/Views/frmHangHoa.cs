using PhanMemQuanLyKhoThietBi.Controllers;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PhanMemQuanLyKhoThietBi.Views
{
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        HangHoaControllers db = new HangHoaControllers();
        NCCControllers dbNCC = new NCCControllers();
        LHHControllers dbLHH = new LHHControllers();
        private bool luu;

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            if (gridview.Columns["AnhHH"] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)gridview.Columns["AnhHH"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            DanhSachLHH1();
            DanhSachNCC1();
            HienThiHangHoa("");
            boolcontrols(true);
            DanhSachLHH();
            DanhSachNCC();
        }


        private void boolcontrols(bool iss)
        {
            btnThem.Enabled = iss;
            btnSua.Enabled = iss;
            btnXoa.Enabled = iss;
            btnLuu.Enabled = !iss;
            btnHuy.Enabled = !iss;
            btnLamMoi.Enabled = iss;
            btnThoat.Enabled = iss;
            btnTim.Enabled = iss;
            txtMaHH.Enabled = !iss;
            txtTenHH.Enabled = !iss;
            txtTonKho.Enabled = !iss;
            txtDonVi.Enabled = !iss;
            txtDonGia.Enabled = !iss;
            txtGiaXuat.Enabled = !iss;
            cboMaNCC.Enabled = !iss;
            cboMaLHH.Enabled = !iss;
            btnChonAnh.Enabled = !iss;
        }

        private void HienThiHangHoa(string TenHH)
        {
            DataTable dt = db.HienThi(TenHH);

            gridview.DataSource = dt;

            gridview.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            gridview.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            gridview.Columns["MaLHH"].HeaderText = "Loại hàng hóa";
            gridview.Columns["MaNCC"].HeaderText = "Nhà cung cấp";
            gridview.Columns["DonVi"].HeaderText = "Đơn vị";
            gridview.Columns["TonKho"].HeaderText = "Số lượng";
            gridview.Columns["DonGia"].HeaderText = "Giá nhập";
            gridview.Columns["GiaXuat"].HeaderText = "Giá xuất";
            gridview.Columns["AnhHH"].HeaderText = "Ảnh hàng hóa";

            gridview.Columns["MaHH"].DisplayIndex = 0;
            gridview.Columns["TenHH"].DisplayIndex = 1;
            gridview.Columns["MaLHH"].DisplayIndex = 2;
            gridview.Columns["MaNCC"].DisplayIndex = 3;
            gridview.Columns["DonVi"].DisplayIndex = 4;
            gridview.Columns["TonKho"].DisplayIndex = 5;
            gridview.Columns["DonGia"].DisplayIndex = 6;
            gridview.Columns["GiaXuat"].DisplayIndex = 7;
            gridview.Columns["AnhHH"].DisplayIndex = 8;

            foreach (DataGridViewColumn column in gridview.Columns)
            {
                if (column.Name != "MaHH" &&
                    column.Name != "TenHH" &&
                    column.Name != "MaLHH" &&
                    column.Name != "MaNCC" &&
                    column.Name != "DonVi" &&
                    column.Name != "TonKho" &&
                    column.Name != "DonGia" &&
                    column.Name != "GiaXuat" &&
                    column.Name != "AnhHH")
                {
                    column.Visible = false;
                }
            }

            gridview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            gridview.Columns["MaHH"].Width = (int)(gridview.Width / 9);
            gridview.Columns["TenHH"].Width = (int)(gridview.Width / 9);
            gridview.Columns["MaLHH"].Width = (int)(gridview.Width / 9); 
            gridview.Columns["MaNCC"].Width = (int)(gridview.Width / 9); 
            gridview.Columns["DonVi"].Width = (int)(gridview.Width / 9); 
            gridview.Columns["TonKho"].Width = (int)(gridview.Width / 9); 
            gridview.Columns["DonGia"].Width = (int)(gridview.Width / 9); 
            gridview.Columns["GiaXuat"].Width = (int)(gridview.Width / 9); 
            gridview.Columns["AnhHH"].Width = (int)(gridview.Width / 9);

            if (gridview.Columns["AnhHH"] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)gridview.Columns["AnhHH"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void DanhSachLHH()
        {
            DataTable dt = dbLHH.HienThi("");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cho Loại Hàng Hóa.");
                return;
            }

            cboMaLHH.DataSource = dt;
            cboMaLHH.DisplayMember = "TenLHH";
            cboMaLHH.ValueMember = "MaLHH";

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

        private void DanhSachNCC()
        {
            DataTable dt = dbNCC.HienThi("");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cho Nhà Cung Cấp.");
                return;
            }

            cboMaNCC.DataSource = dt;
            cboMaNCC.DisplayMember = "TenNCC";
            cboMaNCC.ValueMember = "MaNCC";

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

        private void gridview_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaHH.Text = row.Cells["MaHH"].Value.ToString();
                txtDonVi.Text = row.Cells["DonVi"].Value.ToString();
                txtTenHH.Text = row.Cells["TenHH"].Value.ToString();
                txtTonKho.Value = decimal.Parse(row.Cells["TonKho"].Value.ToString());
                txtDonGia.Value = decimal.Parse(row.Cells["DonGia"].Value.ToString());
                cboMaNCC.SelectedValue = row.Cells["MaNCC"].Value.ToString();
                cboMaLHH.SelectedValue = row.Cells["MaLHH"].Value.ToString();
                txtGiaXuat.Value = decimal.Parse(row.Cells["GiaXuat"].Value.ToString());

                if (row.Cells["AnhHH"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["AnhHH"].Value;
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DanhSachLHH();
            DanhSachNCC();
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtTonKho.Value = 0;
            txtTonKho.Enabled = false;
            txtDonGia.Value = 1;
            txtGiaXuat.Value = 1;
            txtDonVi.Text = "";
            pictureBox1.Image = null;

            boolcontrols(false);
            txtTonKho.Enabled = false;
            luu = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }

            luu = false;
            txtMaHH.Enabled = false;
            boolcontrols(false);
            txtTonKho.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }

            string maHH = gridview.Rows[gridview.CurrentCell.RowIndex].Cells["MaHH"].Value.ToString();

            DataTable dt = db.HienThi(maHH);
            if (dt.Rows.Count > 0)
            {
                decimal tonKho = Convert.ToDecimal(dt.Rows[0]["TonKho"]);

                if (tonKho > 0)
                {
                    MessageBox.Show("Không thể xóa hàng hóa này vì còn tồn kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult dr = MessageBox.Show("Có chắc chắn xóa hàng hóa này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.Xoa(maHH);
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiHangHoa("");
                    boolcontrols(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hàng hóa đã có dữ liệu giao dịch. Không được phép xóa!", "Thông báo");
                    //MessageBox.Show("Có lỗi xảy ra khi xóa: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHH.Text))
            {
                MessageBox.Show("Mã hàng hóa không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenHH.Text))
            {
                MessageBox.Show("Tên hàng hóa không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenHH.Focus();
                return;
            }

            //byte[] imageBytes = null;
            //if (pictureBox1.Image != null)
            //{
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            //        imageBytes = ms.ToArray();
            //    }
            //}

            byte[] imageBytes = null;

            if (pictureBox1.Image != null)
            {
                try
                {
                    using (Bitmap bitmapCopy = new Bitmap(pictureBox1.Image))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bitmapCopy.Save(ms, pictureBox1.Image.RawFormat);
                            imageBytes = ms.ToArray();
                        }
                    }
                }
                catch (ExternalException ex)
                {
                    MessageBox.Show("Lỗi khi lưu hình ảnh: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không có hình ảnh để lưu.");
            }

            if(txtMaHH.Text == ""  ||
            txtTenHH.Text == "" ||
            txtDonGia.Text == "" ||
            txtGiaXuat.Text == "" ||
            txtDonVi.Text == "" ||
            pictureBox1.Image == null)
                {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else
            {
                try
                {
                    if (luu)
                    {
                        db.Them(txtMaHH.Text.Trim(), txtTenHH.Text.Trim(), txtTonKho.Value, txtDonGia.Value, cboMaLHH.SelectedValue.ToString(), cboMaNCC.SelectedValue.ToString(), txtGiaXuat.Value, imageBytes, txtDonVi.Text.Trim());
                        MessageBox.Show("Thêm thành công.");
                    }
                    else
                    {
                        db.Sua(txtMaHH.Text.Trim(), txtTenHH.Text.Trim(), txtTonKho.Value, txtDonGia.Value, cboMaLHH.SelectedValue.ToString(), cboMaNCC.SelectedValue.ToString(), txtGiaXuat.Value, imageBytes, txtDonVi.Text.Trim());
                        MessageBox.Show("Cập nhật thành công.");
                    }

                    HienThiHangHoa("");
                    boolcontrols(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HienThiHangHoa("");
            boolcontrols(true);

            if (gridview.Rows.Count > 0)
            {
                var row = this.gridview.Rows[0];
                txtMaHH.Text = row.Cells["MaHH"].Value.ToString();
                txtTenHH.Text = row.Cells["TenHH"].Value.ToString();
                txtDonVi.Text = row.Cells["DonVi"].Value.ToString();
                txtTonKho.Value = decimal.Parse(row.Cells["TonKho"].Value.ToString());
                txtDonGia.Value = decimal.Parse(row.Cells["DonGia"].Value.ToString());
                cboMaNCC.SelectedValue = row.Cells["MaNCC"].Value.ToString();
                cboMaLHH.SelectedValue = row.Cells["MaLHH"].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThiHangHoa("");
            boolcontrols(true);

            if (gridview.Rows.Count > 0)
            {
                var row = this.gridview.Rows[0];
                txtMaHH.Text = row.Cells["MaHH"].Value.ToString();
                txtTenHH.Text = row.Cells["TenHH"].Value.ToString();
                txtDonVi.Text = row.Cells["DonVi"].Value.ToString();
                txtTonKho.Value = decimal.Parse(row.Cells["TonKho"].Value.ToString());
                txtDonGia.Value = decimal.Parse(row.Cells["DonGia"].Value.ToString());
                cboMaNCC.SelectedValue = row.Cells["MaNCC"].Value.ToString();
                cboMaLHH.SelectedValue = row.Cells["MaLHH"].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimHangHoa(string TenHH, string MaLHH, string MaNCC)
        {
            

            //MaNCC = TenNCC.SelectedValue.ToString();
            //MaLHH = TenLHH.SelectedValue.ToString();

            DataTable dt = db.HienThiX(TenHH, MaLHH, MaNCC);

            gridview.DataSource = dt;

            gridview.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            gridview.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            gridview.Columns["MaLHH"].HeaderText = "Loại hàng hóa";
            gridview.Columns["MaNCC"].HeaderText = "Nhà cung cấp";
            gridview.Columns["DonVi"].HeaderText = "Đơn vị";
            gridview.Columns["TonKho"].HeaderText = "Số lượng";
            gridview.Columns["DonGia"].HeaderText = "Giá nhập";
            gridview.Columns["GiaXuat"].HeaderText = "Giá xuất";
            gridview.Columns["AnhHH"].HeaderText = "Ảnh hàng hóa";

            gridview.Columns["MaHH"].DisplayIndex = 0;
            gridview.Columns["TenHH"].DisplayIndex = 1;
            gridview.Columns["MaLHH"].DisplayIndex = 2;
            gridview.Columns["MaNCC"].DisplayIndex = 3;
            gridview.Columns["DonVi"].DisplayIndex = 4;
            gridview.Columns["TonKho"].DisplayIndex = 5;
            gridview.Columns["DonGia"].DisplayIndex = 6;
            gridview.Columns["GiaXuat"].DisplayIndex = 7;
            gridview.Columns["AnhHH"].DisplayIndex = 8;

            foreach (DataGridViewColumn column in gridview.Columns)
            {
                if (column.Name != "MaHH" &&
                    column.Name != "TenHH" &&
                    column.Name != "MaLHH" &&
                    column.Name != "MaNCC" &&
                    column.Name != "DonVi" &&
                    column.Name != "TonKho" &&
                    column.Name != "DonGia" &&
                    column.Name != "GiaXuat" &&
                    column.Name != "AnhHH")
                {
                    column.Visible = false;
                }
            }

            gridview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridview.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            gridview.Columns["MaHH"].Width = (int)(gridview.Width / 9);
            gridview.Columns["TenHH"].Width = (int)(gridview.Width / 9);
            gridview.Columns["MaLHH"].Width = (int)(gridview.Width / 9);
            gridview.Columns["MaNCC"].Width = (int)(gridview.Width / 9);
            gridview.Columns["DonVi"].Width = (int)(gridview.Width / 9);
            gridview.Columns["TonKho"].Width = (int)(gridview.Width / 9);
            gridview.Columns["DonGia"].Width = (int)(gridview.Width / 9);
            gridview.Columns["GiaXuat"].Width = (int)(gridview.Width / 9);
            gridview.Columns["AnhHH"].Width = (int)(gridview.Width / 9);

            if (gridview.Columns["AnhHH"] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)gridview.Columns["AnhHH"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }


        private void gridview_Resize(object sender, EventArgs e)
        {
            HienThiHangHoa(TenHH.Text);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimHangHoa(TenHH.Text, TenLHH.SelectedValue.ToString(), TenNCC.SelectedValue.ToString());
            TenHH.Text = "";
            TenNCC.SelectedIndex = 1;
            TenLHH.SelectedIndex = 1;
        }



        

        private void TenHH_TextChanged(object sender, EventArgs e)
        {
            TimHangHoa(TenHH.Text, TenLHH.SelectedValue.ToString(), TenNCC.SelectedValue.ToString());
        }

        private void TenLHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TimHangHoa(TenHH.Text, TenLHH.SelectedValue.ToString(), TenNCC.SelectedValue.ToString());
            TimHangHoa(
        TenHH.Text,
        TenLHH.SelectedValue != null ? TenLHH.SelectedValue.ToString() : "1", // Truyền giá trị mặc định là 1
        TenNCC.SelectedValue != null ? TenNCC.SelectedValue.ToString() : "1"  // Truyền giá trị mặc định là 1
    );
        }

        private void TenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimHangHoa(
        TenHH.Text,
        TenLHH.SelectedValue != null ? TenLHH.SelectedValue.ToString() : "1", // Truyền giá trị mặc định là 1
        TenNCC.SelectedValue != null ? TenNCC.SelectedValue.ToString() : "1"
            );// Truyền giá trị mặc định là 1
            //TimHangHoa(TenHH.Text, TenLHH.SelectedValue.ToString(), TenNCC.SelectedValue.ToString());
        }
    }
}
