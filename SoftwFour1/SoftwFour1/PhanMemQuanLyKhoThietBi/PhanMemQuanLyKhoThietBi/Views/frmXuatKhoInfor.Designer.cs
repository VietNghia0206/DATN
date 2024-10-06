namespace PhanMemQuanLyKhoThietBi.Views
{
    partial class frmXuatKhoInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatKhoInfor));
            this.grdCTHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayHD = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nmsoluong = new System.Windows.Forms.NumericUpDown();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grdHangHoa = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenhh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.GrvKH = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TenNCC = new System.Windows.Forms.ComboBox();
            this.TenLHH = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmsoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCTHD
            // 
            this.grdCTHD.AllowUserToAddRows = false;
            this.grdCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCTHD.BackgroundColor = System.Drawing.Color.White;
            this.grdCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCTHD.Location = new System.Drawing.Point(576, 417);
            this.grdCTHD.Margin = new System.Windows.Forms.Padding(5);
            this.grdCTHD.Name = "grdCTHD";
            this.grdCTHD.ReadOnly = true;
            this.grdCTHD.RowHeadersWidth = 51;
            this.grdCTHD.Size = new System.Drawing.Size(769, 155);
            this.grdCTHD.TabIndex = 310;
            this.grdCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCTHD_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(578, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 311;
            this.label1.Text = "Chi tiết hóa đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(48, 623);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(163, 54);
            this.btnThanhToan.TabIndex = 312;
            this.btnThanhToan.Tag = "L006";
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.White;
            this.txtTongTien.Location = new System.Drawing.Point(218, 507);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(272, 20);
            this.txtTongTien.TabIndex = 313;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 512);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 315;
            this.label9.Text = "Tổng tiền";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 563);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 316;
            this.label8.Text = "Ngày lập phiếu";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(218, 533);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(5);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(272, 20);
            this.txtmanv.TabIndex = 314;
            this.txtmanv.TextChanged += new System.EventHandler(this.txtmanv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 537);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 317;
            this.label2.Text = "Tên nhân viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtNgayHD
            // 
            this.dtNgayHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHD.Location = new System.Drawing.Point(218, 560);
            this.dtNgayHD.Margin = new System.Windows.Forms.Padding(5);
            this.dtNgayHD.Name = "dtNgayHD";
            this.dtNgayHD.Size = new System.Drawing.Size(272, 20);
            this.dtNgayHD.TabIndex = 318;
            this.dtNgayHD.ValueChanged += new System.EventHandler(this.dtNgayHD_ValueChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1220, 338);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 37);
            this.btnXoa.TabIndex = 374;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(578, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 308;
            this.label4.Text = "Nhập số lượng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nmsoluong
            // 
            this.nmsoluong.Location = new System.Drawing.Point(737, 343);
            this.nmsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.nmsoluong.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmsoluong.Name = "nmsoluong";
            this.nmsoluong.Size = new System.Drawing.Size(148, 20);
            this.nmsoluong.TabIndex = 309;
            this.nmsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmsoluong.ValueChanged += new System.EventHandler(this.nmsoluong_ValueChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(1059, 338);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 37);
            this.btnLamMoi.TabIndex = 388;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(905, 338);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 37);
            this.btnThem.TabIndex = 389;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grdHangHoa
            // 
            this.grdHangHoa.AllowUserToAddRows = false;
            this.grdHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.grdHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHangHoa.Location = new System.Drawing.Point(581, 54);
            this.grdHangHoa.Margin = new System.Windows.Forms.Padding(5);
            this.grdHangHoa.Name = "grdHangHoa";
            this.grdHangHoa.ReadOnly = true;
            this.grdHangHoa.RowHeadersWidth = 51;
            this.grdHangHoa.Size = new System.Drawing.Size(764, 275);
            this.grdHangHoa.TabIndex = 304;
            this.grdHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHangHoa_CellContentClick);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(1276, 15);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(90, 26);
            this.btnTim.TabIndex = 387;
            this.btnTim.TabStop = false;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(587, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 303;
            this.label3.Text = "Hàng hóa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txttenhh
            // 
            this.txttenhh.Location = new System.Drawing.Point(681, 15);
            this.txttenhh.Margin = new System.Windows.Forms.Padding(5);
            this.txttenhh.Name = "txttenhh";
            this.txttenhh.Size = new System.Drawing.Size(120, 20);
            this.txttenhh.TabIndex = 302;
            this.txttenhh.TextChanged += new System.EventHandler(this.txttenhh_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 321;
            this.label6.Text = "Chọn khách hàng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 324;
            this.label5.Text = "Mã hóa đơn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(215, 23);
            this.txtmahd.Margin = new System.Windows.Forms.Padding(4);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.ReadOnly = true;
            this.txtmahd.Size = new System.Drawing.Size(253, 20);
            this.txtmahd.TabIndex = 323;
            this.txtmahd.TextChanged += new System.EventHandler(this.txtmahd_TextChanged);
            // 
            // GrvKH
            // 
            this.GrvKH.AllowUserToAddRows = false;
            this.GrvKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrvKH.BackgroundColor = System.Drawing.Color.White;
            this.GrvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvKH.Location = new System.Drawing.Point(28, 158);
            this.GrvKH.Margin = new System.Windows.Forms.Padding(4);
            this.GrvKH.Name = "GrvKH";
            this.GrvKH.ReadOnly = true;
            this.GrvKH.RowHeadersWidth = 51;
            this.GrvKH.Size = new System.Drawing.Size(487, 266);
            this.GrvKH.TabIndex = 390;
            this.GrvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrvKH_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 393;
            this.label7.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(215, 123);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(253, 20);
            this.txtDienThoai.TabIndex = 392;
            this.txtDienThoai.TextChanged += new System.EventHandler(this.txtDienThoai_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(215, 89);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(253, 20);
            this.txtTenKH.TabIndex = 391;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 395;
            this.label10.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(215, 53);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(253, 20);
            this.txtMaKH.TabIndex = 394;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(250, 632);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 396;
            this.button1.Text = "Xác nhận";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TenNCC
            // 
            this.TenNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TenNCC.FormattingEnabled = true;
            this.TenNCC.Location = new System.Drawing.Point(1161, 19);
            this.TenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Size = new System.Drawing.Size(107, 21);
            this.TenNCC.TabIndex = 430;
            this.TenNCC.SelectedIndexChanged += new System.EventHandler(this.TenNCC_SelectedIndexChanged);
            // 
            // TenLHH
            // 
            this.TenLHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TenLHH.FormattingEnabled = true;
            this.TenLHH.Location = new System.Drawing.Point(923, 15);
            this.TenLHH.Margin = new System.Windows.Forms.Padding(4);
            this.TenLHH.Name = "TenLHH";
            this.TenLHH.Size = new System.Drawing.Size(120, 21);
            this.TenLHH.TabIndex = 429;
            this.TenLHH.SelectedIndexChanged += new System.EventHandler(this.TenLHH_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1051, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 428;
            this.label11.Text = "Nhà cung cấp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(810, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 427;
            this.label12.Text = "Loại hàng hóa";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(28, 432);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 63);
            this.button2.TabIndex = 431;
            this.button2.Text = "Làm mới khách hàng";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmXuatKhoInfor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1370, 727);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TenNCC);
            this.Controls.Add(this.TenLHH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.GrvKH);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmahd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtNgayHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCTHD);
            this.Controls.Add(this.nmsoluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdHangHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttenhh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXuatKhoInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXuatKhoInfor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmXuatKhoInfor_FormClosed);
            this.Load += new System.EventHandler(this.frmXuatKhoInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmsoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCTHD;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayHD;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmsoluong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView grdHangHoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenhh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.DataGridView GrvKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TenNCC;
        private System.Windows.Forms.ComboBox TenLHH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
    }
}