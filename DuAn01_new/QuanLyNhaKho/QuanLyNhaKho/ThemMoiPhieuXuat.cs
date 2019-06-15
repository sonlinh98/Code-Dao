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
    public partial class ThemMoiPhieuXuat : Form
    {
        BLLayer02 layer02 = new BLLayer02();
        List<ChiTietHangHoaDAO> DanhSachHangHoaXuat = new List<ChiTietHangHoaDAO>();

        private double TongTien = 0;

        public ThemMoiPhieuXuat()
        {
            InitializeComponent();
        }

        private void ThemMoiPhieuXuat_Load(object sender, EventArgs e)
        {
            txtSoPhieuXuat.Text = SinhMaSoPhieuXuatTuDong();

            cboKho.DataSource = layer02.LayDanhSachNhaKho();
            cboKho.DisplayMember = "Tenkho";
            cboKho.ValueMember = "MaNK";
            cboKho.SelectedItem = null;
            cboKho.SelectedText = "--Chọn nhà kho--";

            cboNhaCungCap.DataSource = layer02.LayDanhSachNhaCungCap();
            cboNhaCungCap.DisplayMember = "TenNCC";
            cboNhaCungCap.ValueMember = "MaNCC";
            cboNhaCungCap.SelectedItem = null;
            cboNhaCungCap.SelectedText = "--Chọn nhà cung cấp--";

            // Khởi tạo danh sách hàng xuất
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa("");
            List<ChiTietHangHoaDAO> danhsachnull = new List<ChiTietHangHoaDAO>();
            danhsachnull.Add(chiTietMotSanPham);

            dgvDanhSachHangXuat.DataSource = danhsachnull;

            dgvDanhSachHangXuat.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangXuat.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangXuat.Columns["DVT"].HeaderText = "DVT";
            dgvDanhSachHangXuat.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachHangXuat.Columns["DonGia"].HeaderText = "Giá nhập";
            dgvDanhSachHangXuat.Columns["ThanhTien"].HeaderText = "Thành tiền";


            txtNhanVien.Text = "Đỗ Mạnh Quang";

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private string SinhMaSoPhieuXuatTuDong()
        {
            string maHangHoaGoc = layer02.LayMaSoPhieuXuatCuoiCung().Rows[0][0].ToString();// lấy ô đầu tiên của bảng kết quả trả về
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
            dgvDanhSachHangXuat.DataSource = null;

            // Cập nhật danh sách mới
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa(txtMaHH.Text);


            // Lấy dữ liệu số lượng nhập, giá nhập, thành tiền vào danh sách
            chiTietMotSanPham.DonGia = txtGiaXuat.Text;
            chiTietMotSanPham.SoLuong = txtSoLuongXuat.Text;
            chiTietMotSanPham.ThanhTien = (int.Parse(txtGiaXuat.Text) * int.Parse(txtSoLuongXuat.Text)).ToString();

            DanhSachHangHoaXuat.Add(chiTietMotSanPham);

            dgvDanhSachHangXuat.DataSource = DanhSachHangHoaXuat;

            dgvDanhSachHangXuat.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangXuat.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangXuat.Columns["DVT"].HeaderText = "DVT";
            dgvDanhSachHangXuat.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachHangXuat.Columns["DonGia"].HeaderText = "Giá nhập";
            dgvDanhSachHangXuat.Columns["ThanhTien"].HeaderText = "Thành tiền";

            // Tính tổng tiền mỗi khi thêm sản phẩm
            TongTien += int.Parse(txtSoLuongXuat.Text) * int.Parse(txtGiaXuat.Text);
            txtTongTien.Text = TongTien.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearDataThemMoiPhieuXuat()
        {
            txtSoPhieuXuat.Text = SinhMaSoPhieuXuatTuDong();

            txtNguoiNhanHang.Text = "";

            if (cboKho.SelectedItem != null)
            {
                cboKho.SelectedItem = null;
                cboKho.SelectedText = "--Chọn nhà kho--";
            }

            if (cboNhaCungCap.SelectedItem != null)
            {
                cboNhaCungCap.SelectedItem = null;
                cboNhaCungCap.SelectedText = "--Chọn nhà cung cấp";
            }

            txtGhiChu.Text = "";
            txtTongTien.Text = "0";

            TongTien = 0;


            txtMaHH.Text = "";
            txtSoLuongXuat.Text = "0";
            txtGiaXuat.Text = "0";

            dgvDanhSachHangXuat.DataSource = null;
            DanhSachHangHoaXuat.Clear();

            // Khởi tạo danh sách hàng xuất
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa("");
            List<ChiTietHangHoaDAO> danhsachnull = new List<ChiTietHangHoaDAO>();
            danhsachnull.Add(chiTietMotSanPham);

            dgvDanhSachHangXuat.DataSource = danhsachnull;

            dgvDanhSachHangXuat.Columns["MaHH"].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangXuat.Columns["TenHH"].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangXuat.Columns["DVT"].HeaderText = "DVT";
            dgvDanhSachHangXuat.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachHangXuat.Columns["DonGia"].HeaderText = "Giá nhập";
            dgvDanhSachHangXuat.Columns["ThanhTien"].HeaderText = "Thành tiền";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //txtNhanVien.Text
            layer02.ThemPhieuNhapHangVaoBangPhieuXuat(txtSoPhieuXuat.Text, cboKho.SelectedValue.ToString(), "NV00000001", dtpNgayXuat.Value, txtNguoiNhanHang.Text, txtGhiChu.Text, double.Parse(txtTongTien.Text), DanhSachHangHoaXuat);

            ClearDataThemMoiPhieuXuat();

            MessageBox.Show("Thêm phiếu nhập hàng thàng công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void txtMaHH_Validating(object sender, CancelEventArgs e)
        {
            ChiTietHangHoaDAO chiTietMotSanPham = layer02.LayThongTinMotHangHoaNhapTheoMa(txtMaHH.Text);

            // Tính giá xuất
            txtGiaXuat.Text = (int.Parse(chiTietMotSanPham.DonGia) + int.Parse(chiTietMotSanPham.DonGia) * 0.1).ToString();
        }



        private void dgvDanhSachHangXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvDanhSachHangXuat.CurrentCell.RowIndex;

            string tenHangClickHientai = dgvDanhSachHangXuat.Rows[rowindex].Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa có tên là: " + tenHangClickHientai + " không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                string maHangXoa = dgvDanhSachHangXuat.Rows[rowindex].Cells[0].Value.ToString();

                // cập nhật lại tổng tiền của hóa đơn
                TongTien -= double.Parse(dgvDanhSachHangXuat.Rows[rowindex].Cells[5].Value.ToString());
                txtTongTien.Text = TongTien.ToString();

                // Xóa bỏ hàng hóa đó trong danh sách mua
                int viTriXoa = -1;
                for (int i = 0; i < DanhSachHangHoaXuat.Count; i++)
                {
                    if (DanhSachHangHoaXuat[i].MaHH.Equals(maHangXoa))
                    {
                        viTriXoa = i;
                    }
                }
                DanhSachHangHoaXuat.RemoveAt(viTriXoa);

                // Cập nhật danh sách hàng nhập sau khi xóa

                dgvDanhSachHangXuat.DataSource = null;
                dgvDanhSachHangXuat.DataSource = DanhSachHangHoaXuat;

                dgvDanhSachHangXuat.Columns["MaHH"].HeaderText = "Mã hàng hóa";
                dgvDanhSachHangXuat.Columns["TenHH"].HeaderText = "Tên hàng hóa";
                dgvDanhSachHangXuat.Columns["DVT"].HeaderText = "DVT";
                dgvDanhSachHangXuat.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvDanhSachHangXuat.Columns["DonGia"].HeaderText = "Giá nhập";
                dgvDanhSachHangXuat.Columns["ThanhTien"].HeaderText = "Thành tiền";
            }
        }
    }
}
