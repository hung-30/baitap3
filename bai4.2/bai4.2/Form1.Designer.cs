namespace bai4._2
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
            cboCourse = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            dtpBirthDate = new DateTimePicker();
            mtxtPhone = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(167, 111);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(151, 28);
            cboCourse.TabIndex = 0;
            cboCourse.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(167, 163);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(95, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tieng anh";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(167, 216);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tin hoc";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(438, 164);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Nam";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(434, 222);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(50, 24);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Nu";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(167, 67);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 5;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(167, 23);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(125, 27);
            mtxtPhone.TabIndex = 6;
            mtxtPhone.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // button1
            // 
            button1.Location = new Point(290, 297);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Dang ki";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(mtxtPhone);
            Controls.Add(dtpBirthDate);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(cboCourse);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCourse;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private DateTimePicker dtpBirthDate;
        private MaskedTextBox mtxtPhone;
        private Button button1;
    }
}
