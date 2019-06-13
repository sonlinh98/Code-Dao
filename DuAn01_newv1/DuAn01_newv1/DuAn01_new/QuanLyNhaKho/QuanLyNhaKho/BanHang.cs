using QuanLyNhaKho.DAO;
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
    public partial class BanHang : Form
    {
        BLLayer02 layer02 = new BLLayer02();
        private List<ChiTietHangHoaDAO> DanhSachHangBan = new List<ChiTietHangHoaDAO>();
        private double TongTien = 0;
        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = SinhMaSoHoaDonTuDong();

            txtNhanVien.Text = "Đỗ Mạnh Quang";


            // Khởi tạo danh sách hàng xuất
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa("");
            List<ChiTietHangHoaDAO> danhsachnull = new List<ChiTietHangHoaDAO>();
            danhsachnull.Add(chiTietMotSanPham);

            dgvDanhSachHangMua.DataSource = danhsachnull;

            dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
            dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Giá nhập";
            dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";


        }



        private string SinhMaSoHoaDonTuDong()
        {
            string maHangHoaGoc = layer02.LayMaHoaDonCuoiCung().Rows[0][0].ToString();// lấy ô đầu tiên của bảng kết quả trả về
            string kyTuDau = maHangHoaGoc.Substring(0, 2);
            int soCanTang = Convert.ToInt32(maHangHoaGoc.Substring(2)) + 1;

            string maHangHoa = "";
            if (soCanTang >= 0 && soCanTang < 10)
                maHangHoa = kyTuDau + "0000" + soCanTang;
            if (soCanTang >= 10 && soCanTang < 100)
                maHangHoa = kyTuDau + "000" + soCanTang;
            if (soCanTang >= 100 && soCanTang < 1000)
                maHangHoa = kyTuDau + "00" + soCanTang;
            if (soCanTang >= 1000 && soCanTang < 10000)
                maHangHoa = kyTuDau + "0" + soCanTang;
            if (soCanTang >= 10000 && soCanTang < 100000)
                maHangHoa = kyTuDau + soCanTang;
            if (soCanTang >= 100000)
                maHangHoa = "Không thể tăng hơn nữa!";

            return maHangHoa;
        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            // Xóa bỏ danh sách hàng hóa cũ
            dgvDanhSachHangMua.DataSource = null;

            // Cập nhật danh sách mới
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa(txtMaHH.Text);


            // Lấy dữ liệu số lượng nhập, giá nhập, thành tiền vào danh sách
            chiTietMotSanPham.DonGia = txtGiaBan.Text;
            chiTietMotSanPham.SoLuong = txtSoLuongMua.Text;
            chiTietMotSanPham.ThanhTien = (int.Parse(txtGiaBan.Text) * int.Parse(txtSoLuongMua.Text)).ToString();

            DanhSachHangBan.Add(chiTietMotSanPham);

            dgvDanhSachHangMua.DataSource = DanhSachHangBan;

            dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
            dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Giá nhập";
            dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";

            // Tính tổng tiền mỗi khi thêm sản phẩm
            TongTien += int.Parse(txtSoLuongMua.Text) * int.Parse(txtGiaBan.Text);
            txtTongTien.Text = TongTien.ToString();

            // xóa bỏ số lượng
            txtSoLuongMua.Text = "";
        }

        private void txtMaHH_Validating(object sender, CancelEventArgs e)
        {
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa(txtMaHH.Text);

            // Tính giá xuất
            txtGiaBan.Text = (int.Parse(chiTietMotSanPham.DonGia) + int.Parse(chiTietMotSanPham.DonGia) * 0.1).ToString();
        }

        private void dgvDanhSachHangMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvDanhSachHangMua.CurrentCell.RowIndex;

            string tenHangClickHientai = dgvDanhSachHangMua.Rows[rowindex].Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa có tên là: " + tenHangClickHientai + " không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                string maHangXoa = dgvDanhSachHangMua.Rows[rowindex].Cells[0].Value.ToString();
                // cập nhật lại tổng tiền của hóa đơn
                TongTien -= double.Parse(dgvDanhSachHangMua.Rows[rowindex].Cells[5].Value.ToString());
                txtTongTien.Text = TongTien.ToString();


                // Xóa bỏ hàng hóa đó trong danh sách mua
                int viTriXoa = -1;
                for (int i = 0; i < DanhSachHangBan.Count; i++)
                {
                    if (DanhSachHangBan[i].MaHH.Equals(maHangXoa))
                    {
                        viTriXoa = i;
                    }
                }
                DanhSachHangBan.RemoveAt(viTriXoa);

                // Cập nhật danh sách hàng nhập sau khi xóa

                dgvDanhSachHangMua.DataSource = null;
                dgvDanhSachHangMua.DataSource = DanhSachHangBan;

                dgvDanhSachHangMua.Columns["MaHH"].HeaderText = "Mã hàng hóa";
                dgvDanhSachHangMua.Columns["TenHH"].HeaderText = "Tên hàng hóa";
                dgvDanhSachHangMua.Columns["DVT"].HeaderText = "DVT";
                dgvDanhSachHangMua.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvDanhSachHangMua.Columns["DonGia"].HeaderText = "Giá nhập";
                dgvDanhSachHangMua.Columns["ThanhTien"].HeaderText = "Thành tiền";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

            Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            this.Close();
        }
        private void ClearDataHoaDonBanHang()
        {
            txtMaHD.Text = SinhMaSoHoaDonTuDong();


            // reset thông tin khách hàng
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";


            TongTien = 0;
            txtTongTien.Text = TongTien.ToString();


            // xóa bỏ danh sách hàng bán
            DanhSachHangBan.Clear();
            dgvDanhSachHangMua.DataSource = null;

            txtSoLuongMua.Text = "0";
            txtMaHH.Text = "";

            txtGhiChu.Text = "";
            txtGiaBan.Text = "0";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            layer02.ThanhToanVaThemHoaDonBanHang(txtMaHD.Text, "NV00000001", dtpNgayMua.Value, txtGhiChu.Text, double.Parse(txtTongTien.Text),txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, DanhSachHangBan);


            MessageBox.Show("Thanh toán và tạo hóa đơn thàng công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearDataHoaDonBanHang();
        }
    }
}
