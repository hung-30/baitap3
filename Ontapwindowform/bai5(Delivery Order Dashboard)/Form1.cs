using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai5_Delivery_Order_Dashboard_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Đăng ký các sự kiện khởi tạo
            this.Load += Form1_Load;

            // Cấu hình Timer đếm thời gian
            timerSystem.Interval = 1000;
            timerSystem.Tick += timerSystem_Tick;

            // Đăng ký sự kiện thay đổi / xóa dữ liệu bảng chi tiết (dataGridView2)
            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
            dataGridView2.RowsRemoved += dataGridView2_RowsRemoved;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Khởi chạy đồng hồ thời gian thực
            timerSystem.Start();
            CapNhatThoiGian();

            // 2. Cấu hình tự dãn rộng các cột cho cả 2 DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cho phép người dùng thêm dòng trực tiếp
            dataGridView1.AllowUserToAddRows = true;
            dataGridView2.AllowUserToAddRows = true;

            // Khóa cột "Thành tiền" không cho người dùng tự gõ vào (để chương trình tự tính)
            ColThanhTien.ReadOnly = true;

            // 3. Khởi tạo thống kê ban đầu trên StatusStrip
            CapNhatStatusStrip();
        }

        // --- 1. XỬ LÝ PHÍM TẮT F2 VÀ DELETE CHO CẢ 2 BẢNG ---
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Tự động xác định bảng người dùng đang chọn
            DataGridView activeGrid = dataGridView2; // Mặc định là bảng Hàng hóa (phải)
            if (dataGridView1.ContainsFocus || dataGridView1.Focused)
            {
                activeGrid = dataGridView1; // Nếu đang trỏ chuột ở bảng Khách hàng (trái)
            }

            // Nhấn F2: Thêm dòng mới vào bảng đang chọn
            if (keyData == Keys.F2)
            {
                try
                {
                    activeGrid.EndEdit();
                    int newRowIdx = activeGrid.Rows.Add();

                    if (activeGrid.Columns.Count > 0)
                    {
                        activeGrid.CurrentCell = activeGrid.Rows[newRowIdx].Cells[0];
                        activeGrid.BeginEdit(true);
                    }
                }
                catch { }

                return true;
            }

            // Nhấn Delete: Xóa dòng đang chọn
            if (keyData == Keys.Delete && !activeGrid.IsCurrentCellInEditMode)
            {
                if (activeGrid.CurrentRow != null && !activeGrid.CurrentRow.IsNewRow)
                {
                    string tenBang = (activeGrid == dataGridView1) ? "Bảng Khách hàng" : "Bảng Hàng hóa";
                    DialogResult confirm = MessageBox.Show(
                        $"Bạn có chắc chắn muốn xóa dòng đang chọn trong {tenBang} không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        activeGrid.Rows.Remove(activeGrid.CurrentRow);
                    }
                }
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // --- 2. HIỂN THỊ ĐỒNG HỒ REALTIME (lblThoiGian) ---
        private void timerSystem_Tick(object sender, EventArgs e)
        {
            CapNhatThoiGian();
        }

        private void CapNhatThoiGian()
        {
            lblThoiGian.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // --- 3. TỰ ĐỘNG TÍNH THÀNH TIỀN VÀ BẬT BÁO LỖI (errCanhBao) ---
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView2.Rows.Count) return;

            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            // Khi người dùng thay đổi cột Số lượng, Trọng lượng hoặc Đơn giá
            if (e.ColumnIndex == ColSoLuong.Index || e.ColumnIndex == ColDonGia.Index || e.ColumnIndex == ColTrongLuong.Index)
            {
                decimal.TryParse(Convert.ToString(row.Cells[ColSoLuong.Index].Value), out decimal sl);
                decimal.TryParse(Convert.ToString(row.Cells[ColTrongLuong.Index].Value), out decimal tl);
                decimal.TryParse(Convert.ToString(row.Cells[ColDonGia.Index].Value), out decimal donGia);

                // === CÔNG THỨC TÍNH TIỀN ===
                // Mặc định: Thành tiền = Số lượng * Đơn giá
                decimal thanhTien = sl * donGia;

                // Gán kết quả vào cột Thành tiền (Định dạng có dấu phân cách hàng nghìn)
                row.Cells[ColThanhTien.Index].Value = thanhTien.ToString("N0");
            }

            // Kiểm tra cảnh báo ErrorProvider nếu Số lượng hoặc Trọng lượng <= 0
            KiemTraCanhBaoLoi(row, e.ColumnIndex);

            // Cập nhật lại các con số tổng trên StatusStrip
            CapNhatStatusStrip();
        }

        private void KiemTraCanhBaoLoi(DataGridViewRow row, int colIndex)
        {
            // Kiểm tra cột Số lượng
            if (colIndex == ColSoLuong.Index)
            {
                if (decimal.TryParse(Convert.ToString(row.Cells[ColSoLuong.Index].Value), out decimal sl) && sl <= 0)
                {
                    row.Cells[ColSoLuong.Index].ErrorText = "Số lượng phải > 0!";
                    errCanhBao.SetError(dataGridView2, "Phát hiện Số lượng hoặc Trọng lượng <= 0!");
                }
                else
                {
                    row.Cells[ColSoLuong.Index].ErrorText = "";
                }
            }
            // Kiểm tra cột Trọng lượng
            else if (colIndex == ColTrongLuong.Index)
            {
                if (decimal.TryParse(Convert.ToString(row.Cells[ColTrongLuong.Index].Value), out decimal tl) && tl <= 0)
                {
                    row.Cells[ColTrongLuong.Index].ErrorText = "Trọng lượng phải > 0!";
                    errCanhBao.SetError(dataGridView2, "Phát hiện Số lượng hoặc Trọng lượng <= 0!");
                }
                else
                {
                    row.Cells[ColTrongLuong.Index].ErrorText = "";
                }
            }

            // Tự động xóa biểu tượng báo lỗi nếu toàn bộ dữ liệu đã hợp lệ
            bool coLoi = false;
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                if (!string.IsNullOrEmpty(r.Cells[ColSoLuong.Index].ErrorText) ||
                    !string.IsNullOrEmpty(r.Cells[ColTrongLuong.Index].ErrorText))
                {
                    coLoi = true;
                    break;
                }
            }

            if (!coLoi)
            {
                errCanhBao.SetError(dataGridView2, "");
            }
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CapNhatStatusStrip();
        }

        // --- 4. TÍNH TỔNG SL, TỔNG TRỌNG LƯỢNG, TỔNG TIỀN TRÊN STATUSSTRIP ---
        private void CapNhatStatusStrip()
        {
            decimal tongSL = 0;
            decimal tongTL = 0;
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;

                decimal.TryParse(Convert.ToString(row.Cells[ColSoLuong.Index].Value), out decimal sl);
                decimal.TryParse(Convert.ToString(row.Cells[ColTrongLuong.Index].Value), out decimal tl);

                // Lấy giá trị cột Thành tiền (xóa bớt dấu phẩy phân cách)
                string strThanhTien = Convert.ToString(row.Cells[ColThanhTien.Index].Value)?.Replace(",", "").Replace(".", "");
                decimal.TryParse(strThanhTien, out decimal tt);

                tongSL += sl;
                tongTL += tl;
                tongTien += tt;
            }

            // Cập nhật nhãn trên thanh trạng thái
            lblTongSoLuong.Text = $"| Tổng SL: {tongSL:N0}";
            lblTongTrongLuong.Text = $"| Tổng trọng lượng: {tongTL:N2} kg";
            lblTongTien.Text = $"| Tổng tiền: {tongTien:N0} VNĐ";
        }

        // Các hàm rỗng giữ lại để tránh lỗi biên dịch Designer
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
    }
}