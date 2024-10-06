namespace PhanMemQuanLyKhoThietBi.Views
{
    partial class frmNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapKho));
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtNgayHD1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayHD2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGVChiTietNhapKho = new System.Windows.Forms.DataGridView();
            this.dtGVNhapKho = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnPhieuNhap = new System.Windows.Forms.Button();
            this.btnChiTietNhapKho = new System.Windows.Forms.Button();
            this.Ext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVChiTietNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(1019, 5);
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
            this.dtNgayHD1.Location = new System.Drawing.Point(613, 11);
            this.dtNgayHD1.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayHD1.Name = "dtNgayHD1";
            this.dtNgayHD1.Size = new System.Drawing.Size(157, 20);
            this.dtNgayHD1.TabIndex = 382;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(780, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 381;
            this.label2.Text = "Đến ngày";
            // 
            // dtNgayHD2
            // 
            this.dtNgayHD2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHD2.Location = new System.Drawing.Point(856, 11);
            this.dtNgayHD2.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayHD2.Name = "dtNgayHD2";
            this.dtNgayHD2.Size = new System.Drawing.Size(157, 20);
            this.dtNgayHD2.TabIndex = 380;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 379;
            this.label1.Text = "Từ ngày";
            // 
            // dtGVChiTietNhapKho
            // 
            this.dtGVChiTietNhapKho.AllowUserToAddRows = false;
            this.dtGVChiTietNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGVChiTietNhapKho.BackgroundColor = System.Drawing.Color.White;
            this.dtGVChiTietNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVChiTietNhapKho.Location = new System.Drawing.Point(3, 369);
            this.dtGVChiTietNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.dtGVChiTietNhapKho.Name = "dtGVChiTietNhapKho";
            this.dtGVChiTietNhapKho.ReadOnly = true;
            this.dtGVChiTietNhapKho.RowHeadersWidth = 51;
            this.dtGVChiTietNhapKho.Size = new System.Drawing.Size(1272, 257);
            this.dtGVChiTietNhapKho.TabIndex = 378;
            // 
            // dtGVNhapKho
            // 
            this.dtGVNhapKho.AllowUserToAddRows = false;
            this.dtGVNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGVNhapKho.BackgroundColor = System.Drawing.Color.White;
            this.dtGVNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVNhapKho.Location = new System.Drawing.Point(3, 50);
            this.dtGVNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.dtGVNhapKho.Name = "dtGVNhapKho";
            this.dtGVNhapKho.ReadOnly = true;
            this.dtGVNhapKho.RowHeadersWidth = 51;
            this.dtGVNhapKho.Size = new System.Drawing.Size(1272, 316);
            this.dtGVNhapKho.TabIndex = 377;
            this.dtGVNhapKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVNhapKho_CellClick);
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
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNhap.Location = new System.Drawing.Point(1060, 633);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(215, 53);
            this.btnPhieuNhap.TabIndex = 388;
            this.btnPhieuNhap.Text = "In phiếu nhập kho";
            this.btnPhieuNhap.UseVisualStyleBackColor = true;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // btnChiTietNhapKho
            // 
            this.btnChiTietNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietNhapKho.Location = new System.Drawing.Point(839, 633);
            this.btnChiTietNhapKho.Name = "btnChiTietNhapKho";
            this.btnChiTietNhapKho.Size = new System.Drawing.Size(215, 53);
            this.btnChiTietNhapKho.TabIndex = 389;
            this.btnChiTietNhapKho.Text = "Chi tiết phiếu nhập kho";
            this.btnChiTietNhapKho.UseVisualStyleBackColor = true;
            this.btnChiTietNhapKho.Click += new System.EventHandler(this.btnChiTietNhapKho_Click);
            // 
            // Ext
            // 
            this.Ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ext.Location = new System.Drawing.Point(1154, 5);
            this.Ext.Margin = new System.Windows.Forms.Padding(4);
            this.Ext.Name = "Ext";
            this.Ext.Size = new System.Drawing.Size(121, 37);
            this.Ext.TabIndex = 390;
            this.Ext.TabStop = false;
            this.Ext.Text = "Thoát";
            this.Ext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ext.UseVisualStyleBackColor = true;
            this.Ext.Click += new System.EventHandler(this.Ext_Click);
            // 
            // frmNhapKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1277, 738);
            this.Controls.Add(this.Ext);
            this.Controls.Add(this.btnChiTietNhapKho);
            this.Controls.Add(this.btnPhieuNhap);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtNgayHD1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtNgayHD2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGVChiTietNhapKho);
            this.Controls.Add(this.dtGVNhapKho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu xuất kho";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVChiTietNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNhapKho)).EndInit();
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
        private System.Windows.Forms.DataGridView dtGVChiTietNhapKho;
        private System.Windows.Forms.DataGridView dtGVNhapKho;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnPhieuNhap;
        private System.Windows.Forms.Button btnChiTietNhapKho;
        private System.Windows.Forms.Button Ext;
    }

    
}