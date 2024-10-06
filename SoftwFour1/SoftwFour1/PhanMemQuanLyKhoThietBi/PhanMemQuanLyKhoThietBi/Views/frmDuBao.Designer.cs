namespace PhanMemQuanLyKhoThietBi.Views
{
    partial class frmDuBao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDuBaoNhuCau = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvBanChay = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTop10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCanTakecare = new System.Windows.Forms.DataGridView();
            this.dgvKHTiemNang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartDuBaoNhuCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanTakecare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHTiemNang)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDuBaoNhuCau
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDuBaoNhuCau.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDuBaoNhuCau.Legends.Add(legend1);
            this.chartDuBaoNhuCau.Location = new System.Drawing.Point(626, -32);
            this.chartDuBaoNhuCau.Margin = new System.Windows.Forms.Padding(2);
            this.chartDuBaoNhuCau.Name = "chartDuBaoNhuCau";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDuBaoNhuCau.Series.Add(series1);
            this.chartDuBaoNhuCau.Size = new System.Drawing.Size(465, 398);
            this.chartDuBaoNhuCau.TabIndex = 3;
            this.chartDuBaoNhuCau.Text = "chart1";
            // 
            // dgvBanChay
            // 
            this.dgvBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanChay.Location = new System.Drawing.Point(11, 56);
            this.dgvBanChay.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBanChay.Name = "dgvBanChay";
            this.dgvBanChay.RowHeadersWidth = 51;
            this.dgvBanChay.RowTemplate.Height = 24;
            this.dgvBanChay.Size = new System.Drawing.Size(465, 242);
            this.dgvBanChay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Top 10 sản phẩm bán chạy";
            // 
            // btnTop10
            // 
            this.btnTop10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10.Location = new System.Drawing.Point(836, 482);
            this.btnTop10.Margin = new System.Windows.Forms.Padding(2);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(132, 46);
            this.btnTop10.TabIndex = 6;
            this.btnTop10.Text = "In báo cáo";
            this.btnTop10.UseVisualStyleBackColor = true;
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Top khách hàng cần chăm sóc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Top khách hàng tiềm năng";
            // 
            // dgvCanTakecare
            // 
            this.dgvCanTakecare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanTakecare.Location = new System.Drawing.Point(32, 379);
            this.dgvCanTakecare.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCanTakecare.Name = "dgvCanTakecare";
            this.dgvCanTakecare.RowHeadersWidth = 51;
            this.dgvCanTakecare.RowTemplate.Height = 24;
            this.dgvCanTakecare.Size = new System.Drawing.Size(311, 184);
            this.dgvCanTakecare.TabIndex = 12;
            // 
            // dgvKHTiemNang
            // 
            this.dgvKHTiemNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHTiemNang.Location = new System.Drawing.Point(423, 379);
            this.dgvKHTiemNang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKHTiemNang.Name = "dgvKHTiemNang";
            this.dgvKHTiemNang.RowHeadersWidth = 51;
            this.dgvKHTiemNang.RowTemplate.Height = 24;
            this.dgvKHTiemNang.Size = new System.Drawing.Size(284, 184);
            this.dgvKHTiemNang.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(721, 561);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Bảng dự báo số lượng hàng hóa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmDuBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCanTakecare);
            this.Controls.Add(this.dgvKHTiemNang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTop10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBanChay);
            this.Controls.Add(this.chartDuBaoNhuCau);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDuBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dự báo";
            ((System.ComponentModel.ISupportInitialize)(this.chartDuBaoNhuCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanTakecare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHTiemNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDuBaoNhuCau;
        private System.Windows.Forms.DataGridView dgvBanChay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCanTakecare;
        private System.Windows.Forms.DataGridView dgvKHTiemNang;
        private System.Windows.Forms.Button button1;
    }
}