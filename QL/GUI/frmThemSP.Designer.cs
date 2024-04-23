namespace GUI
{
    partial class frmThemSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_masp = new TextBox();
            txt_tensp = new TextBox();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(635, 164);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Chọn tệp";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(414, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 31);
            textBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(54, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 219);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ảnh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 241);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 15;
            label3.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 204);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 16;
            label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 170);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 17;
            label1.Text = "Đường dẫn ảnh:";
            // 
            // txt_masp
            // 
            txt_masp.Location = new Point(414, 241);
            txt_masp.Name = "txt_masp";
            txt_masp.Size = new Size(195, 31);
            txt_masp.TabIndex = 14;
            // 
            // txt_tensp
            // 
            txt_tensp.Location = new Point(414, 201);
            txt_tensp.Name = "txt_tensp";
            txt_tensp.Size = new Size(195, 31);
            txt_tensp.TabIndex = 13;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Location = new Point(519, 283);
            button3.Name = "button3";
            button3.Size = new Size(90, 34);
            button3.TabIndex = 11;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(414, 283);
            button2.Name = "button2";
            button2.Size = new Size(90, 34);
            button2.TabIndex = 12;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmThemSP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_masp);
            Controls.Add(txt_tensp);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "frmThemSP";
            Text = "frmThemSP";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_masp;
        private TextBox txt_tensp;
        private Button button3;
        private Button button2;
    }
}