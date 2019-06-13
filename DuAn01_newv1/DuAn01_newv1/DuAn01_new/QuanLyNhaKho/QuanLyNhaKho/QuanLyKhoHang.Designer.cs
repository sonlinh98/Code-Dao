namespace QuanLyNhaKho
{
    partial class QuanLyKhoHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPhieuxuat = new System.Windows.Forms.Button();
            this.btnPhieunhap = new System.Windows.Forms.Button();
            this.btnKiemKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 529);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnPhieuxuat);
            this.panel2.Controls.Add(this.btnPhieunhap);
            this.panel2.Controls.Add(this.btnKiemKe);
            this.panel2.Location = new System.Drawing.Point(23, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 312);
            this.panel2.TabIndex = 7;
            // 
            // btnPhieuxuat
            // 
            this.btnPhieuxuat.Location = new System.Drawing.Point(367, 62);
            this.btnPhieuxuat.Name = "btnPhieuxuat";
            this.btnPhieuxuat.Size = new System.Drawing.Size(175, 58);
            this.btnPhieuxuat.TabIndex = 10;
            this.btnPhieuxuat.Text = "Quản Lý Phiếu Xuất";
            this.btnPhieuxuat.UseVisualStyleBackColor = true;
            this.btnPhieuxuat.Click += new System.EventHandler(this.btnPhieuxuat_Click);
            // 
            // btnPhieunhap
            // 
            this.btnPhieunhap.Location = new System.Drawing.Point(119, 62);
            this.btnPhieunhap.Name = "btnPhieunhap";
            this.btnPhieunhap.Size = new System.Drawing.Size(175, 58);
            this.btnPhieunhap.TabIndex = 11;
            this.btnPhieunhap.Text = "Quản Lý Phiếu Nhập";
            this.btnPhieunhap.UseVisualStyleBackColor = true;
            this.btnPhieunhap.Click += new System.EventHandler(this.btnPhieunhap_Click);
            // 
            // btnKiemKe
            // 
            this.btnKiemKe.Location = new System.Drawing.Point(614, 62);
            this.btnKiemKe.Name = "btnKiemKe";
            this.btnKiemKe.Size = new System.Drawing.Size(175, 58);
            this.btnKiemKe.TabIndex = 12;
            this.btnKiemKe.Text = "Kiểm Kê Hàng Hóa";
            this.btnKiemKe.UseVisualStyleBackColor = true;
            this.btnKiemKe.Click += new System.EventHandler(this.btnKiemKe_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Kho Hàng Hóa";
            // 
            // QuanLyKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 554);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyKhoHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPhieuxuat;
        private System.Windows.Forms.Button btnPhieunhap;
        private System.Windows.Forms.Button btnKiemKe;

    }
}