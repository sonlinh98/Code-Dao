namespace QuanLyNhaKho
{
    partial class ThemMoiPhieuNhap
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
            this.dgvDanhSachHangMua = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaHangHoa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTaoMoiHangHoa = new System.Windows.Forms.Label();
            this.btnThemMatHang = new System.Windows.Forms.Button();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtNguoiGiaoHang = new System.Windows.Forms.TextBox();
            this.txtSoPhieuNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangMua)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachHangMua
            // 
            this.dgvDanhSachHangMua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHangMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHangMua.Location = new System.Drawing.Point(7, 72);
            this.dgvDanhSachHangMua.Name = "dgvDanhSachHangMua";
            this.dgvDanhSachHangMua.RowTemplate.Height = 24;
            this.dgvDanhSachHangMua.Size = new System.Drawing.Size(942, 207);
            this.dgvDanhSachHangMua.TabIndex = 5;
            this.dgvDanhSachHangMua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHangMua_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(645, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Giá nhập:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số lượng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hàng hóa:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(502, 32);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Location = new System.Drawing.Point(115, 32);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(196, 22);
            this.txtMaHangHoa.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTaoMoiHangHoa);
            this.groupBox2.Controls.Add(this.btnThemMatHang);
            this.groupBox2.Controls.Add(this.dgvDanhSachHangMua);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtMaHangHoa);
            this.groupBox2.Location = new System.Drawing.Point(13, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(949, 285);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu";
            // 
            // lbTaoMoiHangHoa
            // 
            this.lbTaoMoiHangHoa.AutoSize = true;
            this.lbTaoMoiHangHoa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbTaoMoiHangHoa.Location = new System.Drawing.Point(314, 35);
            this.lbTaoMoiHangHoa.Name = "lbTaoMoiHangHoa";
            this.lbTaoMoiHangHoa.Size = new System.Drawing.Size(58, 16);
            this.lbTaoMoiHangHoa.TabIndex = 6;
            this.lbTaoMoiHangHoa.Text = "Tạo mới";
            this.lbTaoMoiHangHoa.Click += new System.EventHandler(this.lbTaoMoiHangHoa_Click);
            // 
            // btnThemMatHang
            // 
            this.btnThemMatHang.Location = new System.Drawing.Point(851, 32);
            this.btnThemMatHang.Name = "btnThemMatHang";
            this.btnThemMatHang.Size = new System.Drawing.Size(75, 23);
            this.btnThemMatHang.TabIndex = 3;
            this.btnThemMatHang.Text = "Thêm";
            this.btnThemMatHang.UseVisualStyleBackColor = true;
            this.btnThemMatHang.Click += new System.EventHandler(this.btnThemMatHang_Click);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(716, 32);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(100, 22);
            this.txtGiaNhap.TabIndex = 2;
            this.txtGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(157, 150);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(154, 24);
            this.cboNhaCungCap.TabIndex = 4;
            // 
            // cboKho
            // 
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(157, 119);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(154, 24);
            this.cboKho.TabIndex = 3;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(157, 56);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayNhap.TabIndex = 1;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(572, 142);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(192, 22);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(572, 108);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(313, 22);
            this.txtMaNV.TabIndex = 6;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(572, 25);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(340, 77);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtNguoiGiaoHang
            // 
            this.txtNguoiGiaoHang.Location = new System.Drawing.Point(157, 84);
            this.txtNguoiGiaoHang.Name = "txtNguoiGiaoHang";
            this.txtNguoiGiaoHang.Size = new System.Drawing.Size(154, 22);
            this.txtNguoiGiaoHang.TabIndex = 2;
            // 
            // txtSoPhieuNhap
            // 
            this.txtSoPhieuNhap.Location = new System.Drawing.Point(157, 31);
            this.txtSoPhieuNhap.Name = "txtSoPhieuNhap";
            this.txtSoPhieuNhap.Size = new System.Drawing.Size(154, 22);
            this.txtSoPhieuNhap.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập tại kho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Người giao hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNhaCungCap);
            this.groupBox1.Controls.Add(this.cboKho);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtNguoiGiaoHang);
            this.groupBox1.Controls.Add(this.txtSoPhieuNhap);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(410, 510);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 34);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(585, 510);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(103, 34);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Coral;
            this.label12.Location = new System.Drawing.Point(20, 498);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Click vào dòng hàng hóa để xóa";
            // 
            // ThemMoiPhieuNhap
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 571);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemMoiPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới phiếu nhập kho";
            this.Load += new System.EventHandler(this.ThemMoiPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangMua)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachHangMua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaHangHoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtNguoiGiaoHang;
        private System.Windows.Forms.TextBox txtSoPhieuNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemMatHang;
        private System.Windows.Forms.Label lbTaoMoiHangHoa;
        private System.Windows.Forms.Label label12;
    }
}