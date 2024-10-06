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
    public partial class frmNCC : Form
    {
        NCCControllers dal = new NCCControllers();
        private bool luu;
        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            HienThiNCC("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaNCC.Text = row.Cells[0].Value.ToString();
            txtTenNCC.Text = row.Cells[1].Value.ToString();
            txtDienThoai.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
        }
        private void HienThiNCC(string TenNV)
        {
            gridview.DataSource = dal.HienThi(TenNV);
            gridview.Columns[0].HeaderText = "Mã NCC";
            gridview.Columns[1].HeaderText = "Tên NCC";
            gridview.Columns[2].HeaderText = "Điện thoại";
            gridview.Columns[3].HeaderText = "Địa chỉ";

            int totalWidth = gridview.ClientSize.Width;

            gridview.Columns[0].Width = (int)(totalWidth * 0.2); 
            gridview.Columns[1].Width = (int)(totalWidth * 0.3); 
            gridview.Columns[2].Width = (int)(totalWidth * 0.2); 
            gridview.Columns[3].Width = (int)(totalWidth * 0.3); 
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            luu = false;
            txtMaNCC.Enabled = false;
            boolcontrols(false);
            txtMaNCC.Enabled = false;
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
            txtMaNCC.Enabled = !iss;
            txtTenNCC.Enabled = !iss;
            txtDiaChi.Enabled = !iss;
            txtDienThoai.Enabled = !iss;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridview.Rows.Count == 0)
                {
                    return;
                }
                DialogResult dr = MessageBox.Show("Có chắc chắn xóa NCC này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dal.Xoa(gridview.Rows[gridview.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiNCC("");
                    boolcontrols(true);
                }
                else
                    return;
            }
            
            catch (Exception ex)
                {
                MessageBox.Show($"Nhà cung cấp còn tồn tại sản phẩm, vui lòng xóa hết sản phẩm!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show($"Nhà cung cấp còn tồn tại sản phẩm, vui lòng xóa hết sản phẩm {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Có lỗi xảy ra khi xóa: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Mã NCC không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNCC.Focus();
                return;
            }
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Tên NCC không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNCC.Focus();
                return;
            }

            if (txtMaNCC.Text == "" || txtTenNCC.Text =="" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else
            {
                if (luu == true)
                {
                    try
                    {
                        dal.Them(txtMaNCC.Text.Trim(), txtTenNCC.Text.Trim(), txtDienThoai.Text.Trim(), txtDiaChi.Text.Trim());
                        MessageBox.Show("Thêm thành công.");
                        HienThiNCC("");
                        boolcontrols(true);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã NCC đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaNCC.Focus();
                        return;
                    }
                }
                else
                {
                    try
                    {
                        dal.Sua(txtMaNCC.Text.Trim(), txtTenNCC.Text.Trim(), txtDienThoai.Text.Trim(), txtDiaChi.Text.Trim());
                        MessageBox.Show("Sửa thành công.");
                        HienThiNCC("");
                        boolcontrols(true);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã NCC đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaNCC.Focus();
                        return;
                    }
                }
            }

            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HienThiNCC("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaNCC.Text = row.Cells[0].Value.ToString();
            txtTenNCC.Text = row.Cells[1].Value.ToString();
            txtDienThoai.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThiNCC("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaNCC.Text = row.Cells[0].Value.ToString();
            txtTenNCC.Text = row.Cells[1].Value.ToString();
            txtDienThoai.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiNCC(txtTenSearch.Text);
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
                txtDienThoai.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            boolcontrols(false);
            luu = true;
        }
        private void btnXemSP_Click(object sender, EventArgs e)
        {

            if (gridview.SelectedRows.Count > 0)
            {
                string maNCC = gridview.SelectedRows[0].Cells["MaNCC"].Value.ToString();

                HHNCC formHHNCC = new HHNCC(maNCC);
                formHHNCC.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXemSP_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = this.gridview.Rows[gridview.CurrentCell.RowIndex];
            string MaHD = txtMaNCC.Text;

            if (MaHD != "")
            {
                //string maNCC = gridview.SelectedRows[0].Cells["MaNCC"].Value.ToString();

                //HHNCC formHHNCC = new HHNCC(maNCC);
                HHNCC formHHNCC = new HHNCC(MaHD);
                formHHNCC.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTenSearch_TextChanged(object sender, EventArgs e)
        {
            HienThiNCC(txtTenSearch.Text);
        }
    }
}
