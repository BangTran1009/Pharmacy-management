namespace Pharmacy_management
{
    partial class fmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDangNhap));
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.llblQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.rdbQuanLy = new System.Windows.Forms.RadioButton();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.llblDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ElipseDangNhap = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseThoat = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.rdbGiamDoc = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.llblKhaiTruong = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.ElipseKhachHang = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(144, 251);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(196, 26);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(144, 302);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(196, 26);
            this.txtMatKhau.TabIndex = 2;
            // 
            // llblQuenMatKhau
            // 
            this.llblQuenMatKhau.AutoSize = true;
            this.llblQuenMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblQuenMatKhau.Location = new System.Drawing.Point(268, 474);
            this.llblQuenMatKhau.Name = "llblQuenMatKhau";
            this.llblQuenMatKhau.Size = new System.Drawing.Size(142, 25);
            this.llblQuenMatKhau.TabIndex = 3;
            this.llblQuenMatKhau.TabStop = true;
            this.llblQuenMatKhau.Text = "Quên mật khẩu?";
            this.llblQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblQuenMatKhau_LinkClicked);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(74, 412);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(120, 40);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // rdbQuanLy
            // 
            this.rdbQuanLy.AutoSize = true;
            this.rdbQuanLy.Location = new System.Drawing.Point(194, 362);
            this.rdbQuanLy.Name = "rdbQuanLy";
            this.rdbQuanLy.Size = new System.Drawing.Size(87, 24);
            this.rdbQuanLy.TabIndex = 6;
            this.rdbQuanLy.TabStop = true;
            this.rdbQuanLy.Text = "Quản lý";
            this.rdbQuanLy.UseVisualStyleBackColor = true;
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.Location = new System.Drawing.Point(57, 362);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(104, 24);
            this.rdbNhanVien.TabIndex = 6;
            this.rdbNhanVien.TabStop = true;
            this.rdbNhanVien.Text = "Nhân viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            // 
            // llblDoiMatKhau
            // 
            this.llblDoiMatKhau.AutoSize = true;
            this.llblDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblDoiMatKhau.Location = new System.Drawing.Point(12, 474);
            this.llblDoiMatKhau.Name = "llblDoiMatKhau";
            this.llblDoiMatKhau.Size = new System.Drawing.Size(119, 25);
            this.llblDoiMatKhau.TabIndex = 3;
            this.llblDoiMatKhau.TabStop = true;
            this.llblDoiMatKhau.Text = "Đổi mật khẩu";
            this.llblDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDoiMatKhau_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            // 
            // ElipseDangNhap
            // 
            this.ElipseDangNhap.ElipseRadius = 30;
            this.ElipseDangNhap.TargetControl = this.btnDangNhap;
            // 
            // ElipseThoat
            // 
            this.ElipseThoat.ElipseRadius = 30;
            this.ElipseThoat.TargetControl = this.btnThoat;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(254, 412);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 40);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rdbGiamDoc
            // 
            this.rdbGiamDoc.AutoSize = true;
            this.rdbGiamDoc.Location = new System.Drawing.Point(308, 362);
            this.rdbGiamDoc.Name = "rdbGiamDoc";
            this.rdbGiamDoc.Size = new System.Drawing.Size(102, 24);
            this.rdbGiamDoc.TabIndex = 6;
            this.rdbGiamDoc.TabStop = true;
            this.rdbGiamDoc.Text = "Giám đốc";
            this.rdbGiamDoc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.llblKhaiTruong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(864, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 487);
            this.panel1.TabIndex = 11;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(24, 126);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(100, 20);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Siêu sale 5/5";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // llblKhaiTruong
            // 
            this.llblKhaiTruong.AutoSize = true;
            this.llblKhaiTruong.Location = new System.Drawing.Point(24, 65);
            this.llblKhaiTruong.Name = "llblKhaiTruong";
            this.llblKhaiTruong.Size = new System.Drawing.Size(148, 20);
            this.llblKhaiTruong.TabIndex = 0;
            this.llblKhaiTruong.TabStop = true;
            this.llblKhaiTruong.Text = "Mừng lễ khai trương";
            this.llblKhaiTruong.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblKhaiTruong_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tin tức";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(544, 412);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(151, 46);
            this.btnKhachHang.TabIndex = 12;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // ElipseKhachHang
            // 
            this.ElipseKhachHang.ElipseRadius = 30;
            this.ElipseKhachHang.TargetControl = this.btnKhachHang;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pharmacy_management.Properties.Resources.Logo_Bộ_Y_tế_01_e1585994422207_300x213;
            this.pictureBox4.Location = new System.Drawing.Point(483, 96);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(255, 232);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pharmacy_management.Properties.Resources.MatKhau_Icon;
            this.pictureBox3.Location = new System.Drawing.Point(72, 302);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pharmacy_management.Properties.Resources.TenTaiKhoan_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(72, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 520);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbNhanVien);
            this.Controls.Add(this.rdbGiamDoc);
            this.Controls.Add(this.rdbQuanLy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.llblDoiMatKhau);
            this.Controls.Add(this.llblQuenMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.LinkLabel llblQuenMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.RadioButton rdbQuanLy;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.LinkLabel llblDoiMatKhau;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse ElipseDangNhap;
        private Bunifu.Framework.UI.BunifuElipse ElipseThoat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdbGiamDoc;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel llblKhaiTruong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKhachHang;
        private Bunifu.Framework.UI.BunifuElipse ElipseKhachHang;
    }
}

