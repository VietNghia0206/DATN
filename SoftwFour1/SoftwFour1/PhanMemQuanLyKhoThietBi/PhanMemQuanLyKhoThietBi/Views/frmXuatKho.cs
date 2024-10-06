﻿using DevExpress.XtraReports.UI;
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
    public partial class frmXuatKho : Form
    {
        public frmXuatKho()
        {
            InitializeComponent();
            btnPhieuXuat.Visible = false;
        }
        XuatKhoControllers db = new XuatKhoControllers();
        DataTable dt;
        DataTable dt2;
        public static Boolean save;
        public static string mahd;
        public static string makh;
        public static DateTime ngayban;
        public static string manv;
        public static string tennv;
        public static string tongtien;
        public static string trangthai;
        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            HienThiXuatKho();
            if (dtGVXuatKho.Rows.Count > 0)
            {
                var row = this.dtGVXuatKho.Rows[0];
                HienThiChiTietXuatKho(row.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietXuatKho("");
            }
        }
        private void HienThiXuatKho()
        {
            dt = db.HienThiXuatKho(dtNgayHD1.Value.ToString("yyyyMMdd"), dtNgayHD2.Value.ToString("yyyyMMdd"));
            dtGVXuatKho.DataSource = dt;

            dtGVXuatKho.Columns[0].HeaderText = "Mã hóa đơn";
            dtGVXuatKho.Columns[1].HeaderText = "Ngày lập";
            dtGVXuatKho.Columns[2].HeaderText = "Mã KH";
            dtGVXuatKho.Columns[3].HeaderText = "Tên KH";
            dtGVXuatKho.Columns[4].HeaderText = "Mã NV";
            dtGVXuatKho.Columns[5].HeaderText = "Tên NV";
            dtGVXuatKho.Columns[6].HeaderText = "Tổng tiền";
            dtGVXuatKho.Columns[7].HeaderText = "Trạng thái";

            int totalWidth = dtGVXuatKho.Width;

            dtGVXuatKho.Columns[0].Width = (int)(totalWidth * 0.15);
            dtGVXuatKho.Columns[1].Width = (int)(totalWidth * 0.15);
            dtGVXuatKho.Columns[2].Width = (int)(totalWidth * 0.10);
            dtGVXuatKho.Columns[3].Width = (int)(totalWidth * 0.15);
            dtGVXuatKho.Columns[4].Width = (int)(totalWidth * 0.10);
            dtGVXuatKho.Columns[5].Width = (int)(totalWidth * 0.10);
            dtGVXuatKho.Columns[6].Width = (int)(totalWidth * 0.15);
            dtGVXuatKho.Columns[7].Width = (int)(totalWidth * 0.10);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiXuatKho();
            if (dtGVXuatKho.Rows.Count > 0)
            {
                var row = this.dtGVXuatKho.Rows[0];
                HienThiChiTietXuatKho(row.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietXuatKho("");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            save = true;
            frmXuatKhoInfor frm = new frmXuatKhoInfor();
            frm.Text = "Lập phiếu xuất";
            frm.ShowDialog();
            HienThiXuatKho();
            if (dtGVXuatKho.Rows.Count > 0)
            {
                var row = this.dtGVXuatKho.Rows[0];
                HienThiChiTietXuatKho(row.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietXuatKho("");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtGVXuatKho.Rows.Count == 0)
            {
                return;
            }

            DataGridViewRow row = this.dtGVXuatKho.Rows[dtGVXuatKho.CurrentCell.RowIndex];
            save = false;

            mahd = row.Cells[0].Value.ToString();
            ngayban = DateTime.Parse(row.Cells[1].Value.ToString());
            makh = row.Cells[2].Value.ToString();
            manv = row.Cells[4].Value.ToString();
            tennv = row.Cells[5].Value.ToString();
            tongtien = row.Cells[6].Value.ToString();
            trangthai = row.Cells[7].Value.ToString();
            if (trangthai == "Đã thanh toán")
            {
                MessageBox.Show("Phiếu này đã được thanh toán, không được sửa.");
                return;
            }
            frmXuatKhoInfor frm = new frmXuatKhoInfor();
            frm.Text = "Sửa phiếu";
            frm.ShowDialog();
            HienThiXuatKho();
            if (dtGVXuatKho.Rows.Count > 0)
            {
                var row2 = this.dtGVXuatKho.Rows[0];
                HienThiChiTietXuatKho(row2.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietXuatKho("");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtGVXuatKho.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtGVXuatKho.Rows[dtGVXuatKho.CurrentCell.RowIndex];
            trangthai = row.Cells[7].Value.ToString();
            if (trangthai == "Đã thanh toán")
            {
                MessageBox.Show("Phiếu này đã được thanh toán, không được xóa.");
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Xoa(dtGVXuatKho.Rows[dtGVXuatKho.CurrentCell.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                HienThiXuatKho();
                if (dtGVXuatKho.Rows.Count > 0)
                {
                    var row2 = this.dtGVXuatKho.Rows[0];
                    HienThiChiTietXuatKho(row2.Cells["Mahd"].Value.ToString());
                }
                else
                {
                    HienThiChiTietXuatKho("");
                }
            }
            else
                return;
        }

        private void HienThiChiTietXuatKho(string value)
        {
            dt2 = db.HienThiChiTietXuatKho(value);
            dtGVChiTietXuatKho.DataSource = dt2;

            dtGVChiTietXuatKho.Columns[0].HeaderText = "Mã hóa đơn";
            dtGVChiTietXuatKho.Columns[1].HeaderText = "Mã hàng hóa";
            dtGVChiTietXuatKho.Columns[2].HeaderText = "Tên hàng hóa";
            dtGVChiTietXuatKho.Columns[3].HeaderText = "Đơn giá";
            dtGVChiTietXuatKho.Columns[4].HeaderText = "Số lượng";
            dtGVChiTietXuatKho.Columns[5].HeaderText = "Thành tiền";

            int totalWidth = dtGVChiTietXuatKho.Width;

            dtGVChiTietXuatKho.Columns[0].Width = (int)(totalWidth * 0.20);
            dtGVChiTietXuatKho.Columns[1].Width = (int)(totalWidth * 0.15);
            dtGVChiTietXuatKho.Columns[2].Width = (int)(totalWidth * 0.25);
            dtGVChiTietXuatKho.Columns[3].Width = (int)(totalWidth * 0.15);
            dtGVChiTietXuatKho.Columns[4].Width = (int)(totalWidth * 0.15);
            dtGVChiTietXuatKho.Columns[5].Width = (int)(totalWidth * 0.10);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtGVXuatKho.Rows.Count == 0)
            {
                return;
            }

            DataGridViewRow row1 = this.dtGVXuatKho.Rows[dtGVXuatKho.CurrentCell.RowIndex];
            trangthai = row1.Cells[7].Value.ToString();

            if (trangthai != "Đã thanh toán")
            {
                DataGridViewRow row = this.dtGVXuatKho.Rows[dtGVXuatKho.CurrentCell.RowIndex];
                DialogResult ok = MessageBox.Show("Bạn có muốn tính tiền cho khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ok == DialogResult.Yes)
                {
                    MessageBox.Show("TỔNG SỐ TIỀN THANH TOÁN LÀ " + row.Cells[6].Value.ToString(), "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    for (int i = 0; i < dtGVChiTietXuatKho.Rows.Count; i++)
                    {
                        db.UpdateTonKho(decimal.Parse(dtGVChiTietXuatKho.Rows[i].Cells["SoLuong"].Value.ToString()), dtGVChiTietXuatKho.Rows[i].Cells["MaHH"].Value.ToString());
                    }

                    db.UpdateTrangThaiSauThanhToan(row.Cells[0].Value.ToString());
                    HienThiXuatKho();

                    if (dtGVXuatKho.Rows.Count > 0)
                    {
                        var rowx = this.dtGVXuatKho.Rows[0];
                        HienThiChiTietXuatKho(rowx.Cells["MaHD"].Value.ToString());
                    }
                    else
                    {
                        HienThiChiTietXuatKho("");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Phiếu này đã được thanh toán.");
                return;
            }
        }

        private void dtGVXuatKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGVXuatKho.Rows[e.RowIndex];
                trangthai = row.Cells[7].Value.ToString();
                HienThiChiTietXuatKho(row.Cells[0].Value.ToString());
            }
        }

        private void btnChiTietXuatKho_Click(object sender, EventArgs e)
        {
            if (dtGVXuatKho.Rows.Count > 0)
            {
                string maHD = dtGVXuatKho.Rows[dtGVXuatKho.CurrentCell.RowIndex].Cells["MaHD"].Value.ToString();
                DataTable dtChiTiet = db.GetChiTietXuatKhoForReport(maHD);

                XRptChiTietXuatKho report = new XRptChiTietXuatKho();
                report.DataSource = dtChiTiet;
                report.DataMember = "Table"; 

                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreview();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập kho để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            XRpXuatKho report = new XRpXuatKho();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }

        private void HienThiKH()
        {
            dt = db.HienThi_KH(txtKH.Text);
            dtGVXuatKho.DataSource = dt;

            dtGVXuatKho.Columns[0].HeaderText = "Mã hóa đơn";
            dtGVXuatKho.Columns[1].HeaderText = "Ngày lập";
            dtGVXuatKho.Columns[2].HeaderText = "Mã KH";
            dtGVXuatKho.Columns[3].HeaderText = "Tên KH";
            dtGVXuatKho.Columns[4].HeaderText = "Mã NV";
            dtGVXuatKho.Columns[5].HeaderText = "Tên NV";
            dtGVXuatKho.Columns[6].HeaderText = "Tổng tiền";
            dtGVXuatKho.Columns[7].HeaderText = "Trạng thái";

            int totalWidth = dtGVXuatKho.Width;

            dtGVXuatKho.Columns[0].Width = (int)(totalWidth * 0.15);
            dtGVXuatKho.Columns[1].Width = (int)(totalWidth * 0.15);
            dtGVXuatKho.Columns[2].Width = (int)(totalWidth * 0.10);
            dtGVXuatKho.Columns[3].Width = (int)(totalWidth * 0.15);
            dtGVXuatKho.Columns[4].Width = (int)(totalWidth * 0.10);
            dtGVXuatKho.Columns[5].Width = (int)(totalWidth * 0.10);
            dtGVXuatKho.Columns[6].Width = (int)(totalWidth * 0.15);
            dtGVXuatKho.Columns[7].Width = (int)(totalWidth * 0.10);
        }
        private void tbnKH_Click(object sender, EventArgs e)
        {
            HienThiKH();
            if (dtGVXuatKho.Rows.Count > 0)
            {
                var row = this.dtGVXuatKho.Rows[0];
                HienThiChiTietXuatKho(row.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietXuatKho("");
            }
        }

        private void Ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
