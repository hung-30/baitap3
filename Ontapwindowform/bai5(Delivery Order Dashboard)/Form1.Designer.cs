namespace bai5_Delivery_Order_Dashboard_
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            statusStrip1 = new StatusStrip();
            errCanhBao = new ErrorProvider(components);
            ColThongTinKH = new DataGridViewTextBoxColumn();
            ColLoaiVanChuyen = new DataGridViewTextBoxColumn();
            ColTenHang = new DataGridViewTextBoxColumn();
            ColSoLuong = new DataGridViewTextBoxColumn();
            ColTrongLuong = new DataGridViewTextBoxColumn();
            ColDonGia = new DataGridViewTextBoxColumn();
            ColThanhTien = new DataGridViewTextBoxColumn();
            lblThoiGian = new ToolStripStatusLabel();
            lblTongSoLuong = new ToolStripStatusLabel();
            lblTongTrongLuong = new ToolStripStatusLabel();
            lblTongTien = new ToolStripStatusLabel();
            timerSystem = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errCanhBao).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Size = new Size(990, 450);
            splitContainer1.SplitterDistance = 330;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColThongTinKH, ColLoaiVanChuyen });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(330, 450);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ColTenHang, ColSoLuong, ColTrongLuong, ColDonGia, ColThanhTien });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(656, 450);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThoiGian, lblTongSoLuong, lblTongTien, lblTongTrongLuong });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(990, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // errCanhBao
            // 
            errCanhBao.ContainerControl = this;
            // 
            // ColThongTinKH
            // 
            ColThongTinKH.HeaderText = "Thông tin khách hàng";
            ColThongTinKH.MinimumWidth = 6;
            ColThongTinKH.Name = "ColThongTinKH";
            ColThongTinKH.Width = 125;
            // 
            // ColLoaiVanChuyen
            // 
            ColLoaiVanChuyen.HeaderText = "Loại vận chuyển";
            ColLoaiVanChuyen.MinimumWidth = 6;
            ColLoaiVanChuyen.Name = "ColLoaiVanChuyen";
            ColLoaiVanChuyen.Width = 125;
            // 
            // ColTenHang
            // 
            ColTenHang.HeaderText = "Tên hàng";
            ColTenHang.MinimumWidth = 6;
            ColTenHang.Name = "ColTenHang";
            ColTenHang.Width = 125;
            // 
            // ColSoLuong
            // 
            ColSoLuong.HeaderText = "Số lượng";
            ColSoLuong.MinimumWidth = 6;
            ColSoLuong.Name = "ColSoLuong";
            ColSoLuong.Width = 125;
            // 
            // ColTrongLuong
            // 
            ColTrongLuong.HeaderText = "Trọng lượng";
            ColTrongLuong.MinimumWidth = 6;
            ColTrongLuong.Name = "ColTrongLuong";
            ColTrongLuong.Width = 125;
            // 
            // ColDonGia
            // 
            ColDonGia.HeaderText = "Đơn giá";
            ColDonGia.MinimumWidth = 6;
            ColDonGia.Name = "ColDonGia";
            ColDonGia.Width = 125;
            // 
            // ColThanhTien
            // 
            ColThanhTien.HeaderText = "Thành tiền";
            ColThanhTien.MinimumWidth = 6;
            ColThanhTien.Name = "ColThanhTien";
            ColThanhTien.Width = 125;
            // 
            // lblThoiGian
            // 
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(134, 20);
            lblThoiGian.Text = "Thời gian hệ thống";
            // 
            // lblTongSoLuong
            // 
            lblTongSoLuong.Name = "lblTongSoLuong";
            lblTongSoLuong.Size = new Size(142, 20);
            lblTongSoLuong.Text = "Tổng số lương hàng";
            // 
            // lblTongTrongLuong
            // 
            lblTongTrongLuong.Name = "lblTongTrongLuong";
            lblTongTrongLuong.Size = new Size(126, 20);
            lblTongTrongLuong.Text = "Tổng trọng lượng";
            // 
            // lblTongTien
            // 
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(139, 20);
            lblTongTien.Text = "Tổng tiền đơn hàng";
            // 
            // timerSystem
            // 
            timerSystem.Enabled = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 450);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "7";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errCanhBao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private StatusStrip statusStrip1;
        private DataGridViewTextBoxColumn ColThongTinKH;
        private DataGridViewTextBoxColumn ColLoaiVanChuyen;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ErrorProvider errCanhBao;
        private DataGridViewTextBoxColumn ColTenHang;
        private DataGridViewTextBoxColumn ColSoLuong;
        private DataGridViewTextBoxColumn ColTrongLuong;
        private DataGridViewTextBoxColumn ColDonGia;
        private DataGridViewTextBoxColumn ColThanhTien;
        private ToolStripStatusLabel lblThoiGian;
        private ToolStripStatusLabel lblTongSoLuong;
        private ToolStripStatusLabel lblTongTrongLuong;
        private ToolStripStatusLabel lblTongTien;
        private System.Windows.Forms.Timer timerSystem;
    }
}
