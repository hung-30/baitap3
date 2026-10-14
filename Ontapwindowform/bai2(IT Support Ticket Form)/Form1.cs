using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bai2_IT_Support_Ticket_Form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Đăng ký các sự kiện khi khởi tạo Form
            this.Load += Form1_Load;
            btnGuiYeuCau.Click += btnGuiYeuCau_Click;
            btnNhapLai.Click += btnNhapLai_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình hiển thị ảnh tự động co giãn vừa khung PictureBox
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;

            // 2. Nạp các tùy chọn cho ComboBox Loại sự cố
            cboLoaiSuCo.Items.Clear();
            cboLoaiSuCo.Items.AddRange(new object[] {
                "Phần cứng",
                "Phần mềm",
                "Mạng",
                "Tài khoản"
            });

            // Set giá trị mặc định
            if (cboLoaiSuCo.Items.Count > 0)
            {
                cboLoaiSuCo.SelectedIndex = 0;
            }
            radThap.Checked = true;
        }

        // Xử lý sự kiện bấm nút "Tải ảnh lỗi" (trong Designer đang liên kết tới button1_Click)
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh chụp lỗi";
                openFileDialog.Filter = "Tệp hình ảnh (*.jpg; *.png)|*.jpg;*.png|Tất cả tệp (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picAnhLoi.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        // Xử lý sự kiện bấm nút "Gửi yêu cầu"
        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu nhập liệu bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên người yêu cầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiYeuCau.Focus();
                return;
            }

            // 2. Lấy Mức độ ưu tiên từ RadioButton
            string mucDoUuTien = "Thấp";
            if (radTrungBinh.Checked)
            {
                mucDoUuTien = "Trung bình";
            }
            else if (radKhanCap.Checked)
            {
                mucDoUuTien = "Khẩn cấp";
            }

            // 3. Lấy Danh sách các Thiết bị ảnh hưởng từ CheckBox
            List<string> thietBiList = new List<string>();
            if (chkMayTinhBan.Checked) thietBiList.Add("Máy tính bàn");
            if (chkLaptop.Checked) thietBiList.Add("Laptop");
            if (chkMayIn.Checked) thietBiList.Add("Máy in");
            if (chkDienThoai.Checked) thietBiList.Add("Điện thoại");

            string danhSachThietBi = thietBiList.Count > 0
                ? string.Join(", ", thietBiList)
                : "Không chọn";

            // 4. Lấy Loại sự cố từ ComboBox
            string loaiSuCo = cboLoaiSuCo.SelectedItem != null
                ? cboLoaiSuCo.SelectedItem.ToString()
                : "Chưa chọn";

            // 5. Tổng hợp thông tin tóm tắt và hiển thị MessageBox
            string thongTinTietKiem = "=== PHIẾU YÊU CẦU HỖ TRỢ IT ===\n\n" +
                                      $"• Mã phiếu: {txtMaPhieu.Text.Trim()}\n" +
                                      $"• Người yêu cầu: {txtNguoiYeuCau.Text.Trim()}\n" +
                                      $"• Ngày ghi nhận: {dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy")}\n" +
                                      $"• Mức độ ưu tiên: {mucDoUuTien}\n" +
                                      $"• Loại sự cố: {loaiSuCo}\n" +
                                      $"• Thiết bị ảnh hưởng: {danhSachThietBi}\n" +
                                      $"• Ảnh đính kèm: {(picAnhLoi.Image != null ? "Đã tải lên" : "Chưa có")}";

            MessageBox.Show(thongTinTietKiem, "Tóm tắt yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xử lý sự kiện bấm nút "Nhập lại"
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;

            radThap.Checked = true;
            if (cboLoaiSuCo.Items.Count > 0)
            {
                cboLoaiSuCo.SelectedIndex = 0;
            }

            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            if (picAnhLoi.Image != null)
            {
                picAnhLoi.Image.Dispose();
                picAnhLoi.Image = null;
            }

            txtMaPhieu.Focus();
        }

        // Giữ các hàm rỗng này để tránh lỗi biên dịch do Designer đã vô tình liên kết trước đó
        private void label1_Click(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
    }
}