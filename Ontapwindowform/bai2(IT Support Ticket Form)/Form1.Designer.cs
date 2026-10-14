namespace bai2_IT_Support_Ticket_Form_
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
            radTrungBinh = new RadioButton();
            dtpNgayGhiNhan = new DateTimePicker();
            lblMaPhieu = new Label();
            txtMaPhieu = new TextBox();
            cboLoaiSuCo = new ComboBox();
            chkMayTinhBan = new CheckBox();
            picAnhLoi = new PictureBox();
            btnTaiAnh = new Button();
            btnGuiYeuCau = new Button();
            btnNhapLai = new Button();
            lblNguoiYeuCau = new Label();
            txtNguoiYeuCau = new TextBox();
            radThap = new RadioButton();
            radKhanCap = new RadioButton();
            lblNgayGhiNhan = new Label();
            lblMucDoUuTien = new Label();
            lblLoaiSuCo = new Label();
            lblThietBiAnhHuong = new Label();
            chkLaptop = new CheckBox();
            chkMayIn = new CheckBox();
            chkDienThoai = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            SuspendLayout();
            // 
            // radTrungBinh
            // 
            radTrungBinh.AutoSize = true;
            radTrungBinh.Location = new Point(219, 217);
            radTrungBinh.Name = "radTrungBinh";
            radTrungBinh.Size = new Size(100, 24);
            radTrungBinh.TabIndex = 0;
            radTrungBinh.Text = "Trung bình";
            radTrungBinh.UseVisualStyleBackColor = true;
            // 
            // dtpNgayGhiNhan
            // 
            dtpNgayGhiNhan.Format = DateTimePickerFormat.Short;
            dtpNgayGhiNhan.Location = new Point(219, 117);
            dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            dtpNgayGhiNhan.Size = new Size(130, 27);
            dtpNgayGhiNhan.TabIndex = 1;
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Location = new Point(81, 25);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(70, 20);
            lblMaPhieu.TabIndex = 2;
            lblMaPhieu.Text = "Mã Phiếu";
            lblMaPhieu.Click += label1_Click;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(220, 22);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(129, 27);
            txtMaPhieu.TabIndex = 3;
            // 
            // cboLoaiSuCo
            // 
            cboLoaiSuCo.FormattingEnabled = true;
            cboLoaiSuCo.Location = new Point(581, 152);
            cboLoaiSuCo.Name = "cboLoaiSuCo";
            cboLoaiSuCo.Size = new Size(151, 28);
            cboLoaiSuCo.TabIndex = 4;
            // 
            // chkMayTinhBan
            // 
            chkMayTinhBan.AutoSize = true;
            chkMayTinhBan.Location = new Point(581, 29);
            chkMayTinhBan.Name = "chkMayTinhBan";
            chkMayTinhBan.Size = new Size(117, 24);
            chkMayTinhBan.TabIndex = 5;
            chkMayTinhBan.Text = "Máy tính bàn";
            chkMayTinhBan.UseVisualStyleBackColor = true;
            chkMayTinhBan.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // picAnhLoi
            // 
            picAnhLoi.Location = new Point(466, 217);
            picAnhLoi.Name = "picAnhLoi";
            picAnhLoi.Size = new Size(280, 107);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.TabIndex = 6;
            picAnhLoi.TabStop = false;
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(344, 374);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(106, 35);
            btnTaiAnh.TabIndex = 7;
            btnTaiAnh.Text = "Tải ảnh lỗi";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += button1_Click;
            // 
            // btnGuiYeuCau
            // 
            btnGuiYeuCau.Location = new Point(532, 374);
            btnGuiYeuCau.Name = "btnGuiYeuCau";
            btnGuiYeuCau.Size = new Size(106, 35);
            btnGuiYeuCau.TabIndex = 7;
            btnGuiYeuCau.Text = "Gửi yêu cầu";
            btnGuiYeuCau.UseVisualStyleBackColor = true;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(147, 374);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(106, 35);
            btnNhapLai.TabIndex = 7;
            btnNhapLai.Text = "Nhập  lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // lblNguoiYeuCau
            // 
            lblNguoiYeuCau.AutoSize = true;
            lblNguoiYeuCau.Location = new Point(81, 73);
            lblNguoiYeuCau.Name = "lblNguoiYeuCau";
            lblNguoiYeuCau.Size = new Size(107, 20);
            lblNguoiYeuCau.TabIndex = 2;
            lblNguoiYeuCau.Text = "Người Yêu Cầu";
            lblNguoiYeuCau.Click += label1_Click;
            // 
            // txtNguoiYeuCau
            // 
            txtNguoiYeuCau.Location = new Point(220, 73);
            txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            txtNguoiYeuCau.Size = new Size(129, 27);
            txtNguoiYeuCau.TabIndex = 3;
            // 
            // radThap
            // 
            radThap.AutoSize = true;
            radThap.Checked = true;
            radThap.Location = new Point(219, 179);
            radThap.Name = "radThap";
            radThap.Size = new Size(63, 24);
            radThap.TabIndex = 0;
            radThap.TabStop = true;
            radThap.Text = "Thấp";
            radThap.UseVisualStyleBackColor = true;
            // 
            // radKhanCap
            // 
            radKhanCap.AutoSize = true;
            radKhanCap.Location = new Point(219, 247);
            radKhanCap.Name = "radKhanCap";
            radKhanCap.Size = new Size(91, 24);
            radKhanCap.TabIndex = 0;
            radKhanCap.Text = "Khẩn cấp";
            radKhanCap.UseVisualStyleBackColor = true;
            // 
            // lblNgayGhiNhan
            // 
            lblNgayGhiNhan.AutoSize = true;
            lblNgayGhiNhan.Location = new Point(81, 124);
            lblNgayGhiNhan.Name = "lblNgayGhiNhan";
            lblNgayGhiNhan.Size = new Size(105, 20);
            lblNgayGhiNhan.TabIndex = 2;
            lblNgayGhiNhan.Text = "Ngày ghi nhận";
            lblNgayGhiNhan.Click += label1_Click;
            // 
            // lblMucDoUuTien
            // 
            lblMucDoUuTien.AutoSize = true;
            lblMucDoUuTien.Location = new Point(81, 181);
            lblMucDoUuTien.Name = "lblMucDoUuTien";
            lblMucDoUuTien.Size = new Size(110, 20);
            lblMucDoUuTien.TabIndex = 2;
            lblMucDoUuTien.Text = "Mức độ ưu tiên";
            lblMucDoUuTien.Click += label1_Click;
            // 
            // lblLoaiSuCo
            // 
            lblLoaiSuCo.AutoSize = true;
            lblLoaiSuCo.Location = new Point(402, 152);
            lblLoaiSuCo.Name = "lblLoaiSuCo";
            lblLoaiSuCo.Size = new Size(76, 20);
            lblLoaiSuCo.TabIndex = 2;
            lblLoaiSuCo.Text = "Loại sự cố";
            lblLoaiSuCo.Click += label1_Click;
            // 
            // lblThietBiAnhHuong
            // 
            lblThietBiAnhHuong.AutoSize = true;
            lblThietBiAnhHuong.Location = new Point(402, 29);
            lblThietBiAnhHuong.Name = "lblThietBiAnhHuong";
            lblThietBiAnhHuong.Size = new Size(134, 20);
            lblThietBiAnhHuong.TabIndex = 2;
            lblThietBiAnhHuong.Text = "Thiết bị ảnh hưởng";
            lblThietBiAnhHuong.Click += label1_Click;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(581, 59);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 5;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            chkLaptop.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkMayIn
            // 
            chkMayIn.AutoSize = true;
            chkMayIn.Location = new Point(581, 89);
            chkMayIn.Name = "chkMayIn";
            chkMayIn.Size = new Size(75, 24);
            chkMayIn.TabIndex = 5;
            chkMayIn.Text = "Máy in";
            chkMayIn.UseVisualStyleBackColor = true;
            chkMayIn.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkDienThoai
            // 
            chkDienThoai.AutoSize = true;
            chkDienThoai.Location = new Point(581, 117);
            chkDienThoai.Name = "chkDienThoai";
            chkDienThoai.Size = new Size(100, 24);
            chkDienThoai.TabIndex = 5;
            chkDienThoai.Text = "Điện thoại";
            chkDienThoai.UseVisualStyleBackColor = true;
            chkDienThoai.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNhapLai);
            Controls.Add(btnGuiYeuCau);
            Controls.Add(btnTaiAnh);
            Controls.Add(picAnhLoi);
            Controls.Add(chkDienThoai);
            Controls.Add(chkMayIn);
            Controls.Add(chkLaptop);
            Controls.Add(chkMayTinhBan);
            Controls.Add(cboLoaiSuCo);
            Controls.Add(txtNguoiYeuCau);
            Controls.Add(txtMaPhieu);
            Controls.Add(lblThietBiAnhHuong);
            Controls.Add(lblLoaiSuCo);
            Controls.Add(lblMucDoUuTien);
            Controls.Add(lblNgayGhiNhan);
            Controls.Add(lblNguoiYeuCau);
            Controls.Add(lblMaPhieu);
            Controls.Add(dtpNgayGhiNhan);
            Controls.Add(radKhanCap);
            Controls.Add(radThap);
            Controls.Add(radTrungBinh);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radTrungBinh;
        private DateTimePicker dtpNgayGhiNhan;
        private Label lblMaPhieu;
        private TextBox txtMaPhieu;
        private ComboBox cboLoaiSuCo;
        private CheckBox chkMayTinhBan;
        private PictureBox picAnhLoi;
        private Button btnTaiAnh;
        private Button btnGuiYeuCau;
        private Button btnNhapLai;
        private Label lblNguoiYeuCau;
        private TextBox txtNguoiYeuCau;
        private RadioButton radThap;
        private RadioButton radKhanCap;
        private Label lblNgayGhiNhan;
        private Label lblMucDoUuTien;
        private Label lblLoaiSuCo;
        private Label lblThietBiAnhHuong;
        private CheckBox chkLaptop;
        private CheckBox chkMayIn;
        private CheckBox chkDienThoai;
    }
}
