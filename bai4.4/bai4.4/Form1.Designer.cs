namespace bai4._4
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
            lstMenu = new ListBox();
            button1 = new Button();
            button2 = new Button();
            lblTotal = new Label();
            lstSelected = new ListBox();
            SuspendLayout();
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.Location = new Point(208, 36);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(150, 104);
            lstMenu.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(484, 186);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(232, 186);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(354, 287);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(71, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Tong tien";
            // 
            // lstSelected
            // 
            lstSelected.FormattingEnabled = true;
            lstSelected.Location = new Point(444, 36);
            lstSelected.Name = "lstSelected";
            lstSelected.Size = new Size(150, 104);
            lstSelected.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstSelected);
            Controls.Add(lblTotal);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstMenu);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMenu;
        private Button button1;
        private Button button2;
        private Label lblTotal;
        private ListBox lstSelected;
    }
}
