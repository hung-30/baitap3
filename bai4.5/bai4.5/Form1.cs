using System;
using System.Data;
using System.Windows.Forms;

namespace bai4._5
{
    public partial class Form1 : Form
    {
        private DataTable dtKhachHang = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtKhachHang.Columns.Add("MaKH", typeof(string));
            dtKhachHang.Columns.Add("TenKH", typeof(string));
            dtKhachHang.Columns.Add("SDT", typeof(string));
            dtKhachHang.Columns.Add("DiaChi", typeof(string));

            dtKhachHang.Rows.Add("KH01", "Nguyễn Văn A", "0901234567", "Hà Nội");
            dtKhachHang.Rows.Add("KH02", "Trần Thị B", "0987654321", "TP. Hồ Chí Minh");

            dataGridView1.DataSource = dtKhachHang;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtKhachHang.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            ClearInputs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                row.Cells["MaKH"].Value = textBox1.Text;
                row.Cells["TenKH"].Value = textBox2.Text;
                row.Cells["SDT"].Value = textBox3.Text;
                row.Cells["DiaChi"].Value = textBox4.Text;
                ClearInputs();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                ClearInputs();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["MaKH"].Value?.ToString();
                textBox2.Text = row.Cells["TenKH"].Value?.ToString();
                textBox3.Text = row.Cells["SDT"].Value?.ToString();
                textBox4.Text = row.Cells["DiaChi"].Value?.ToString();
            }
        }

        private void ClearInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
    }
}