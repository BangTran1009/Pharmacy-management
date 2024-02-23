namespace Pharmacy_management
{
    partial class fmCSDoanhThu
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
            this.ElipseXem = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.txtTongChi = new System.Windows.Forms.TextBox();
            this.txtTongThu = new System.Windows.Forms.TextBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dgvLuongNhanVien = new System.Windows.Forms.DataGridView();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseXem
            // 
            this.ElipseXem.ElipseRadius = 30;
            this.ElipseXem.TargetControl = this.btnXemDoanhThu;
            // 
            // btnXemDoanhThu
            // 
            this.btnXemDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnXemDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnXemDoanhThu.Location = new System.Drawing.Point(633, 588);
            this.btnXemDoanhThu.Name = "btnXemDoanhThu";
            this.btnXemDoanhThu.Size = new System.Drawing.Size(170, 40);
            this.btnXemDoanhThu.TabIndex = 13;
            this.btnXemDoanhThu.Text = "Xem";
            this.btnXemDoanhThu.UseVisualStyleBackColor = false;
            this.btnXemDoanhThu.Click += new System.EventHandler(this.btnXemDoanhThu_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(783, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Từ ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(931, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lương nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Doanh thu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(603, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tổng chi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tổng thu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Từ ngày:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(429, 514);
            this.txtDoanhThu.Multiline = true;
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(366, 39);
            this.txtDoanhThu.TabIndex = 10;
            // 
            // txtTongChi
            // 
            this.txtTongChi.Location = new System.Drawing.Point(695, 448);
            this.txtTongChi.Name = "txtTongChi";
            this.txtTongChi.Size = new System.Drawing.Size(100, 26);
            this.txtTongChi.TabIndex = 11;
            // 
            // txtTongThu
            // 
            this.txtTongThu.Location = new System.Drawing.Point(429, 449);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Size = new System.Drawing.Size(100, 26);
            this.txtTongThu.TabIndex = 12;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(695, 120);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(520, 250);
            this.dgvHoaDon.TabIndex = 8;
            // 
            // dgvLuongNhanVien
            // 
            this.dgvLuongNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvLuongNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongNhanVien.Location = new System.Drawing.Point(4, 120);
            this.dgvLuongNhanVien.Name = "dgvLuongNhanVien";
            this.dgvLuongNhanVien.RowHeadersWidth = 62;
            this.dgvLuongNhanVien.RowTemplate.Height = 28;
            this.dgvLuongNhanVien.Size = new System.Drawing.Size(520, 250);
            this.dgvLuongNhanVien.TabIndex = 9;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(879, 20);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 26);
            this.dtpDenNgay.TabIndex = 6;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(148, 25);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 26);
            this.dtpTuNgay.TabIndex = 7;
            // 
            // fmCSDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 630);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnXemDoanhThu);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.txtTongChi);
            this.Controls.Add(this.txtTongThu);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.dgvLuongNhanVien);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmCSDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmCSDoanhThu";
            this.Load += new System.EventHandler(this.fmCSDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse ElipseXem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.TextBox txtTongChi;
        private System.Windows.Forms.TextBox txtTongThu;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridView dgvLuongNhanVien;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
    }
}