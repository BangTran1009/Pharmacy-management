namespace Pharmacy_management
{
    partial class fmChiTietHoaDon
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
            this.ElipseTimKiem = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnX = new System.Windows.Forms.Button();
            this.ElipseLoc = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnLoc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongHoaDon = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtmLocNgay = new System.Windows.Forms.DateTimePicker();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.ElipsePannel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseTimKiem
            // 
            this.ElipseTimKiem.ElipseRadius = 30;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.White;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Location = new System.Drawing.Point(1230, 7);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(53, 32);
            this.btnX.TabIndex = 7;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // ElipseLoc
            // 
            this.ElipseLoc.ElipseRadius = 30;
            this.ElipseLoc.TargetControl = this.btnLoc;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(424, 10);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(107, 32);
            this.btnLoc.TabIndex = 7;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.dtmLocNgay);
            this.panel1.Controls.Add(this.dgvChiTietHoaDon);
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Location = new System.Drawing.Point(18, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 514);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy_management.Properties.Resources.HoaDon_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(773, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(677, -39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.txtTongHoaDon);
            this.panel.Location = new System.Drawing.Point(10, 26);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(224, 59);
            this.panel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng số hóa đơn";
            // 
            // txtTongHoaDon
            // 
            this.txtTongHoaDon.Location = new System.Drawing.Point(7, 25);
            this.txtTongHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongHoaDon.Name = "txtTongHoaDon";
            this.txtTongHoaDon.Size = new System.Drawing.Size(185, 22);
            this.txtTongHoaDon.TabIndex = 3;
            this.txtTongHoaDon.TextChanged += new System.EventHandler(this.txtTongHoaDon_TextChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(240, 63);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(527, 22);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dtmLocNgay
            // 
            this.dtmLocNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmLocNgay.Location = new System.Drawing.Point(244, 14);
            this.dtmLocNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmLocNgay.Name = "dtmLocNgay";
            this.dtmLocNgay.Size = new System.Drawing.Size(172, 22);
            this.dtmLocNgay.TabIndex = 9;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(10, 114);
            this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 62;
            this.dgvChiTietHoaDon.RowTemplate.Height = 28;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(757, 377);
            this.dgvChiTietHoaDon.TabIndex = 8;
            // 
            // ElipsePannel
            // 
            this.ElipsePannel.ElipseRadius = 30;
            this.ElipsePannel.TargetControl = this.panel1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(487, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi tiết hóa đơn";
            // 
            // fmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1295, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fmChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.fmChiTietHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse ElipseTimKiem;
        private System.Windows.Forms.Button btnX;
        private Bunifu.Framework.UI.BunifuElipse ElipseLoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongHoaDon;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DateTimePicker dtmLocNgay;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.Button btnLoc;
        private Bunifu.Framework.UI.BunifuElipse ElipsePannel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}