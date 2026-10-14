using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bai4_Interactive_Slot_Booking_
{
    public partial class Form1 : Form
    {
        // Định nghĩa các màu trạng thái
        private readonly Color MAU_TRONG = Color.White;          // Trắng (Trống)
        private readonly Color MAU_DANG_CHON = Color.LightGreen; // Xanh lá (Đang chọn)
        private readonly Color MAU_DA_DAT = Color.LightCoral;    // Đỏ (Đã xác nhận đặt)

        public Form1()
        {
            InitializeComponent();

            // Đăng ký sự kiện
            this.Load += Form1_Load;
            btnXacNhanDat.Click += btnXacNhanDat_Click;
            btnHuyChon.Click += btnHuyChon_Click; // Đảm bảo gán sự kiện cho nút Hủy
            cboKhungGio.SelectedIndexChanged += cboKhungGio_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhungGio.Items.Clear();
            cboKhungGio.Items.Add("Sáng (100.000đ)");
            cboKhungGio.Items.Add("Tối (150.000đ)");
            cboKhungGio.SelectedIndex = 0;

            ThietLapTableLayoutPanel();
            KhoiTao20ButtonDong();
            CapNhatThongKe();
        }

        private void ThietLapTableLayoutPanel()
        {
            tblSoDo.Controls.Clear();
            tblSoDo.ColumnCount = 5;
            tblSoDo.RowCount = 4;

            tblSoDo.ColumnStyles.Clear();
            for (int i = 0; i < 5; i++)
                tblSoDo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

            tblSoDo.RowStyles.Clear();
            for (int i = 0; i < 4; i++)
                tblSoDo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        }

        private void KhoiTao20ButtonDong()
        {
            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button
                {
                    Text = $"Vị trí {i}",
                    Dock = DockStyle.Fill,
                    Margin = new Padding(3),
                    BackColor = MAU_TRONG,
                    UseVisualStyleBackColor = false,
                    FlatStyle = FlatStyle.Flat
                };

                btn.Click += BtnViTri_Click;
                tblSoDo.Controls.Add(btn);
            }
        }

        // Xử lý khi bấm trực tiếp vào từng ô vị trí
        private void BtnViTri_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            int mauHienTai = btn.BackColor.ToArgb();

            // Ô màu Trắng -> Đổi sang Xanh
            if (mauHienTai == MAU_TRONG.ToArgb())
            {
                btn.BackColor = MAU_DANG_CHON;
            }
            // Ô màu Xanh -> Đổi về Trắng
            else if (mauHienTai == MAU_DANG_CHON.ToArgb())
            {
                btn.BackColor = MAU_TRONG;
            }
            // Ô màu Đỏ -> Hỏi có muốn Hủy đặt vị trí này không
            else if (mauHienTai == MAU_DA_DAT.ToArgb())
            {
                DialogResult dr = MessageBox.Show(
                    $"Bạn có muốn hủy đặt {btn.Text} không?",
                    "Xác nhận hủy vị trí",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    btn.BackColor = MAU_TRONG;
                }
            }

            CapNhatThongKe();
        }

        private void CapNhatThongKe()
        {
            int soViTriChon = 0;

            foreach (Control ctrl in tblSoDo.Controls)
            {
                if (ctrl is Button btn && btn.BackColor.ToArgb() == MAU_DANG_CHON.ToArgb())
                {
                    soViTriChon++;
                }
            }

            decimal donGia = (cboKhungGio.SelectedIndex == 1) ? 150000m : 100000m;
            decimal tongTien = soViTriChon * donGia;

            lblSoViTriChon.Text = $"Số vị trí đang chọn: {soViTriChon}";
            lblTamTinhTien.Text = $"Tạm tính tiền: {tongTien:N0} VNĐ";
        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongKe();
        }

        // Nút "Xác nhận đặt"
        private void btnXacNhanDat_Click(object sender, EventArgs e)
        {
            List<string> dsViTri = new List<string>();

            foreach (Control ctrl in tblSoDo.Controls)
            {
                if (ctrl is Button btn && btn.BackColor.ToArgb() == MAU_DANG_CHON.ToArgb())
                {
                    dsViTri.Add(btn.Text);
                    btn.BackColor = MAU_DA_DAT; // Chuyển sang màu Đỏ
                }
            }

            if (dsViTri.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 vị trí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string khungGioStr = cboKhungGio.SelectedItem.ToString();
            MessageBox.Show($"Đặt chỗ thành công các vị trí: {string.Join(", ", dsViTri)}\nKhung giờ: {khungGioStr}",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CapNhatThongKe();
        }

        // --- NÚT "HỦY CHỌN" (ĐÃ SỬA: XÓA CẢ MÀU ĐỎ VÀ MÀU XANH VỀ TRẮNG) ---
        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in tblSoDo.Controls)
            {
                if (ctrl is Button btn)
                {
                    // Trả tất cả các nút về màu Trắng (Trống)
                    btn.BackColor = MAU_TRONG;
                    btn.Enabled = true;
                }
            }

            // Reset thống kê về 0
            CapNhatThongKe();
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}