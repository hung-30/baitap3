using System;
using System.Windows.Forms;

namespace bai4._3
{
    public partial class Form1 : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
            RegisterEvents();
        }

        // Đăng ký sự kiện bằng code cho toàn bộ nút bấm
        private void RegisterEvents()
        {
            // 1. Gán chung 1 Handler cho 10 nút số (0-9)
            btn0.Click += NumberButton_Click;
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;
            btn7.Click += NumberButton_Click;
            btn8.Click += NumberButton_Click;
            btn9.Click += NumberButton_Click;

            // 2. Gán chung Handler cho các phép toán (+, -, *, /)
            btnAdd.Click += Operator_Click;
            btnSub.Click += Operator_Click;
            btnMul.Click += Operator_Click;
            btnDiv.Click += Operator_Click;

            // 3. Sự kiện nút '=' và 'C'
            btnEqual.Click += btnEqual_Click;
            btnClear.Click += btnClear_Click;
        }

        // =======================================================
        // EVENT HANDLER CHUNG CHO 10 NÚT SỐ (DÙNG OBJECT SENDER)
        // =======================================================
        private void NumberButton_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || isOperationPerformed)
            {
                txtDisplay.Clear();
            }

            isOperationPerformed = false;

            // Ép kiểu sender về Button để lấy Text ("0"..."9")
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        // Event Handler chung cho các dấu +, -, *, /
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (resultValue != 0 && !isOperationPerformed)
            {
                btnEqual.PerformClick();
            }

            operationPerformed = btn.Text;
            if (double.TryParse(txtDisplay.Text, out double val))
            {
                resultValue = val;
            }
            isOperationPerformed = true;
        }

        // Xử lý tính toán dấu =
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out double currentValue)) return;

            switch (operationPerformed)
            {
                case "+":
                    txtDisplay.Text = (resultValue + currentValue).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultValue - currentValue).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (resultValue * currentValue).ToString();
                    break;
                case "/":
                    txtDisplay.Text = currentValue != 0
                        ? (resultValue / currentValue).ToString()
                        : "Lỗi chia 0";
                    break;
            }
            resultValue = 0;
            operationPerformed = "";
        }

        // Xử lý nút C (Clear)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
            operationPerformed = "";
        }
    }
}