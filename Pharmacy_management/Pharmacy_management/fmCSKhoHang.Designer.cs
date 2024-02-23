namespace Pharmacy_management
{
    partial class fmCSKhoHang
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
            this.ElipseThem = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.ElipseTimkiem = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmbLoaiHangHoa = new System.Windows.Forms.ComboBox();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.dtpNSX = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayNhapHang = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHangHoa = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudPhanTrang = new System.Windows.Forms.NumericUpDown();
            this.dgvKhoHang = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhanTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseThem
            // 
            this.ElipseThem.ElipseRadius = 30;
            this.ElipseThem.TargetControl = this.btnThem;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(920, 239);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(202, 40);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm số lượng thuốc";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ElipseTimkiem
            // 
            this.ElipseTimkiem.ElipseRadius = 30;
            this.ElipseTimkiem.TargetControl = this.btnTimKiem;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(281, 283);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 40);
            this.btnTimKiem.TabIndex = 36;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbLoaiHangHoa
            // 
            this.cmbLoaiHangHoa.FormattingEnabled = true;
            this.cmbLoaiHangHoa.Location = new System.Drawing.Point(55, 146);
            this.cmbLoaiHangHoa.Name = "cmbLoaiHangHoa";
            this.cmbLoaiHangHoa.Size = new System.Drawing.Size(190, 28);
            this.cmbLoaiHangHoa.TabIndex = 59;
            // 
            // dtpHSD
            // 
            this.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHSD.Location = new System.Drawing.Point(927, 86);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(192, 26);
            this.dtpHSD.TabIndex = 58;
            // 
            // dtpNSX
            // 
            this.dtpNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNSX.Location = new System.Drawing.Point(650, 86);
            this.dtpNSX.Name = "dtpNSX";
            this.dtpNSX.Size = new System.Drawing.Size(192, 26);
            this.dtpNSX.TabIndex = 57;
            // 
            // dtpNgayNhapHang
            // 
            this.dtpNgayNhapHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhapHang.Location = new System.Drawing.Point(927, 157);
            this.dtpNgayNhapHang.Name = "dtpNgayNhapHang";
            this.dtpNgayNhapHang.Size = new System.Drawing.Size(192, 26);
            this.dtpNgayNhapHang.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(927, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "HSD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(49, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nhà cung cấp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(645, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "NSX:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(313, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 25);
            this.label12.TabIndex = 54;
            this.label12.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(921, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ngày nhập hàng:";
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Location = new System.Drawing.Point(55, 86);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(192, 26);
            this.txtMaHangHoa.TabIndex = 52;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(319, 157);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(192, 26);
            this.txtSoLuong.TabIndex = 53;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(650, 157);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(192, 26);
            this.txtSoTien.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(645, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Số tiền:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(319, 86);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(192, 26);
            this.txtTenHang.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(313, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tên hàng hóa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(49, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 25);
            this.label10.TabIndex = 40;
            this.label10.Text = "Mã hàng hóa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(49, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nhóm hàng hóa:";
            // 
            // nudPhanTrang
            // 
            this.nudPhanTrang.Location = new System.Drawing.Point(1062, 312);
            this.nudPhanTrang.Name = "nudPhanTrang";
            this.nudPhanTrang.Size = new System.Drawing.Size(150, 26);
            this.nudPhanTrang.TabIndex = 38;
            // 
            // dgvKhoHang
            // 
            this.dgvKhoHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhoHang.Location = new System.Drawing.Point(0, 344);
            this.dgvKhoHang.Name = "dgvKhoHang";
            this.dgvKhoHang.RowHeadersWidth = 62;
            this.dgvKhoHang.RowTemplate.Height = 28;
            this.dgvKhoHang.Size = new System.Drawing.Size(1224, 286);
            this.dgvKhoHang.TabIndex = 37;
            this.dgvKhoHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoHang_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(49, 293);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(192, 26);
            this.txtTimKiem.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 28);
            this.label15.TabIndex = 34;
            this.label15.Text = "Thông tin kho hàng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(481, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 28);
            this.label13.TabIndex = 33;
            this.label13.Text = "Danh sách kho hàng";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(53, 212);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(190, 28);
            this.cmbNhaCungCap.TabIndex = 59;
            // 
            // fmCSKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 630);
            this.Controls.Add(this.cmbNhaCungCap);
            this.Controls.Add(this.cmbLoaiHangHoa);
            this.Controls.Add(this.dtpHSD);
            this.Controls.Add(this.dtpNSX);
            this.Controls.Add(this.dtpNgayNhapHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaHangHoa);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPhanTrang);
            this.Controls.Add(this.dgvKhoHang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmCSKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmCSKhoHang";
            ((System.ComponentModel.ISupportInitialize)(this.nudPhanTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse ElipseThem;
        private Bunifu.Framework.UI.BunifuElipse ElipseTimkiem;
        private System.Windows.Forms.ComboBox cmbLoaiHangHoa;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.DateTimePicker dtpNSX;
        private System.Windows.Forms.DateTimePicker dtpNgayNhapHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHangHoa;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudPhanTrang;
        private System.Windows.Forms.DataGridView dgvKhoHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
    }
}