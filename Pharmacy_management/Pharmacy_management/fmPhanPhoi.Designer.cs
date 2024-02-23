
namespace Pharmacy_management
{
    partial class fmPhanPhoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuongcs1 = new System.Windows.Forms.TextBox();
            this.txtSoLuongcs2 = new System.Windows.Forms.TextBox();
            this.txtSoLuongcs3 = new System.Windows.Forms.TextBox();
            this.txtSoLuongcs4 = new System.Windows.Forms.TextBox();
            this.btnPhanPhoi = new System.Windows.Forms.Button();
            this.txtIdHH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cơ Sở 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Co Sở 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cơ Sở 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cơ Sở 4";
            // 
            // txtSoLuongcs1
            // 
            this.txtSoLuongcs1.Location = new System.Drawing.Point(66, 56);
            this.txtSoLuongcs1.Name = "txtSoLuongcs1";
            this.txtSoLuongcs1.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongcs1.TabIndex = 4;
            this.txtSoLuongcs1.Text = "0";
            // 
            // txtSoLuongcs2
            // 
            this.txtSoLuongcs2.Location = new System.Drawing.Point(66, 104);
            this.txtSoLuongcs2.Name = "txtSoLuongcs2";
            this.txtSoLuongcs2.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongcs2.TabIndex = 5;
            this.txtSoLuongcs2.Text = "0";
            // 
            // txtSoLuongcs3
            // 
            this.txtSoLuongcs3.Location = new System.Drawing.Point(66, 151);
            this.txtSoLuongcs3.Name = "txtSoLuongcs3";
            this.txtSoLuongcs3.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongcs3.TabIndex = 6;
            this.txtSoLuongcs3.Text = "0";
            // 
            // txtSoLuongcs4
            // 
            this.txtSoLuongcs4.Location = new System.Drawing.Point(66, 200);
            this.txtSoLuongcs4.Name = "txtSoLuongcs4";
            this.txtSoLuongcs4.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongcs4.TabIndex = 7;
            this.txtSoLuongcs4.Text = "0";
            // 
            // btnPhanPhoi
            // 
            this.btnPhanPhoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPhanPhoi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPhanPhoi.Location = new System.Drawing.Point(51, 245);
            this.btnPhanPhoi.Name = "btnPhanPhoi";
            this.btnPhanPhoi.Size = new System.Drawing.Size(75, 23);
            this.btnPhanPhoi.TabIndex = 8;
            this.btnPhanPhoi.Text = "Phân Phối";
            this.btnPhanPhoi.UseVisualStyleBackColor = false;
            this.btnPhanPhoi.Click += new System.EventHandler(this.btnPhanPhoi_Click);
            // 
            // txtIdHH
            // 
            this.txtIdHH.Location = new System.Drawing.Point(66, 17);
            this.txtIdHH.Name = "txtIdHH";
            this.txtIdHH.Size = new System.Drawing.Size(100, 20);
            this.txtIdHH.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID hàng";
            // 
            // fmPhanPhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 288);
            this.Controls.Add(this.txtIdHH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPhanPhoi);
            this.Controls.Add(this.txtSoLuongcs4);
            this.Controls.Add(this.txtSoLuongcs3);
            this.Controls.Add(this.txtSoLuongcs2);
            this.Controls.Add(this.txtSoLuongcs1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmPhanPhoi";
            this.Text = "fmPhanPhoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPhanPhoi;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtIdHH;
        public System.Windows.Forms.TextBox txtSoLuongcs1;
        public System.Windows.Forms.TextBox txtSoLuongcs2;
        public System.Windows.Forms.TextBox txtSoLuongcs3;
        public System.Windows.Forms.TextBox txtSoLuongcs4;
    }
}