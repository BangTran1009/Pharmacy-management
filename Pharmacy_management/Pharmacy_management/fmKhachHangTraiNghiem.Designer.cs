namespace Pharmacy_management
{
    partial class fmKhachHangTraiNghiem
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
            this.panel_body = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimCoSo = new System.Windows.Forms.TextBox();
            this.txtTimKiemhangHoa = new System.Windows.Forms.TextBox();
            this.btnTimCoSo = new System.Windows.Forms.Button();
            this.btnKhachHangDanhGia = new System.Windows.Forms.Button();
            this.btnTimHangHoa = new System.Windows.Forms.Button();
            this.dgvCoSo = new System.Windows.Forms.DataGridView();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ElipseTimKiem = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseTimKiemCS = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipsebody = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseDanhGia = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.White;
            this.panel_body.Controls.Add(this.label3);
            this.panel_body.Controls.Add(this.label2);
            this.panel_body.Controls.Add(this.txtTimCoSo);
            this.panel_body.Controls.Add(this.txtTimKiemhangHoa);
            this.panel_body.Controls.Add(this.btnTimCoSo);
            this.panel_body.Controls.Add(this.btnKhachHangDanhGia);
            this.panel_body.Controls.Add(this.btnTimHangHoa);
            this.panel_body.Controls.Add(this.dgvCoSo);
            this.panel_body.Controls.Add(this.dgvHangHoa);
            this.panel_body.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_body.ForeColor = System.Drawing.Color.Navy;
            this.panel_body.Location = new System.Drawing.Point(12, 91);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1276, 627);
            this.panel_body.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách cơ sở";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách sản phẩm";
            // 
            // txtTimCoSo
            // 
            this.txtTimCoSo.Location = new System.Drawing.Point(13, 347);
            this.txtTimCoSo.Name = "txtTimCoSo";
            this.txtTimCoSo.Size = new System.Drawing.Size(302, 29);
            this.txtTimCoSo.TabIndex = 3;
            // 
            // txtTimKiemhangHoa
            // 
            this.txtTimKiemhangHoa.Location = new System.Drawing.Point(12, 24);
            this.txtTimKiemhangHoa.Name = "txtTimKiemhangHoa";
            this.txtTimKiemhangHoa.Size = new System.Drawing.Size(302, 29);
            this.txtTimKiemhangHoa.TabIndex = 3;
            // 
            // btnTimCoSo
            // 
            this.btnTimCoSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnTimCoSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimCoSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimCoSo.ForeColor = System.Drawing.Color.White;
            this.btnTimCoSo.Location = new System.Drawing.Point(339, 340);
            this.btnTimCoSo.Name = "btnTimCoSo";
            this.btnTimCoSo.Size = new System.Drawing.Size(120, 40);
            this.btnTimCoSo.TabIndex = 2;
            this.btnTimCoSo.Text = "Tìm cơ sở";
            this.btnTimCoSo.UseVisualStyleBackColor = false;
            this.btnTimCoSo.Click += new System.EventHandler(this.btnTimCoSo_Click);
            // 
            // btnKhachHangDanhGia
            // 
            this.btnKhachHangDanhGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnKhachHangDanhGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHangDanhGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHangDanhGia.ForeColor = System.Drawing.Color.White;
            this.btnKhachHangDanhGia.Location = new System.Drawing.Point(997, 17);
            this.btnKhachHangDanhGia.Name = "btnKhachHangDanhGia";
            this.btnKhachHangDanhGia.Size = new System.Drawing.Size(261, 40);
            this.btnKhachHangDanhGia.TabIndex = 2;
            this.btnKhachHangDanhGia.Text = "Khách hàng đánh giá";
            this.btnKhachHangDanhGia.UseVisualStyleBackColor = false;
            this.btnKhachHangDanhGia.Click += new System.EventHandler(this.btnKhachHangDanhGia_Click);
            // 
            // btnTimHangHoa
            // 
            this.btnTimHangHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnTimHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimHangHoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnTimHangHoa.Location = new System.Drawing.Point(339, 17);
            this.btnTimHangHoa.Name = "btnTimHangHoa";
            this.btnTimHangHoa.Size = new System.Drawing.Size(175, 40);
            this.btnTimHangHoa.TabIndex = 2;
            this.btnTimHangHoa.Text = "Tìm sản phẩm";
            this.btnTimHangHoa.UseVisualStyleBackColor = false;
            this.btnTimHangHoa.Click += new System.EventHandler(this.btnTimHangHoa_Click);
            // 
            // dgvCoSo
            // 
            this.dgvCoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCoSo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCoSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoSo.Location = new System.Drawing.Point(12, 410);
            this.dgvCoSo.MultiSelect = false;
            this.dgvCoSo.Name = "dgvCoSo";
            this.dgvCoSo.RowHeadersWidth = 62;
            this.dgvCoSo.RowTemplate.Height = 28;
            this.dgvCoSo.Size = new System.Drawing.Size(1246, 205);
            this.dgvCoSo.TabIndex = 0;
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(12, 115);
            this.dgvHangHoa.MultiSelect = false;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 62;
            this.dgvHangHoa.RowTemplate.Height = 28;
            this.dgvHangHoa.Size = new System.Drawing.Size(1246, 191);
            this.dgvHangHoa.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(1245, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(57, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(516, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trải nghiệm khách hàng";
            // 
            // ElipseTimKiem
            // 
            this.ElipseTimKiem.ElipseRadius = 30;
            this.ElipseTimKiem.TargetControl = this.btnTimHangHoa;
            // 
            // ElipseTimKiemCS
            // 
            this.ElipseTimKiemCS.ElipseRadius = 30;
            this.ElipseTimKiemCS.TargetControl = this.btnTimCoSo;
            // 
            // Elipsebody
            // 
            this.Elipsebody.ElipseRadius = 30;
            this.Elipsebody.TargetControl = this.panel_body;
            // 
            // ElipseDanhGia
            // 
            this.ElipseDanhGia.ElipseRadius = 30;
            this.ElipseDanhGia.TargetControl = this.btnKhachHangDanhGia;
            // 
            // fmKhachHangTraiNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1300, 730);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmKhachHangTraiNghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KHACHHANGDANHGIA";
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.TextBox txtTimCoSo;
        private System.Windows.Forms.TextBox txtTimKiemhangHoa;
        private System.Windows.Forms.Button btnTimCoSo;
        private System.Windows.Forms.Button btnTimHangHoa;
        private System.Windows.Forms.DataGridView dgvCoSo;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private Bunifu.Framework.UI.BunifuElipse ElipseTimKiem;
        private Bunifu.Framework.UI.BunifuElipse ElipseTimKiemCS;
        private Bunifu.Framework.UI.BunifuElipse Elipsebody;
        private System.Windows.Forms.Button btnKhachHangDanhGia;
        private Bunifu.Framework.UI.BunifuElipse ElipseDanhGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}