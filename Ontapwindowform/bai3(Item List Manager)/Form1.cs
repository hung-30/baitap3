using System;
using System.Windows.Forms;

namespace bai3_Item_List_Manager_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Đăng ký sự kiện cho các nút bấm và ListView
            btnThemMoi.Click += btnThemMoi_Click;
            btnCapNhat.Click += btnCapNhat_Click;
            btnXoaDong.Click += btnXoaDong_Click;
            btnXoaToanBo.Click += btnXoaToanBo_Click;

            lvwVatTu.SelectedIndexChanged += lvwVatTu_SelectedIndexChanged;
            lvwVatTu.Resize += lvwVatTu_Resize; // Tự co giãn cột khi đổi kích thước ListView
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình ListView
            lvwVatTu.View = View.Details;
            lvwVatTu.FullRowSelect = true;
            lvwVatTu.GridLines = true;

            // 2. Tự động căn chỉnh độ rộng cột trải đều hết ListView
            ChinhDoRongCot();

            // 3. Nạp dữ liệu vào ComboBox Đơn vị tính
            cboDonViTinh.Items.Clear();
            cboDonViTinh.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDonViTinh.SelectedIndex = 0;
        }

        // --- HÀM CĂN CHỈNH ĐỘ RỘNG CỘT TRẢI ĐỀU BẢNG ---
        private void ChinhDoRongCot()
        {
            if (lvwVatTu.Columns.Count < 4) return;

            int tongRong = lvwVatTu.ClientSize.Width;

            // Chia tỉ lệ % độ rộng cho 4 cột (Tổng = 100%)
            colMaVT.Width = (int)(tongRong * 0.20);       // Mã VT: 20%
            colTenVT.Width = (int)(tongRong * 0.40);      // Tên VT: 40% (rộng hơn để chứa tên)
            colDonViTinh.Width = (int)(tongRong * 0.20);  // Đơn vị tính: 20%
            colDonGia.Width = (int)(tongRong * 0.20);     // Đơn giá: 20%
        }

        private void lvwVatTu_Resize(object sender, EventArgs e)
        {
            ChinhDoRongCot();
        }

        // --- CÁC HÀM BỔ TRỢ ---
        private void XoaForm()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtDonGia.Clear();
            if (cboDonViTinh.Items.Count > 0) cboDonViTinh.SelectedIndex = 0;
            txtMaVT.Focus();
        }

        // Kiểm tra trùng Mã VT trong ListView
        private bool KiemTraTrungMa(string maVT)
        {
            foreach (ListViewItem item in lvwVatTu.Items)
            {
                if (item.SubItems[0].Text.Equals(maVT, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        // --- XỬ LÝ SỰ KIỆN NÚT BẤM ---

        // 1. Chức năng "Thêm mới"
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maVT = txtMaVT.Text.Trim();
            string tenVT = txtTenVT.Text.Trim();
            string donViTinh = cboDonViTinh.SelectedItem?.ToString() ?? "";
            string strDonGia = txtDonGia.Text.Trim();

            // Validate để trống
            if (string.IsNullOrEmpty(maVT) || string.IsNullOrEmpty(tenVT) || string.IsNullOrEmpty(strDonGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vật tư!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Đơn giá phải là số hợp lệ
            if (!decimal.TryParse(strDonGia, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá nhập phải là số hợp lệ không âm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // Validate trùng Mã VT
            if (KiemTraTrungMa(maVT))
            {
                MessageBox.Show($"Mã vật tư '{maVT}' đã tồn tại trong danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return;
            }

            // Thêm dòng mới vào ListView
            ListViewItem item = new ListViewItem(maVT);
            item.SubItems.Add(tenVT);
            item.SubItems.Add(donViTinh);
            item.SubItems.Add(donGia.ToString("N0"));

            lvwVatTu.Items.Add(item);
            XoaForm();
        }

        // 2. Chức năng chọn dòng trong ListView đẩy ngược dữ liệu lên TextBox/ComboBox
        private void lvwVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwVatTu.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwVatTu.SelectedItems[0];
                txtMaVT.Text = selectedItem.SubItems[0].Text;
                txtTenVT.Text = selectedItem.SubItems[1].Text;
                cboDonViTinh.SelectedItem = selectedItem.SubItems[2].Text;

                // Lấy giá trị đơn giá (loại bỏ dấu phân cách hàng nghìn nếu có)
                string donGiaStr = selectedItem.SubItems[3].Text.Replace(",", "").Replace(".", "");
                txtDonGia.Text = donGiaStr;
            }
        }

        // 3. Chức năng "Cập nhật"
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvwVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng trong danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem selectedItem = lvwVatTu.SelectedItems[0];
            string maVTMoi = txtMaVT.Text.Trim();
            string tenVT = txtTenVT.Text.Trim();
            string donViTinh = cboDonViTinh.SelectedItem?.ToString() ?? "";
            string strDonGia = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(maVTMoi) || string.IsNullOrEmpty(tenVT) || string.IsNullOrEmpty(strDonGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(strDonGia, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá nhập phải là số hợp lệ không âm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng Mã VT với các dòng khác
            if (!selectedItem.SubItems[0].Text.Equals(maVTMoi, StringComparison.OrdinalIgnoreCase) && KiemTraTrungMa(maVTMoi))
            {
                MessageBox.Show($"Mã vật tư '{maVTMoi}' đã bị trùng với vật tư khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return;
            }

            // Cập nhật lại thông tin dòng đang chọn
            selectedItem.SubItems[0].Text = maVTMoi;
            selectedItem.SubItems[1].Text = tenVT;
            selectedItem.SubItems[2].Text = donViTinh;
            selectedItem.SubItems[3].Text = donGia.ToString("N0");

            MessageBox.Show("Cập nhật thông tin vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaForm();
        }

        // 4. Chức năng "Xóa dòng"
        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lvwVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư đang chọn không?",
                                                 "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                lvwVatTu.Items.Remove(lvwVatTu.SelectedItems[0]);
                XoaForm();
            }
        }

        // 5. Chức năng "Xóa toàn bộ"
        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (lvwVatTu.Items.Count == 0)
            {
                MessageBox.Show("Danh sách vật tư hiện đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa TOÀN BỘ danh sách vật tư không?",
                                                 "Xác nhận xóa toàn bộ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                lvwVatTu.Items.Clear();
                XoaForm();
            }
        }

        // Giữ các hàm rỗng này để tránh lỗi biên dịch do Designer đã tạo sẵn
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}