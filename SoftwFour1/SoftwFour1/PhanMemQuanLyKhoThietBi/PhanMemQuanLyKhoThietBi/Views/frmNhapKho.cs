
using PhanMemQuanLyKhoThietBi.Controllers;
using PhanMemQuanLyKhoThietBi.Models;
using PhanMemQuanLyKhoThietBi.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DevExpress.XtraReports.UI;

namespace PhanMemQuanLyKhoThietBi.Views
{
    public partial class frmNhapKho : Form
    {
        public frmNhapKho()
        {
            InitializeComponent();
            btnPhieuNhap.Visible = false;
        }
        NhapKhoControllers db = new NhapKhoControllers();
        DataTable dt;
        DataTable dt2;
        public static Boolean save;
        public static string mahd;
        public static string mancc;
        public static DateTime NgayHD;
        public static string manv;
        public static string tennv;
        public static string tongtien;
        public static string trangthai;
        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            HienThiNhapKho();
            if (dtGVNhapKho.Rows.Count > 0)
            {
                var row = this.dtGVNhapKho.Rows[0];
                HienThiChiTietNhapKho(row.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietNhapKho("");
            }
        }
        private void HienThiNhapKho()
        {
            dt = db.HienThiNhapKho(dtNgayHD1.Value.ToString("yyyyMMdd"), dtNgayHD2.Value.ToString("yyyyMMdd"));
            dtGVNhapKho.DataSource = dt;

            dtGVNhapKho.Columns[0].HeaderText = "Mã hóa đơn";
            dtGVNhapKho.Columns[1].HeaderText = "Ngày lập";
            dtGVNhapKho.Columns[2].HeaderText = "Mã NCC";
            dtGVNhapKho.Columns[3].HeaderText = "Tên NCC";
            dtGVNhapKho.Columns[4].HeaderText = "Mã NV";
            dtGVNhapKho.Columns[5].HeaderText = "Tên NV";
            dtGVNhapKho.Columns[6].HeaderText = "Tổng tiền";
            dtGVNhapKho.Columns[7].HeaderText = "Trạng thái";

            int totalWidth = dtGVNhapKho.Width;

            dtGVNhapKho.Columns[0].Width = (int)(totalWidth * 0.15);
            dtGVNhapKho.Columns[1].Width = (int)(totalWidth * 0.15);
            dtGVNhapKho.Columns[2].Width = (int)(totalWidth * 0.10);
            dtGVNhapKho.Columns[3].Width = (int)(totalWidth * 0.15);
            dtGVNhapKho.Columns[4].Width = (int)(totalWidth * 0.10);
            dtGVNhapKho.Columns[5].Width = (int)(totalWidth * 0.10);
            dtGVNhapKho.Columns[6].Width = (int)(totalWidth * 0.15);
            dtGVNhapKho.Columns[7].Width = (int)(totalWidth * 0.10);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HienThiNhapKho();
            if (dtGVNhapKho.Rows.Count > 0)
            {
                var row = this.dtGVNhapKho.Rows[0];
                HienThiChiTietNhapKho(row.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietNhapKho("");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            save = true;
            frmNhapKhoInfor frm = new frmNhapKhoInfor();
            frm.Text = "Lập phiếu xuất";
            frm.ShowDialog();
            HienThiNhapKho();
            if (dtGVNhapKho.Rows.Count > 0)
            {
                var row = this.dtGVNhapKho.Rows[0];
                HienThiChiTietNhapKho(row.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietNhapKho("");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtGVNhapKho.Rows.Count == 0)
            {
                return;
            }

            DataGridViewRow row = this.dtGVNhapKho.Rows[dtGVNhapKho.CurrentCell.RowIndex];
            save = false;

            mahd = row.Cells[0].Value.ToString();
            NgayHD = DateTime.Parse(row.Cells[1].Value.ToString());
            mancc = row.Cells[2].Value.ToString();
            manv = row.Cells[4].Value.ToString();
            tennv = row.Cells[5].Value.ToString();
            tongtien = row.Cells[6].Value.ToString();
            trangthai = row.Cells[7].Value.ToString();
            if (trangthai == "Đã thanh toán")
            {
                MessageBox.Show("Phiếu này đã được thanh toán, không được sửa.");
                return;
            }
            frmNhapKhoInfor frm = new frmNhapKhoInfor();
            frm.Text = "Sửa phiếu";
            frm.ShowDialog();
            HienThiNhapKho();
            if (dtGVNhapKho.Rows.Count > 0)
            {
                var row2 = this.dtGVNhapKho.Rows[0];
                HienThiChiTietNhapKho(row2.Cells["MaHD"].Value.ToString());
            }
            else
            {
                HienThiChiTietNhapKho("");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtGVNhapKho.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtGVNhapKho.Rows[dtGVNhapKho.CurrentCell.RowIndex];
            trangthai = row.Cells[7].Value.ToString();
            if (trangthai == "Đã thanh toán")
            {
                MessageBox.Show("Phiếu này đã được thanh toán, không được xóa.");
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Xoa(dtGVNhapKho.Rows[dtGVNhapKho.CurrentCell.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                HienThiNhapKho();
                if (dtGVNhapKho.Rows.Count > 0)
                {
                    var row2 = this.dtGVNhapKho.Rows[0];
                    HienThiChiTietNhapKho(row2.Cells["Mahd"].Value.ToString());
                }
                else
                {
                    HienThiChiTietNhapKho("");
                }
            }
            else
                return;
        }

        private void HienThiChiTietNhapKho(string value)
        {
            dt2 = db.HienThiChiTietNhapKho(value);
            dtGVChiTietNhapKho.DataSource = dt2;

            dtGVChiTietNhapKho.Columns[0].HeaderText = "Mã hóa đơn";
            dtGVChiTietNhapKho.Columns[1].HeaderText = "Mã hàng hóa";
            dtGVChiTietNhapKho.Columns[2].HeaderText = "Tên hàng hóa";
            dtGVChiTietNhapKho.Columns[3].HeaderText = "Đơn giá";
            dtGVChiTietNhapKho.Columns[4].HeaderText = "Số lượng";
            dtGVChiTietNhapKho.Columns[5].HeaderText = "Thành tiền";

            int totalWidth = dtGVChiTietNhapKho.Width;

            dtGVChiTietNhapKho.Columns[0].Width = (int)(totalWidth * 0.20);
            dtGVChiTietNhapKho.Columns[1].Width = (int)(totalWidth * 0.15);
            dtGVChiTietNhapKho.Columns[2].Width = (int)(totalWidth * 0.25);
            dtGVChiTietNhapKho.Columns[3].Width = (int)(totalWidth * 0.15);
            dtGVChiTietNhapKho.Columns[4].Width = (int)(totalWidth * 0.15);
            dtGVChiTietNhapKho.Columns[5].Width = (int)(totalWidth * 0.10);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtGVNhapKho.Rows.Count == 0)
            {
                return;
            }

            DataGridViewRow row1 = this.dtGVNhapKho.Rows[dtGVNhapKho.CurrentCell.RowIndex];
            trangthai = row1.Cells[7].Value.ToString();
            //MessageBox.Show("Trạng thái ." + trangthai);
            if (trangthai != "Đã thanh toán")
            {
                DataGridViewRow row = this.dtGVNhapKho.Rows[dtGVNhapKho.CurrentCell.RowIndex];
                DialogResult ok = MessageBox.Show("Bạn có muốn tính tiền cho phiếu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ok == DialogResult.Yes)
                {
                    MessageBox.Show("TỔNG SỐ TIỀN THANH TOÁN LÀ " + row.Cells[6].Value.ToString(), "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    for (int i = 0; i < dtGVChiTietNhapKho.Rows.Count; i++)
                    {
                        db.UpdateTonKho(decimal.Parse(dtGVChiTietNhapKho.Rows[i].Cells["SoLuong"].Value.ToString()), dtGVChiTietNhapKho.Rows[i].Cells["MaHH"].Value.ToString());
                    }

                    db.UpdateTrangThaiSauThanhToan(row.Cells[0].Value.ToString());
                    HienThiNhapKho();

                    if (dtGVNhapKho.Rows.Count > 0)
                    {
                        var rowx = this.dtGVNhapKho.Rows[0];
                        HienThiChiTietNhapKho(rowx.Cells["MaHD"].Value.ToString());
                    }
                    else
                    {
                        HienThiChiTietNhapKho("");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Phiếu này đã được thanh toán.");
                return;
            }
            
        }

        private void dtGVNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGVNhapKho.Rows[e.RowIndex];
                trangthai = row.Cells[7].Value.ToString();
                HienThiChiTietNhapKho(row.Cells[0].Value.ToString());
            }
        }

        private void btnChiTietNhapKho_Click(object sender, EventArgs e)
        {
            if (dtGVNhapKho.Rows.Count > 0)
            {
                string maHD = dtGVNhapKho.Rows[dtGVNhapKho.CurrentCell.RowIndex].Cells["MaHD"].Value.ToString();
                DataTable dtChiTiet = db.GetChiTietNhapKhoForReport(maHD);

                XRptChiTietNhapKho report = new XRptChiTietNhapKho();
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

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            XtraReport1 report = new XtraReport1();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();


        }

        private void Ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
