namespace Pharmacy_management
{
    partial class fmChiTietTienHang
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
            this.ElipseSapXep = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lable = new System.Windows.Forms.Label();
            this.txtTongLoaiHang = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvHH = new System.Windows.Forms.DataGridView();
            this.btnX = new System.Windows.Forms.Button();
            this.ElipsePanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseTimKiem = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseSapXep
            // 
            this.ElipseSapXep.ElipseRadius = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(454, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Chi tiết tiền hàng hóa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.dgvHH);
            this.panel1.Location = new System.Drawing.Point(18, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 336);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy_management.Properties.Resources.HangHoa_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(691, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 186);
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
            this.panel.Controls.Add(this.lable);
            this.panel.Controls.Add(this.txtTongLoaiHang);
            this.panel.Location = new System.Drawing.Point(10, 26);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(224, 59);
            this.panel.TabIndex = 12;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lable.Location = new System.Drawing.Point(3, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(147, 23);
            this.lable.TabIndex = 0;
            this.lable.Text = "Tổng số loại hàng";
            // 
            // txtTongLoaiHang
            // 
            this.txtTongLoaiHang.Location = new System.Drawing.Point(7, 25);
            this.txtTongLoaiHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongLoaiHang.Name = "txtTongLoaiHang";
            this.txtTongLoaiHang.Size = new System.Drawing.Size(185, 22);
            this.txtTongLoaiHang.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(239, 34);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(308, 22);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvHH
            // 
            this.dgvHH.BackgroundColor = System.Drawing.Color.White;
            this.dgvHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHH.Location = new System.Drawing.Point(10, 117);
            this.dgvHH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHH.Name = "dgvHH";
            this.dgvHH.RowHeadersWidth = 62;
            this.dgvHH.RowTemplate.Height = 28;
            this.dgvHH.Size = new System.Drawing.Size(537, 202);
            this.dgvHH.TabIndex = 8;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.White;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Location = new System.Drawing.Point(1100, 0);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(53, 32);
            this.btnX.TabIndex = 13;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // ElipsePanel
            // 
            this.ElipsePanel.ElipseRadius = 30;
            this.ElipsePanel.TargetControl = this.panel1;
            // 
            // ElipseTimKiem
            // 
            this.ElipseTimKiem.ElipseRadius = 30;
            // 
            // fmChiTietTienHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1156, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fmChiTietTienHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmChiTietTienHang";
            this.Load += new System.EventHandler(this.fmChiTietTienHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox txtTongLoaiHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvHH;
        private System.Windows.Forms.Button btnX;
        private Bunifu.Framework.UI.BunifuElipse ElipseSapXep;
        private Bunifu.Framework.UI.BunifuElipse ElipsePanel;
        private Bunifu.Framework.UI.BunifuElipse ElipseTimKiem;
    }
}