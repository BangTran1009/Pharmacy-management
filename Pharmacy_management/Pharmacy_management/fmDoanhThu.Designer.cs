namespace Pharmacy_management
{
    partial class fmDoanhThu
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
            this.components = new System.ComponentModel.Container();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDanhGia = new System.Windows.Forms.Button();
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.txtTongChi = new System.Windows.Forms.TextBox();
            this.txtTongThu = new System.Windows.Forms.TextBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dgvTienNhapHang = new System.Windows.Forms.DataGridView();
            this.dgvLuongNhanVien = new System.Windows.Forms.DataGridView();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.ElipseChiTietLuong = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnChiTietLuong = new System.Windows.Forms.Button();
            this.ElipseChiTietHoaDon = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnChiTietHoaDon = new System.Windows.Forms.Button();
            this.ElipseChiTietHang = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnChiTietHang = new System.Windows.Forms.Button();
            this.ElipseDanhGia = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseXem = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(687, 389);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(403, 28);
            this.cmbCoSo.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(657, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tiền nhập hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(785, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Lương nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(592, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Doanh thu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(860, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tổng chi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(592, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cơ sở";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tổng thu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(86, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Từ ngày:";
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnDanhGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhGia.ForeColor = System.Drawing.Color.White;
            this.btnDanhGia.Location = new System.Drawing.Point(698, 597);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.Size = new System.Drawing.Size(170, 40);
            this.btnDanhGia.TabIndex = 16;
            this.btnDanhGia.Text = "Đánh giá";
            this.btnDanhGia.UseVisualStyleBackColor = false;
            this.btnDanhGia.Click += new System.EventHandler(this.btnDanhGia_Click);
            // 
            // btnXemDoanhThu
            // 
            this.btnXemDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnXemDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnXemDoanhThu.Location = new System.Drawing.Point(890, 597);
            this.btnXemDoanhThu.Name = "btnXemDoanhThu";
            this.btnXemDoanhThu.Size = new System.Drawing.Size(170, 40);
            this.btnXemDoanhThu.TabIndex = 15;
            this.btnXemDoanhThu.Text = "Xem";
            this.btnXemDoanhThu.UseVisualStyleBackColor = false;
            this.btnXemDoanhThu.Click += new System.EventHandler(this.btnXemDoanhThu_Click);
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(687, 529);
            this.txtDoanhThu.Multiline = true;
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(403, 33);
            this.txtDoanhThu.TabIndex = 14;
            // 
            // txtTongChi
            // 
            this.txtTongChi.Location = new System.Drawing.Point(952, 457);
            this.txtTongChi.Name = "txtTongChi";
            this.txtTongChi.Size = new System.Drawing.Size(138, 26);
            this.txtTongChi.TabIndex = 13;
            // 
            // txtTongThu
            // 
            this.txtTongThu.Location = new System.Drawing.Point(687, 458);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Size = new System.Drawing.Size(144, 26);
            this.txtTongThu.TabIndex = 12;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(604, 88);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(488, 202);
            this.dgvHoaDon.TabIndex = 11;
            // 
            // dgvTienNhapHang
            // 
            this.dgvTienNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTienNhapHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvTienNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienNhapHang.Location = new System.Drawing.Point(39, 389);
            this.dgvTienNhapHang.MultiSelect = false;
            this.dgvTienNhapHang.Name = "dgvTienNhapHang";
            this.dgvTienNhapHang.RowHeadersWidth = 62;
            this.dgvTienNhapHang.RowTemplate.Height = 28;
            this.dgvTienNhapHang.Size = new System.Drawing.Size(488, 202);
            this.dgvTienNhapHang.TabIndex = 10;
            // 
            // dgvLuongNhanVien
            // 
            this.dgvLuongNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuongNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvLuongNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongNhanVien.Location = new System.Drawing.Point(39, 88);
            this.dgvLuongNhanVien.MultiSelect = false;
            this.dgvLuongNhanVien.Name = "dgvLuongNhanVien";
            this.dgvLuongNhanVien.RowHeadersWidth = 62;
            this.dgvLuongNhanVien.RowTemplate.Height = 28;
            this.dgvLuongNhanVien.Size = new System.Drawing.Size(488, 202);
            this.dgvLuongNhanVien.TabIndex = 9;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(754, 20);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 26);
            this.dtpDenNgay.TabIndex = 8;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(164, 25);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 26);
            this.dtpTuNgay.TabIndex = 7;
            // 
            // ElipseChiTietLuong
            // 
            this.ElipseChiTietLuong.ElipseRadius = 30;
            this.ElipseChiTietLuong.TargetControl = this.btnChiTietLuong;
            // 
            // btnChiTietLuong
            // 
            this.btnChiTietLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnChiTietLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietLuong.ForeColor = System.Drawing.Color.White;
            this.btnChiTietLuong.Location = new System.Drawing.Point(357, 295);
            this.btnChiTietLuong.Name = "btnChiTietLuong";
            this.btnChiTietLuong.Size = new System.Drawing.Size(170, 40);
            this.btnChiTietLuong.TabIndex = 18;
            this.btnChiTietLuong.Text = "Xem chi tiết";
            this.btnChiTietLuong.UseVisualStyleBackColor = false;
            this.btnChiTietLuong.Click += new System.EventHandler(this.btnChiTietLuong_Click);
            // 
            // ElipseChiTietHoaDon
            // 
            this.ElipseChiTietHoaDon.ElipseRadius = 30;
            this.ElipseChiTietHoaDon.TargetControl = this.btnChiTietHoaDon;
            // 
            // btnChiTietHoaDon
            // 
            this.btnChiTietHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnChiTietHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnChiTietHoaDon.Location = new System.Drawing.Point(920, 295);
            this.btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            this.btnChiTietHoaDon.Size = new System.Drawing.Size(170, 40);
            this.btnChiTietHoaDon.TabIndex = 17;
            this.btnChiTietHoaDon.Text = "Xem chi tiết";
            this.btnChiTietHoaDon.UseVisualStyleBackColor = false;
            this.btnChiTietHoaDon.Click += new System.EventHandler(this.btnChiTietHoaDon_Click);
            // 
            // ElipseChiTietHang
            // 
            this.ElipseChiTietHang.ElipseRadius = 30;
            this.ElipseChiTietHang.TargetControl = this.btnChiTietHang;
            // 
            // btnChiTietHang
            // 
            this.btnChiTietHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnChiTietHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietHang.ForeColor = System.Drawing.Color.White;
            this.btnChiTietHang.Location = new System.Drawing.Point(357, 597);
            this.btnChiTietHang.Name = "btnChiTietHang";
            this.btnChiTietHang.Size = new System.Drawing.Size(170, 40);
            this.btnChiTietHang.TabIndex = 19;
            this.btnChiTietHang.Text = "Xem chi tiết";
            this.btnChiTietHang.UseVisualStyleBackColor = false;
            this.btnChiTietHang.Click += new System.EventHandler(this.btnChiTietHang_Click);
            // 
            // ElipseDanhGia
            // 
            this.ElipseDanhGia.ElipseRadius = 30;
            this.ElipseDanhGia.TargetControl = this.btnDanhGia;
            // 
            // ElipseXem
            // 
            this.ElipseXem.ElipseRadius = 30;
            this.ElipseXem.TargetControl = this.btnXemDoanhThu;
            // 
            // fmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 649);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnChiTietHang);
            this.Controls.Add(this.btnChiTietLuong);
            this.Controls.Add(this.btnChiTietHoaDon);
            this.Controls.Add(this.btnDanhGia);
            this.Controls.Add(this.btnXemDoanhThu);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.txtTongChi);
            this.Controls.Add(this.txtTongThu);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.dgvTienNhapHang);
            this.Controls.Add(this.dgvLuongNhanVien);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.fmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDanhGia;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.TextBox txtTongChi;
        private System.Windows.Forms.TextBox txtTongThu;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridView dgvTienNhapHang;
        private System.Windows.Forms.DataGridView dgvLuongNhanVien;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private Bunifu.Framework.UI.BunifuElipse ElipseChiTietLuong;
        private Bunifu.Framework.UI.BunifuElipse ElipseChiTietHoaDon;
        private Bunifu.Framework.UI.BunifuElipse ElipseChiTietHang;
        private Bunifu.Framework.UI.BunifuElipse ElipseDanhGia;
        private Bunifu.Framework.UI.BunifuElipse ElipseXem;
        private System.Windows.Forms.Button btnChiTietLuong;
        private System.Windows.Forms.Button btnChiTietHoaDon;
        private System.Windows.Forms.Button btnChiTietHang;
    }
}