namespace bai3_Item_List_Manager_
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
            groupBox1 = new GroupBox();
            cboDonViTinh = new ComboBox();
            txtMaVT = new TextBox();
            txtDonGia = new TextBox();
            txtTenVT = new TextBox();
            lblTenVT = new Label();
            lblDonViTinh = new Label();
            lblDonGia = new Label();
            lblMaVT = new Label();
            groupBox2 = new GroupBox();
            btnXoaToanBo = new Button();
            lvwVatTu = new ListView();
            colMaVT = new ColumnHeader();
            colTenVT = new ColumnHeader();
            colDonViTinh = new ColumnHeader();
            colDonGia = new ColumnHeader();
            btnXoaDong = new Button();
            btnThemMoi = new Button();
            btnCapNhat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboDonViTinh);
            groupBox1.Controls.Add(txtMaVT);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtTenVT);
            groupBox1.Controls.Add(lblTenVT);
            groupBox1.Controls.Add(lblDonViTinh);
            groupBox1.Controls.Add(lblDonGia);
            groupBox1.Controls.Add(lblMaVT);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cboDonViTinh
            // 
            cboDonViTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonViTinh.FormattingEnabled = true;
            cboDonViTinh.Location = new Point(172, 221);
            cboDonViTinh.Name = "cboDonViTinh";
            cboDonViTinh.Size = new Size(164, 28);
            cboDonViTinh.TabIndex = 2;
            // 
            // txtMaVT
            // 
            txtMaVT.Location = new Point(211, 41);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(125, 27);
            txtMaVT.TabIndex = 1;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(211, 133);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 1;
            txtDonGia.TextChanged += textBox2_TextChanged;
            // 
            // txtTenVT
            // 
            txtTenVT.Location = new Point(211, 84);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(125, 27);
            txtTenVT.TabIndex = 1;
            txtTenVT.TextChanged += textBox1_TextChanged;
            // 
            // lblTenVT
            // 
            lblTenVT.AutoSize = true;
            lblTenVT.Location = new Point(61, 87);
            lblTenVT.Name = "lblTenVT";
            lblTenVT.Size = new Size(53, 20);
            lblTenVT.TabIndex = 0;
            lblTenVT.Text = "Tên VT";
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Location = new Point(61, 221);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new Size(81, 20);
            lblDonViTinh.TabIndex = 0;
            lblDonViTinh.Text = "Đơn vị tính";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(61, 136);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(62, 20);
            lblDonGia.TabIndex = 0;
            lblDonGia.Text = "Đơn giá";
            // 
            // lblMaVT
            // 
            lblMaVT.AutoSize = true;
            lblMaVT.Location = new Point(61, 44);
            lblMaVT.Name = "lblMaVT";
            lblMaVT.Size = new Size(51, 20);
            lblMaVT.TabIndex = 0;
            lblMaVT.Text = "Mã VT";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoaToanBo);
            groupBox2.Controls.Add(lvwVatTu);
            groupBox2.Controls.Add(btnXoaDong);
            groupBox2.Controls.Add(btnThemMoi);
            groupBox2.Controls.Add(btnCapNhat);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(380, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 450);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnXoaToanBo
            // 
            btnXoaToanBo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaToanBo.Location = new Point(244, 409);
            btnXoaToanBo.Name = "btnXoaToanBo";
            btnXoaToanBo.Size = new Size(116, 29);
            btnXoaToanBo.TabIndex = 3;
            btnXoaToanBo.Text = "Xóa toàn bộ";
            btnXoaToanBo.UseVisualStyleBackColor = true;
            // 
            // lvwVatTu
            // 
            lvwVatTu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwVatTu.Columns.AddRange(new ColumnHeader[] { colMaVT, colTenVT, colDonViTinh, colDonGia });
            lvwVatTu.FullRowSelect = true;
            lvwVatTu.GridLines = true;
            lvwVatTu.Location = new Point(6, 26);
            lvwVatTu.Name = "lvwVatTu";
            lvwVatTu.Size = new Size(408, 313);
            lvwVatTu.TabIndex = 0;
            lvwVatTu.UseCompatibleStateImageBehavior = false;
            lvwVatTu.View = View.Details;
            // 
            // colMaVT
            // 
            colMaVT.Text = "Mã VT";
            // 
            // colTenVT
            // 
            colTenVT.Text = "Tên VT";
            // 
            // colDonViTinh
            // 
            colDonViTinh.Text = "Đơn vị tính";
            // 
            // colDonGia
            // 
            colDonGia.Text = "Đơn giá";
            // 
            // btnXoaDong
            // 
            btnXoaDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaDong.Location = new Point(59, 409);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(94, 29);
            btnXoaDong.TabIndex = 3;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThemMoi.Location = new Point(59, 366);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(94, 29);
            btnThemMoi.TabIndex = 3;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCapNhat.Location = new Point(244, 366);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtMaVT;
        private TextBox txtDonGia;
        private TextBox txtTenVT;
        private Label lblTenVT;
        private Label lblDonGia;
        private Label lblMaVT;
        private Button btnXoaToanBo;
        private Button btnThemMoi;
        private Button btnXoaDong;
        private Button btnCapNhat;
        private ComboBox cboDonViTinh;
        private TextBox textBox4;
        private ListView lvwVatTu;
        private ColumnHeader colMaVT;
        private ColumnHeader colTenVT;
        private ColumnHeader colDonViTinh;
        private ColumnHeader colDonGia;
        private Label lblDonViTinh;
    }
}
