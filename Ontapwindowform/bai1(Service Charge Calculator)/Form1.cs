using System;
using System.Windows.Forms;

namespace bai1_Service_Charge_Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện Click cho nút bấm (nếu trong Designer chưa gán)
            btnTinhTien.Click += btnTinhTien_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cấu hình ô Tổng tiền chỉ dùng để hiển thị kết quả, không cho nhập/sửa
            txtTongTien.ReadOnly = true;
        }

        // Xử lý nút "Tính tiền"
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra ô Đơn giá (không trống, phải là số >= 0)
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Vui lòng nhập Đơn giá dịch vụ hợp lệ (chỉ nhập số không âm)!",
                                "Cảnh báo nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // 2. Kiểm tra ô Số lượng (không trống, phải là số nguyên > 0)
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập Số lượng khách hợp lệ (chỉ nhập số nguyên > 0)!",
                                "Cảnh báo nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            // 3. Kiểm tra ô Mã giảm giá (% giảm giá, nếu để trống thì mặc định là 0%)
            decimal phanTramGiam = 0;
            string strGiamGia = txtMaGiamGia.Text.Trim();
            if (!string.IsNullOrEmpty(strGiamGia))
            {
                if (!decimal.TryParse(strGiamGia, out phanTramGiam) || phanTramGiam < 0 || phanTramGiam > 100)
                {
                    MessageBox.Show("Vui lòng nhập % giảm giá hợp lệ (từ 0 đến 100)!",
                                    "Cảnh báo nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaGiamGia.Focus();
                    return;
                }
            }

            // 4. Tính toán tổng tiền theo công thức: (Đơn giá * Số lượng) * (100 - % Giảm) / 100
            decimal tongTien = (donGia * soLuong) * (100 - phanTramGiam) / 100m;

            // 5. Hiển thị kết quả ra txtTongTien (định dạng phân cách hàng nghìn)
            txtTongTien.Text = string.Format("{0:N0} VNĐ", tongTien);
        }

        // Xử lý nút "Làm mới"
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtMaGiamGia.Clear();
            txtTongTien.Text = "0";

            // Đưa con trỏ chuột về lại ô Đơn giá
            txtDonGia.Focus();
        }

        // Giữ lại các hàm sự kiện rỗng này để tránh lỗi biên dịch do Designer đã tự động sinh ra
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}   