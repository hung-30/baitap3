using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai4._2
{
    // Class Form1 BẮT BUỘC phải nằm đầu tiên trong file
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataCourse();

            // Đăng ký sự kiện Click cho nút Dang ki
            button1.Click += button1_Click;
        }

        // Hàm Nạp danh sách vào ComboBox
        private void LoadDataCourse()
        {
            List<CourseItem> listCourse = new List<CourseItem>
            {
                new CourseItem { ID = "C01", Name = "Lập trình C# WinForms" },
                new CourseItem { ID = "C02", Name = "Lập trình Web ASP.NET" },
                new CourseItem { ID = "C03", Name = "Phân tích dữ liệu Python" }
            };

            cboCourse.DataSource = listCourse;
            cboCourse.DisplayMember = "Name";
            cboCourse.ValueMember = "ID";
        }

        // Xử lý khi nhấn nút Dang ki
        private void button1_Click(object sender, EventArgs e)
        {
            if (!mtxtPhone.MaskCompleted)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtPhone.Focus();
                return;
            }

            string monHoc = "Chưa chọn";
            if (radioButton1.Checked) monHoc = "Tiếng Anh";
            else if (radioButton2.Checked) monHoc = "Tin học";

            List<string> gioiTinh = new List<string>();
            if (checkBox1.Checked) gioiTinh.Add("Nam");
            if (checkBox2.Checked) gioiTinh.Add("Nữ");
            string strGioiTinh = gioiTinh.Count > 0 ? string.Join(", ", gioiTinh) : "Chưa chọn";

            string courseName = cboCourse.Text;
            string courseID = cboCourse.SelectedValue?.ToString();

            string info = $"--- THÔNG TIN ĐĂNG KÝ ---\n" +
                          $"Số điện thoại: {mtxtPhone.Text}\n" +
                          $"Ngày sinh: {dtpBirthDate.Value:dd/MM/yyyy}\n" +
                          $"Khóa học: {courseName} (Mã: {courseID})\n" +
                          $"Môn học: {monHoc}\n" +
                          $"Giới tính: {strGioiTinh}";

            MessageBox.Show(info, "Thông báo đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Để trống
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

    // Chuyển class phụ này xuống phía DƯỚI class Form1
    public class CourseItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}