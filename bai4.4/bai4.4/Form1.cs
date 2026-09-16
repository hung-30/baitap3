using System;
using System.Windows.Forms;

namespace bai4._4
{
    public partial class Form1 : Form
    {
        // Class đối tượng để quản lý thông tin món ăn và giá
        public class FoodItem
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public FoodItem(string name, int price)
            {
                Name = name;
                Price = price;
            }

            // Ghi đè ToString để ListBox hiển thị đúng tên và giá
            public override string ToString()
            {
                return $"{Name} - {Price:N0} VNĐ";
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Đăng ký sự kiện Click cho nút button1 (>) và button2 (<)
            button1.Click += btnAdd_Click;
            button2.Click += btnRemove_Click;

            InitMenuData();
        }

        // 1. Thêm danh sách món ăn ban đầu vào lstMenu
        private void InitMenuData()
        {
            lstMenu.Items.Add(new FoodItem("Hamburger", 50000));
            lstMenu.Items.Add(new FoodItem("Pizza", 120000));
            lstMenu.Items.Add(new FoodItem("Gà Rán", 35000));
            lstMenu.Items.Add(new FoodItem("Pepsi", 15000));

            UpdateTotal();
        }

        // 2. Nút '>' (button1): Chuyển món từ lstMenu sang lstSelected
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem is FoodItem selectedFood)
            {
                lstSelected.Items.Add(selectedFood);
                UpdateTotal();
            }
        }

        // 3. Nút '<' (button2): Xóa món đang chọn khỏi lstSelected
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                lstSelected.Items.Remove(lstSelected.SelectedItem);
                UpdateTotal();
            }
        }

        // 4. Cập nhật tổng tiền dựa trên các món có trong lstSelected
        private void UpdateTotal()
        {
            int total = 0;

            foreach (FoodItem item in lstSelected.Items)
            {
                total += item.Price;
            }

            lblTotal.Text = $"Tổng tiền: {total:N0} VNĐ";
        }
    }
}