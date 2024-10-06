namespace PhanMemQuanLyKhoThietBi.Views
{
    partial class frmXuatKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatKho));
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtNgayHD1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayHD2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGVChiTietXuatKho = new System.Windows.Forms.DataGridView();
            this.dtGVXuatKho = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnPhieuXuat = new System.Windows.Forms.Button();
            this.btnChiTietXuatKho = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.tbnKH = new System.Windows.Forms.Button();
            this.Ext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVChiTietXuatKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVXuatKho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(1021, 7);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(121, 37);
            this.btnTim.TabIndex = 386;
            this.btnTim.TabStop = false;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(261, 7);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 37);
            this.btnXoa.TabIndex = 385;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(132, 7);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 37);
            this.btnSua.TabIndex = 384;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(7, 7);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 37);
            this.btnThem.TabIndex = 383;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtNgayHD1
            // 
            this.dtNgayHD1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHD1.Location = new System.Drawing.Point(615, 13);
            this.dtNgayHD1.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayHD1.Name = "dtNgayHD1";
            this.dtNgayHD1.Size = new System.Drawing.Size(157, 20);
            this.dtNgayHD1.TabIndex = 382;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 381;
            this.label2.Text = "Đến ngày";
            // 
            // dtNgayHD2
            // 
            this.dtNgayHD2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHD2.Location = new System.Drawing.Point(858, 13);
            this.dtNgayHD2.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayHD2.Name = "dtNgayHD2";
            this.dtNgayHD2.Size = new System.Drawing.Size(157, 20);
            this.dtNgayHD2.TabIndex = 380;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 379;
            this.label1.Text = "Từ ngày";
            // 
            // dtGVChiTietXuatKho
            // 
            this.dtGVChiTietXuatKho.AllowUserToAddRows = false;
            this.dtGVChiTietXuatKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGVChiTietXuatKho.BackgroundColor = System.Drawing.Color.White;
            this.dtGVChiTietXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVChiTietXuatKho.Location = new System.Drawing.Point(2, 369);
            this.dtGVChiTietXuatKho.Margin = new System.Windows.Forms.Padding(4);
            this.dtGVChiTietXuatKho.Name = "dtGVChiTietXuatKho";
            this.dtGVChiTietXuatKho.ReadOnly = true;
            this.dtGVChiTietXuatKho.RowHeadersWidth = 51;
            this.dtGVChiTietXuatKho.Size = new System.Drawing.Size(1272, 257);
            this.dtGVChiTietXuatKho.TabIndex = 378;
            // 
            // dtGVXuatKho
            // 
            this.dtGVXuatKho.AllowUserToAddRows = false;
            this.dtGVXuatKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGVXuatKho.BackgroundColor = System.Drawing.Color.White;
            this.dtGVXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVXuatKho.Location = new System.Drawing.Point(3, 50);
            this.dtGVXuatKho.Margin = new System.Windows.Forms.Padding(4);
            this.dtGVXuatKho.Name = "dtGVXuatKho";
            this.dtGVXuatKho.ReadOnly = true;
            this.dtGVXuatKho.RowHeadersWidth = 51;
            this.dtGVXuatKho.Size = new System.Drawing.Size(1272, 311);
            this.dtGVXuatKho.TabIndex = 377;
            this.dtGVXuatKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVXuatKho_CellClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(389, 7);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(144, 37);
            this.btnThanhToan.TabIndex = 387;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuXuat.Location = new System.Drawing.Point(1050, 644);
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.Size = new System.Drawing.Size(215, 53);
            this.btnPhieuXuat.TabIndex = 388;
            this.btnPhieuXuat.Text = "In phiếu xuất kho";
            this.btnPhieuXuat.UseVisualStyleBackColor = true;
            this.btnPhieuXuat.Click += new System.EventHandler(this.btnPhieuXuat_Click);
            // 
            // btnChiTietXuatKho
            // 
            this.btnChiTietXuatKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietXuatKho.Location = new System.Drawing.Point(829, 644);
            this.btnChiTietXuatKho.Name = "btnChiTietXuatKho";
            this.btnChiTietXuatKho.Size = new System.Drawing.Size(215, 53);
            this.btnChiTietXuatKho.TabIndex = 389;
            this.btnChiTietXuatKho.Text = "Chi tiết phiếu xuất kho";
            this.btnChiTietXuatKho.UseVisualStyleBackColor = true;
            this.btnChiTietXuatKho.Click += new System.EventHandler(this.btnChiTietXuatKho_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 663);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 391;
            this.label4.Text = "Tên/Điện thoại";
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(172, 663);
            this.txtKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(253, 20);
            this.txtKH.TabIndex = 390;
            // 
            // tbnKH
            // 
            this.tbnKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnKH.Location = new System.Drawing.Point(452, 654);
            this.tbnKH.Margin = new System.Windows.Forms.Padding(4);
            this.tbnKH.Name = "tbnKH";
            this.tbnKH.Size = new System.Drawing.Size(121, 37);
            this.tbnKH.TabIndex = 392;
            this.tbnKH.TabStop = false;
            this.tbnKH.Text = "Tìm";
            this.tbnKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbnKH.UseVisualStyleBackColor = true;
            this.tbnKH.Click += new System.EventHandler(this.tbnKH_Click);
            // 
            // Ext
            // 
            this.Ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ext.Location = new System.Drawing.Point(1150, 7);
            this.Ext.Margin = new System.Windows.Forms.Padding(4);
            this.Ext.Name = "Ext";
            this.Ext.Size = new System.Drawing.Size(121, 37);
            this.Ext.TabIndex = 393;
            this.Ext.TabStop = false;
            this.Ext.Text = "Thoát";
            this.Ext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ext.UseVisualStyleBackColor = true;
            this.Ext.Click += new System.EventHandler(this.Ext_Click);
            // 
            // frmXuatKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1277, 738);
            this.Controls.Add(this.Ext);
            this.Controls.Add(this.tbnKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.btnChiTietXuatKho);
            this.Controls.Add(this.btnPhieuXuat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtNgayHD1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtNgayHD2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGVChiTietXuatKho);
            this.Controls.Add(this.dtGVXuatKho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXuatKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu xuất kho";
            this.Load += new System.EventHandler(this.frmXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVChiTietXuatKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVXuatKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtNgayHD1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayHD2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGVChiTietXuatKho;
        private System.Windows.Forms.DataGridView dtGVXuatKho;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnPhieuXuat;
        private System.Windows.Forms.Button btnChiTietXuatKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Button tbnKH;
        private System.Windows.Forms.Button Ext;
    }
}