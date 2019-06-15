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
        public QuanLyKhoHang()
        {
            InitializeComponent();
        }

        private void btnPhieunhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyPhieuNhap qlPhieuNhap = new QuanLyPhieuNhap();
            qlPhieuNhap.ShowDialog();
            this.Close();
        }

        private void btnPhieuxuat_Click(object sender, EventArgs e)
        {
           this.Hide();
            QuanLyPhieuXuat qlPhieuXuat = new QuanLyPhieuXuat();
            qlPhieuXuat.ShowDialog();
            this.Close();
        }

        private void btnKiemKe_Click(object sender, EventArgs e)
        {
            Hide();
            HangHoa hanghoa = new HangHoa();
            hanghoa.ShowDialog();
            this.Close();
        }


    }
}
