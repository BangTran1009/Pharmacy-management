namespace Pharmacy_management
{
    partial class fmCoSo
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
            this.nudPhanTrang = new System.Windows.Forms.NumericUpDown();
            this.dgvCoSo = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDNguoiQuanLy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.txtIDCoSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ElipseThem = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseSua = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseXoa = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseTimKiem = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPhanTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoSo)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPhanTrang
            // 
            this.nudPhanTrang.Location = new System.Drawing.Point(929, 365);
            this.nudPhanTrang.Name = "nudPhanTrang";
            this.nudPhanTrang.Size = new System.Drawing.Size(167, 26);
            this.nudPhanTrang.TabIndex = 21;
            // 
            // dgvCoSo
            // 
            this.dgvCoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoSo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCoSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoSo.Location = new System.Drawing.Point(16, 397);
            this.dgvCoSo.MultiSelect = false;
            this.dgvCoSo.Name = "dgvCoSo";
            this.dgvCoSo.RowHeadersWidth = 62;
            this.dgvCoSo.RowTemplate.Height = 28;
            this.dgvCoSo.Size = new System.Drawing.Size(1074, 241);
            this.dgvCoSo.TabIndex = 20;
            this.dgvCoSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoSo_CellClick_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(976, 245);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(776, 245);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(251, 334);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 40);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(576, 245);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(735, 109);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(191, 84);
            this.txtDiaChi.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(730, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Địa chỉ:";
            // 
            // txtIDNguoiQuanLy
            // 
            this.txtIDNguoiQuanLy.Location = new System.Drawing.Point(370, 109);
            this.txtIDNguoiQuanLy.Name = "txtIDNguoiQuanLy";
            this.txtIDNguoiQuanLy.Size = new System.Drawing.Size(191, 26);
            this.txtIDNguoiQuanLy.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(365, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "ID quản lý:";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(19, 343);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(191, 26);
            this.txtTuKhoa.TabIndex = 14;
            // 
            // txtIDCoSo
            // 
            this.txtIDCoSo.Location = new System.Drawing.Point(11, 109);
            this.txtIDCoSo.Name = "txtIDCoSo";
            this.txtIDCoSo.Size = new System.Drawing.Size(191, 26);
            this.txtIDCoSo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID Cơ sở:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(12, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 28);
            this.label15.TabIndex = 10;
            this.label15.Text = "Thông tin cơ sở";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(484, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 28);
            this.label13.TabIndex = 11;
            this.label13.Text = "Danh sách cơ sở";
            // 
            // ElipseThem
            // 
            this.ElipseThem.ElipseRadius = 30;
            this.ElipseThem.TargetControl = this.btnThem;
            // 
            // ElipseSua
            // 
            this.ElipseSua.ElipseRadius = 30;
            this.ElipseSua.TargetControl = this.btnSua;
            // 
            // ElipseXoa
            // 
            this.ElipseXoa.ElipseRadius = 30;
            this.ElipseXoa.TargetControl = this.btnXoa;
            // 
            // ElipseTimKiem
            // 
            this.ElipseTimKiem.ElipseRadius = 30;
            this.ElipseTimKiem.TargetControl = this.btnTimKiem;
            // 
            // fmCoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 650);
            this.Controls.Add(this.nudPhanTrang);
            this.Controls.Add(this.dgvCoSo);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIDNguoiQuanLy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.txtIDCoSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmCoSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoSo";
            this.Load += new System.EventHandler(this.fmCoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPhanTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPhanTrang;
        private System.Windows.Forms.DataGridView dgvCoSo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDNguoiQuanLy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.TextBox txtIDCoSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuElipse ElipseThem;
        private Bunifu.Framework.UI.BunifuElipse ElipseSua;
        private Bunifu.Framework.UI.BunifuElipse ElipseXoa;
        private Bunifu.Framework.UI.BunifuElipse ElipseTimKiem;
    }
}