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
    public partial class frmLHH : Form
    {
        LHHControllers dal = new LHHControllers();
        private bool luu;
        public frmLHH()
        {
            InitializeComponent();
        }
        private void HienThiLHH(string TenNV)
        {
            gridview.DataSource = dal.HienThi(TenNV);

            gridview.Columns[0].HeaderText = "Mã LHH";
            gridview.Columns[1].HeaderText = "Tên LHH";

            int totalWidth = gridview.Width;

            gridview.Columns[0].Width = (int)(totalWidth * 0.30); 
            gridview.Columns[1].Width = (int)(totalWidth * 0.70);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLHH.Text = "";
            txtTenLHH.Text = "";
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
            txtMaLHH.Enabled = false;
            boolcontrols(false);
            txtMaLHH.Enabled = false;
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
            txtMaLHH.Enabled = !iss;
            txtTenLHH.Enabled = !iss;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Có chắc chắn xóa LHH này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    var idToDelete = gridview.Rows[gridview.CurrentCell.RowIndex].Cells[0].Value?.ToString();
                    if (string.IsNullOrEmpty(idToDelete))
                    {
                        MessageBox.Show("ID không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dal.Xoa(idToDelete);
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiLHH("");
                    boolcontrols(true);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Danh mục còn tồn tại sản phẩm, vui lòng xóa hết sản phẩm!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show($"Danh mục còn tồn tại sản phẩm, vui lòng xóa hết sản phẩm {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLHH.Text == "")
            {
                MessageBox.Show("Mã LHH không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLHH.Focus();
                return;
            }
            if (txtTenLHH.Text == "")
            {
                MessageBox.Show("Tên LHH không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLHH.Focus();
                return;
            }

            if (txtMaLHH.Text =="" || txtTenLHH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else
            {
                if (luu == true)
                {
                    try
                    {
                        dal.Them(txtMaLHH.Text.Trim(), txtTenLHH.Text.Trim());
                        MessageBox.Show("Thêm thành công.");
                        HienThiLHH("");
                        boolcontrols(true);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã LHH đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaLHH.Focus();
                        return;
                    }
                }
                else
                {
                    try
                    {
                        dal.Sua(txtMaLHH.Text.Trim(), txtTenLHH.Text.Trim());
                        MessageBox.Show("Sửa thành công.");
                        HienThiLHH("");
                        boolcontrols(true);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã LHH đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaLHH.Focus();
                        return;
                    }
                }
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HienThiLHH("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaLHH.Text = row.Cells[0].Value.ToString();
            txtTenLHH.Text = row.Cells[1].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThiLHH("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaLHH.Text = row.Cells[0].Value.ToString();
            txtTenLHH.Text = row.Cells[1].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiLHH(txtTenSearch.Text);
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaLHH.Text = row.Cells[0].Value.ToString();
                txtTenLHH.Text = row.Cells[1].Value.ToString();
            }
        }

        private void frmLHH_Load(object sender, EventArgs e)
        {
            HienThiLHH("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaLHH.Text = row.Cells[0].Value.ToString();
            txtTenLHH.Text = row.Cells[1].Value.ToString();
        }

        private void btnXemSP_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.gridview.Rows[gridview.CurrentCell.RowIndex];
            string MaHD = txtMaLHH.Text;

            if (MaHD != "")
            {
                //string maNCC = gridview.SelectedRows[0].Cells["MaNCC"].Value.ToString();

                //HHNCC formHHNCC = new HHNCC(maNCC);
                HHLHH formHHLHH = new HHLHH(MaHD);
                formHHLHH.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại hàng hóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
