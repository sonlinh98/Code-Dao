﻿using QuanLyNhaKho.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho
{
    public partial class QuanLyKhoHang : Form
    {
        private NhanVienDAO NVDangNhap = new NhanVienDAO();
        public QuanLyKhoHang()
        {
            InitializeComponent();
        }
        public QuanLyKhoHang(NhanVienDAO nhanviendangnhap)
        {
            InitializeComponent();
            NVDangNhap = nhanviendangnhap;
        }

        private void btnPhieunhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyPhieuNhap qlPhieuNhap = new QuanLyPhieuNhap(NVDangNhap);
            qlPhieuNhap.ShowDialog();
            this.Close();
        }

        private void btnPhieuxuat_Click(object sender, EventArgs e)
        {
           this.Hide();
           QuanLyPhieuXuat qlPhieuXuat = new QuanLyPhieuXuat(NVDangNhap);
            qlPhieuXuat.ShowDialog();
            this.Close();
        }

        private void btnKiemKe_Click(object sender, EventArgs e)
        {
            Hide();
            HangHoa hanghoa = new HangHoa(NVDangNhap);
            hanghoa.ShowDialog();
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            this.Close();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            Hide();
            QuanLyBaoCao baocao = new QuanLyBaoCao();
            baocao.ShowDialog();
            this.Close();
        }

        private void QuanLyKhoHang_Load(object sender, EventArgs e)
        {

        }



    }
}
