namespace QuanLyNhaKho
{
    partial class FormQuanLyVien
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
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLNCC = new System.Windows.Forms.Button();
            this.btnQLNH = new System.Windows.Forms.Button();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chức Năng Quản Lý Viên";
            // 
            // btnQLKH
            // 
            this.btnQLKH.Image = global::QuanLyNhaKho.Properties.Resources.nhanvien;
            this.btnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.Location = new System.Drawing.Point(288, 239);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(213, 61);
            this.btnQLKH.TabIndex = 1;
            this.btnQLKH.Text = "Quản Lý Khách Hàng";
            this.btnQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLNCC
            // 
            this.btnQLNCC.Image = global::QuanLyNhaKho.Properties.Resources.icons8_supplier_53;
            this.btnQLNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNCC.Location = new System.Drawing.Point(58, 239);
            this.btnQLNCC.Name = "btnQLNCC";
            this.btnQLNCC.Size = new System.Drawing.Size(212, 61);
            this.btnQLNCC.TabIndex = 1;
            this.btnQLNCC.Text = "Quản Lý Nhà Cung Cấp";
            this.btnQLNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNCC.UseVisualStyleBackColor = true;
            this.btnQLNCC.Click += new System.EventHandler(this.btnQLNCC_Click);
            // 
            // btnQLNH
            // 
            this.btnQLNH.Image = global::QuanLyNhaKho.Properties.Resources.sanpham;
            this.btnQLNH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNH.Location = new System.Drawing.Point(528, 239);
            this.btnQLNH.Name = "btnQLNH";
            this.btnQLNH.Size = new System.Drawing.Size(212, 61);
            this.btnQLNH.TabIndex = 1;
            this.btnQLNH.Text = "Quản Lý Nhóm Hàng";
            this.btnQLNH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNH.UseVisualStyleBackColor = true;
            this.btnQLNH.Click += new System.EventHandler(this.btnQLNH_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.Image = global::QuanLyNhaKho.Properties.Resources.nhakho;
            this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.Location = new System.Drawing.Point(419, 140);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(225, 64);
            this.btnKhoHang.TabIndex = 1;
            this.btnKhoHang.Text = "Quản Lý Kho Hàng";
            this.btnKhoHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhoHang.UseVisualStyleBackColor = true;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Image = global::QuanLyNhaKho.Properties.Resources.kh;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(198, 140);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(187, 64);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản Lý Nhân Viên";
            this.btnQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // FormQuanLyVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 375);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnQLNCC);
            this.Controls.Add(this.btnQLNH);
            this.Controls.Add(this.btnKhoHang);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLyVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Button btnQLNH;
        private System.Windows.Forms.Button btnQLNCC;
        private System.Windows.Forms.Button btnQLKH;
    }
}