﻿using PhanMemQuanLyKhoThietBi.Controllers;
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
    public partial class frmKhachHang : Form
    {
        KhachHangControllers dal = new KhachHangControllers();
        private bool luu;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            boolcontrols(false);
            luu = true;
        }
        private void HienThiKH(string TenNV)
        {
            gridview.DataSource = dal.HienThi(TenNV);

            gridview.Columns[0].HeaderText = "Mã KH";
            gridview.Columns[1].HeaderText = "Tên KH";
            gridview.Columns[2].HeaderText = "Điện thoại";
            gridview.Columns[3].HeaderText = "Địa chỉ";

            int totalWidth = gridview.Width;

            gridview.Columns[0].Width = (int)(totalWidth * 0.20); 
            gridview.Columns[1].Width = (int)(totalWidth * 0.25); 
            gridview.Columns[2].Width = (int)(totalWidth * 0.20); 
            gridview.Columns[3].Width = (int)(totalWidth * 0.35); 
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiKH("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaKH.Text = row.Cells[0].Value.ToString();
            txtTenKH.Text = row.Cells[1].Value.ToString();
            txtDienThoai.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            luu = false;
            txtMaKH.Enabled = false;
            boolcontrols(false);
            txtMaKH.Enabled = false;
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
            txtMaKH.Enabled = !iss;
            txtTenKH.Enabled = !iss;
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
                DialogResult dr = MessageBox.Show("Có chắc chắn xóa KH này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dal.Xoa(gridview.Rows[gridview.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    HienThiKH("");
                    boolcontrols(true);
                }
                else
                    return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Khách hàng đã có dữ liệu. Không được phép xóa!", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Mã KH không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Tên KH không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
                return;
            }

            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else
            {
                if (luu == true)
                {
                    try
                    {
                        dal.Them(txtMaKH.Text.Trim(), txtTenKH.Text.Trim(), txtDienThoai.Text.Trim(), txtDiaChi.Text.Trim());
                        MessageBox.Show("Thêm thành công.");
                        HienThiKH("");
                        boolcontrols(true);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã KH đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaKH.Focus();
                        return;
                    }
                }
                else
                {
                    try
                    {
                        dal.Sua(txtMaKH.Text.Trim(), txtTenKH.Text.Trim(), txtDienThoai.Text.Trim(), txtDiaChi.Text.Trim());
                        MessageBox.Show("Sửa thành công.");
                        HienThiKH("");
                        boolcontrols(true);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã KH đã tồn tại, vui lòng tạo mã khác.", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaKH.Focus();
                        return;
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HienThiKH("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaKH.Text = row.Cells[0].Value.ToString();
            txtTenKH.Text = row.Cells[1].Value.ToString();
            txtDienThoai.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThiKH("");
            boolcontrols(true);
            if (gridview.Rows.Count == 0)
            {
                return;
            }
            var row = this.gridview.Rows[0];
            txtMaKH.Text = row.Cells[0].Value.ToString();
            txtTenKH.Text = row.Cells[1].Value.ToString();
            txtDienThoai.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            HienThiKH(searchText);
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtDienThoai.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXemSP_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.gridview.Rows[gridview.CurrentCell.RowIndex];
            string MaKH = txtMaKH.Text;

            if (MaKH!="")
            {
                //string maKhachHang = gridview.SelectedRows[0].Cells[0].Value.ToString();
                //frmHangHoaCuaKhachHang form = new frmHangHoaCuaKhachHang(maKhachHang);
                frmHangHoaCuaKhachHang form = new frmHangHoaCuaKhachHang(MaKH);
                form.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            HienThiKH(searchText);
        }
    }
}
