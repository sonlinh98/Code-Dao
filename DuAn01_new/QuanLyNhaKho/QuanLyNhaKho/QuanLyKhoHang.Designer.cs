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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnPhieuxuat = new System.Windows.Forms.Button();
            this.btnPhieunhap = new System.Windows.Forms.Button();
            this.btnKiemKe = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 518);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnBaoCao);
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.btnPhieuxuat);
            this.panel2.Controls.Add(this.btnPhieunhap);
            this.panel2.Controls.Add(this.btnKiemKe);
            this.panel2.Location = new System.Drawing.Point(113, 164);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 310);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Kho Hàng Hóa";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Image = global::QuanLyNhaKho.Properties.Resources.baocao3;
            this.btnBaoCao.Location = new System.Drawing.Point(3, 177);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(211, 114);
            this.btnBaoCao.TabIndex = 14;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::QuanLyNhaKho.Properties.Resources.icons8_export_48;
            this.btnDangXuat.Location = new System.Drawing.Point(236, 177);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(211, 114);
            this.btnDangXuat.TabIndex = 13;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnPhieuxuat
            // 
            this.btnPhieuxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuxuat.Image = global::QuanLyNhaKho.Properties.Resources.xuatkho;
            this.btnPhieuxuat.Location = new System.Drawing.Point(232, 42);
            this.btnPhieuxuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhieuxuat.Name = "btnPhieuxuat";
            this.btnPhieuxuat.Size = new System.Drawing.Size(215, 116);
            this.btnPhieuxuat.TabIndex = 10;
            this.btnPhieuxuat.Text = "Quản Lý Phiếu Xuất";
            this.btnPhieuxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPhieuxuat.UseVisualStyleBackColor = true;
            this.btnPhieuxuat.Click += new System.EventHandler(this.btnPhieuxuat_Click);
            // 
            // btnPhieunhap
            // 
            this.btnPhieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieunhap.Image = global::QuanLyNhaKho.Properties.Resources.nhapkho;
            this.btnPhieunhap.Location = new System.Drawing.Point(2, 42);
            this.btnPhieunhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhieunhap.Name = "btnPhieunhap";
            this.btnPhieunhap.Size = new System.Drawing.Size(209, 116);
            this.btnPhieunhap.TabIndex = 11;
            this.btnPhieunhap.Text = "Quản Lý Phiếu Nhập";
            this.btnPhieunhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPhieunhap.UseVisualStyleBackColor = true;
            this.btnPhieunhap.Click += new System.EventHandler(this.btnPhieunhap_Click);
            // 
            // btnKiemKe
            // 
            this.btnKiemKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemKe.Image = global::QuanLyNhaKho.Properties.Resources.kiemke;
            this.btnKiemKe.Location = new System.Drawing.Point(466, 42);
            this.btnKiemKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnKiemKe.Name = "btnKiemKe";
            this.btnKiemKe.Size = new System.Drawing.Size(210, 116);
            this.btnKiemKe.TabIndex = 12;
            this.btnKiemKe.Text = "                              Kiểm Kê Hàng Hóa";
            this.btnKiemKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKiemKe.UseVisualStyleBackColor = true;
            this.btnKiemKe.Click += new System.EventHandler(this.btnKiemKe_Click);
            // 
            // QuanLyKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 538);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho hàng";
            this.Load += new System.EventHandler(this.QuanLyKhoHang_Load);
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
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDangXuat;

    }
}