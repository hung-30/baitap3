namespace bai1_Service_Charge_Calculator_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDonGia = new TextBox();
            lblDonGia = new Label();
            btnTinhTien = new Button();
            lblSoLuong = new Label();
            btnLamMoi = new Button();
            lblMaGiamGia = new Label();
            lblTongTien = new Label();
            txtSoLuong = new TextBox();
            txtMaGiamGia = new TextBox();
            txtTongTien = new TextBox();
            SuspendLayout();
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(268, 30);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(235, 27);
            txtDonGia.TabIndex = 0;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(74, 37);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(113, 20);
            lblDonGia.TabIndex = 1;
            lblDonGia.Text = "Đơn giá dich vụ";
            lblDonGia.Click += label1_Click;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(430, 244);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(118, 42);
            btnTinhTien.TabIndex = 2;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(74, 69);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(111, 20);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "Số lượng khách";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(218, 246);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(119, 38);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // lblMaGiamGia
            // 
            lblMaGiamGia.AutoSize = true;
            lblMaGiamGia.Location = new Point(74, 109);
            lblMaGiamGia.Name = "lblMaGiamGia";
            lblMaGiamGia.Size = new Size(93, 20);
            lblMaGiamGia.TabIndex = 1;
            lblMaGiamGia.Text = "Mã giảm giá";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(74, 154);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(147, 20);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng tiền thanh toán";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(267, 69);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(235, 27);
            txtSoLuong.TabIndex = 0;
            txtSoLuong.TextChanged += textBox2_TextChanged;
            // 
            // txtMaGiamGia
            // 
            txtMaGiamGia.Location = new Point(268, 109);
            txtMaGiamGia.Name = "txtMaGiamGia";
            txtMaGiamGia.Size = new Size(235, 27);
            txtMaGiamGia.TabIndex = 0;
            txtMaGiamGia.TextChanged += textBox2_TextChanged;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(268, 154);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(235, 27);
            txtTongTien.TabIndex = 0;
            txtTongTien.Text = "0";
            txtTongTien.TextAlign = HorizontalAlignment.Center;
            txtTongTien.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLamMoi);
            Controls.Add(lblTongTien);
            Controls.Add(lblMaGiamGia);
            Controls.Add(lblSoLuong);
            Controls.Add(btnTinhTien);
            Controls.Add(txtTongTien);
            Controls.Add(txtMaGiamGia);
            Controls.Add(txtSoLuong);
            Controls.Add(lblDonGia);
            Controls.Add(txtDonGia);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDonGia;
        private Label lblDonGia;
        private Button btnTinhTien;
        private Label lblSoLuong;
        private Button btnLamMoi;
        private Label lblMaGiamGia;
        private Label lblTongTien;
        private TextBox txtSoLuong;
        private TextBox txtMaGiamGia;
        private TextBox txtTongTien;
    }
}
