namespace QuanLyNhaKho
{
    partial class HangHoa
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
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHanghoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDanhmuc = new System.Windows.Forms.ComboBox();
            this.cmbNhakho = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLuaChonIn = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btnHetHan = new System.Windows.Forms.Button();
            this.btnSapHetHan = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnTonkho = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(250, 33);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(247, 22);
            this.txtTenhang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Hàng";
            // 
            // dgvHanghoa
            // 
            this.dgvHanghoa.AllowUserToAddRows = false;
            this.dgvHanghoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHanghoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHanghoa.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvHanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanghoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvHanghoa.Location = new System.Drawing.Point(0, 207);
            this.dgvHanghoa.Name = "dgvHanghoa";
            this.dgvHanghoa.RowTemplate.Height = 24;
            this.dgvHanghoa.Size = new System.Drawing.Size(1054, 312);
            this.dgvHanghoa.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHH";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHH";
            this.Column2.HeaderText = "Tên Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Giavon";
            this.Column3.HeaderText = "Giá Vốn";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Soluong";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Dvt";
            this.Column5.HeaderText = "Đơn vị tính";
            this.Column5.Name = "Column5";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Hansudung";
            this.Column9.HeaderText = "Hạn Sử Dụng";
            this.Column9.Name = "Column9";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenDM";
            this.Column6.HeaderText = "Danh Mục";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenNK";
            this.Column7.HeaderText = "Nhà kho";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Mota";
            this.Column8.HeaderText = "Mô tả";
            this.Column8.Name = "Column8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhà kho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Danh mục";
            // 
            // cmbDanhmuc
            // 
            this.cmbDanhmuc.FormattingEnabled = true;
            this.cmbDanhmuc.Location = new System.Drawing.Point(670, 73);
            this.cmbDanhmuc.Name = "cmbDanhmuc";
            this.cmbDanhmuc.Size = new System.Drawing.Size(247, 24);
            this.cmbDanhmuc.TabIndex = 6;
            // 
            // cmbNhakho
            // 
            this.cmbNhakho.FormattingEnabled = true;
            this.cmbNhakho.Location = new System.Drawing.Point(670, 29);
            this.cmbNhakho.Name = "cmbNhakho";
            this.cmbNhakho.Size = new System.Drawing.Size(247, 24);
            this.cmbNhakho.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lựa chọn in:";
            // 
            // cboLuaChonIn
            // 
            this.cboLuaChonIn.FormattingEnabled = true;
            this.cboLuaChonIn.Location = new System.Drawing.Point(255, 73);
            this.cboLuaChonIn.Name = "cboLuaChonIn";
            this.cboLuaChonIn.Size = new System.Drawing.Size(201, 24);
            this.cboLuaChonIn.TabIndex = 8;
            this.cboLuaChonIn.SelectedIndexChanged += new System.EventHandler(this.cboLuaChonIn_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnQuaylai);
            this.panel1.Controls.Add(this.cboLuaChonIn);
            this.panel1.Controls.Add(this.btnHetHan);
            this.panel1.Controls.Add(this.cmbNhakho);
            this.panel1.Controls.Add(this.btnSapHetHan);
            this.panel1.Controls.Add(this.cmbDanhmuc);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.btnTonkho);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTenhang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 199);
            this.panel1.TabIndex = 9;
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Image = global::QuanLyNhaKho.Properties.Resources.icons8_left_26;
            this.btnQuaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuaylai.Location = new System.Drawing.Point(12, 10);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Padding = new System.Windows.Forms.Padding(22, 0, 18, 0);
            this.btnQuaylai.Size = new System.Drawing.Size(138, 37);
            this.btnQuaylai.TabIndex = 7;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnHetHan
            // 
            this.btnHetHan.Image = global::QuanLyNhaKho.Properties.Resources.icons8_warning_24;
            this.btnHetHan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHetHan.Location = new System.Drawing.Point(104, 138);
            this.btnHetHan.Name = "btnHetHan";
            this.btnHetHan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHetHan.Size = new System.Drawing.Size(138, 37);
            this.btnHetHan.TabIndex = 0;
            this.btnHetHan.Text = "Hàng Hết Hạn";
            this.btnHetHan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHetHan.UseVisualStyleBackColor = true;
            this.btnHetHan.Click += new System.EventHandler(this.btnHetHan_Click);
            // 
            // btnSapHetHan
            // 
            this.btnSapHetHan.Image = global::QuanLyNhaKho.Properties.Resources.icons8_expired_24;
            this.btnSapHetHan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapHetHan.Location = new System.Drawing.Point(264, 138);
            this.btnSapHetHan.Name = "btnSapHetHan";
            this.btnSapHetHan.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSapHetHan.Size = new System.Drawing.Size(160, 37);
            this.btnSapHetHan.TabIndex = 1;
            this.btnSapHetHan.Text = "Hàng Sắp Hết Hạn";
            this.btnSapHetHan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSapHetHan.UseVisualStyleBackColor = true;
            this.btnSapHetHan.Click += new System.EventHandler(this.btnSapHetHan_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = global::QuanLyNhaKho.Properties.Resources.icons8_view_24;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(759, 138);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(28, 0, 20, 0);
            this.btnTimkiem.Size = new System.Drawing.Size(149, 37);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnTonkho
            // 
            this.btnTonkho.Image = global::QuanLyNhaKho.Properties.Resources.icons8_open_box_24;
            this.btnTonkho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTonkho.Location = new System.Drawing.Point(445, 138);
            this.btnTonkho.Name = "btnTonkho";
            this.btnTonkho.Padding = new System.Windows.Forms.Padding(25, 0, 14, 0);
            this.btnTonkho.Size = new System.Drawing.Size(136, 37);
            this.btnTonkho.TabIndex = 2;
            this.btnTonkho.Text = "Tồn Kho";
            this.btnTonkho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTonkho.UseVisualStyleBackColor = true;
            this.btnTonkho.Click += new System.EventHandler(this.btnTonkho_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::QuanLyNhaKho.Properties.Resources.icons8_print_26;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(601, 138);
            this.btnIn.Name = "btnIn";
            this.btnIn.Padding = new System.Windows.Forms.Padding(16, 0, 5, 0);
            this.btnIn.Size = new System.Drawing.Size(136, 37);
            this.btnIn.TabIndex = 0;
            this.btnIn.TabStop = false;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHanghoa);
            this.Name = "HangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hàng Hóa";
            this.Load += new System.EventHandler(this.HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHanghoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDanhmuc;
        private System.Windows.Forms.ComboBox cmbNhakho;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btnSapHetHan;
        private System.Windows.Forms.Button btnHetHan;
        private System.Windows.Forms.Button btnTonkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLuaChonIn;
        private System.Windows.Forms.Panel panel1;
    }
}