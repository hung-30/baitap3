using System;
using System.Windows.Forms;

namespace bai4._1
{
    public partial class Form1 : Form // ": Form" giúp sửa triệt để lỗi CS0103 SuspendLayout
    {
        public Form1()
        {
            InitializeComponent();

            // Cấu hình ban đầu
            textBox2.UseSystemPasswordChar = true; // Ẩn mật khẩu mặc định
            this.AcceptButton = button2;            // Phím Enter kích hoạt Login (button2)
            this.CancelButton = button1;            // Phím Esc kích hoạt Exit (button1)

            // Đăng ký sự kiện bằng code
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            button2.Click += Button2_Click;
            button1.Click += Button1_Click;
        }

        // Ẩn / Hiện mật khẩu
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        // Nút Login (button2)
        private void Button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Tên đăng nhập không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Mật khẩu không được để trống!");
                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Nút Exit (button1)
        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Để trống hàm này vì trong Designer của bạn có gán sự kiện Click cho label1
        }
    }
}