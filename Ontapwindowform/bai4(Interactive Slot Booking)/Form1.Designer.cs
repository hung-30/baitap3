namespace bai4_Interactive_Slot_Booking_
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
            tblSoDo = new TableLayoutPanel();
            lblSoViTriChon = new Label();
            cboKhungGio = new ComboBox();
            btnHuyChon = new Button();
            btnXacNhanDat = new Button();
            lblTamTinhTien = new Label();
            lblKhungGio = new Label();
            SuspendLayout();
            // 
            // tblSoDo
            // 
            tblSoDo.ColumnCount = 5;
            tblSoDo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.53271F));
            tblSoDo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.46729F));
            tblSoDo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            tblSoDo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            tblSoDo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tblSoDo.Location = new Point(12, 12);
            tblSoDo.Name = "tblSoDo";
            tblSoDo.RowCount = 4;
            tblSoDo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSoDo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSoDo.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tblSoDo.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tblSoDo.Size = new Size(501, 280);
            tblSoDo.TabIndex = 0;
            // 
            // lblSoViTriChon
            // 
            lblSoViTriChon.AutoSize = true;
            lblSoViTriChon.Location = new Point(579, 33);
            lblSoViTriChon.Name = "lblSoViTriChon";
            lblSoViTriChon.Size = new Size(148, 20);
            lblSoViTriChon.TabIndex = 1;
            lblSoViTriChon.Text = "Số vị trí đang chọn: 0";
            lblSoViTriChon.Click += label1_Click;
            // 
            // cboKhungGio
            // 
            cboKhungGio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhungGio.FormattingEnabled = true;
            cboKhungGio.Location = new Point(627, 146);
            cboKhungGio.Name = "cboKhungGio";
            cboKhungGio.Size = new Size(151, 28);
            cboKhungGio.TabIndex = 2;
            // 
            // btnHuyChon
            // 
            btnHuyChon.Location = new Point(258, 348);
            btnHuyChon.Name = "btnHuyChon";
            btnHuyChon.Size = new Size(94, 29);
            btnHuyChon.TabIndex = 3;
            btnHuyChon.Text = "Hủy chọn tất cả";
            btnHuyChon.UseVisualStyleBackColor = true;
            // 
            // btnXacNhanDat
            // 
            btnXacNhanDat.Location = new Point(442, 348);
            btnXacNhanDat.Name = "btnXacNhanDat";
            btnXacNhanDat.Size = new Size(94, 29);
            btnXacNhanDat.TabIndex = 3;
            btnXacNhanDat.Text = "Xác nhận đặt";
            btnXacNhanDat.UseVisualStyleBackColor = true;
            // 
            // lblTamTinhTien
            // 
            lblTamTinhTien.AutoSize = true;
            lblTamTinhTien.Location = new Point(581, 87);
            lblTamTinhTien.Name = "lblTamTinhTien";
            lblTamTinhTien.Size = new Size(146, 20);
            lblTamTinhTien.TabIndex = 1;
            lblTamTinhTien.Text = "Tạm tính tiền: 0 VNĐ";
            lblTamTinhTien.Click += label1_Click;
            // 
            // lblKhungGio
            // 
            lblKhungGio.AutoSize = true;
            lblKhungGio.Location = new Point(528, 149);
            lblKhungGio.Name = "lblKhungGio";
            lblKhungGio.Size = new Size(77, 20);
            lblKhungGio.TabIndex = 1;
            lblKhungGio.Text = "Khung giờ";
            lblKhungGio.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXacNhanDat);
            Controls.Add(btnHuyChon);
            Controls.Add(cboKhungGio);
            Controls.Add(lblTamTinhTien);
            Controls.Add(lblKhungGio);
            Controls.Add(lblSoViTriChon);
            Controls.Add(tblSoDo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblSoDo;
        private Label lblSoViTriChon;
        private ComboBox cboKhungGio;
        private Button btnHuyChon;
        private Button btnXacNhanDat;
        private Label lblTamTinhTien;
        private Label lblKhungGio;
    }
}
