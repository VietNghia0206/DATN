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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        DangNhapControllers dal = new DangNhapControllers();
        private bool luu;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiNhanVien("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtMatKhau.Text = row.Cells[2].Value.ToString();
            txtDienThoai.Text = row.Cells[3].Value.ToString();
            txtDiaChi.Text = row.Cells[4].Value.ToString();
        }
        private void HienThiNhanVien(string TenNV)
        {
            gridview.DataSource = dal.HienThi(TenNV);

            gridview.Columns[0].HeaderText = "Mã nhân viên";
            gridview.Columns[1].HeaderText = "Tên nhân viên";
            gridview.Columns[2].HeaderText = "Mật khẩu";
            gridview.Columns[3].HeaderText = "Điện thoại";
            gridview.Columns[4].HeaderText = "Địa chỉ";

            int totalWidth = gridview.Width;

            gridview.Columns[0].Width = (int)(totalWidth * 0.20); 
            gridview.Columns[1].Width = (int)(totalWidth * 0.25); 
            gridview.Columns[2].Width = (int)(totalWidth * 0.15); 
            gridview.Columns[3].Width = (int)(totalWidth * 0.20); 
            gridview.Columns[4].Width = (int)(totalWidth * 0.20); 
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtMatKhau.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            boolcontrols(false);
            luu = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            luu = false;
            txtMaNV.Enabled = false;
            boolcontrols(false);
            txtMaNV.Enabled = false;
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
            txtMaNV.Enabled = !iss;
            txtTenNV.Enabled = !iss;
            txtMatKhau.Enabled = !iss;
            txtDiaChi.Enabled = !iss;
            txtDienThoai.Enabled = !iss;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa nhân viên này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    dal.Xoa(gridview.Rows[gridview.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiNhanVien("");
                    boolcontrols(true);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Tài khoản đã thực hiện giao dịch. Không thể xóa", "Thông báo");
                }
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNV.Focus();
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }
            if (luu == true)
            {
                try
                {
                    dal.Them(txtMaNV.Text.Trim(), txtTenNV.Text.Trim(), txtMatKhau.Text.Trim(), txtDienThoai.Text.Trim(), txtDiaChi.Text.Trim());
                    MessageBox.Show("Thêm thành công.");
                    HienThiNhanVien("");
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNV.Focus();
                    return;
                }
            }
            else
            {
                try
                {
                    dal.Sua(txtMaNV.Text.Trim(), txtTenNV.Text.Trim(), txtMatKhau.Text.Trim(), txtDienThoai.Text.Trim(), txtDiaChi.Text.Trim());
                    MessageBox.Show("Sửa thành công.");
                    HienThiNhanVien("");
                    boolcontrols(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNV.Focus();
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HienThiNhanVien("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtMatKhau.Text = row.Cells[2].Value.ToString();
            txtDienThoai.Text = row.Cells[3].Value.ToString();
            txtDiaChi.Text = row.Cells[4].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThiNhanVien("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtMatKhau.Text = row.Cells[2].Value.ToString();
            txtDienThoai.Text = row.Cells[3].Value.ToString();
            txtDiaChi.Text = row.Cells[4].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiNhanVien(txtTenNVSearch.Text);
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtMatKhau.Text = row.Cells[2].Value.ToString();
                txtDienThoai.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
