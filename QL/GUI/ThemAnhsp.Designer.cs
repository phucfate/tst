namespace QL.Gui
{
    partial class ThemAnhsp
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
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            txt_tensp = new TextBox();
            txt_masp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(382, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 31);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(603, 73);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Chọn tệp";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(382, 192);
            button2.Name = "button2";
            button2.Size = new Size(90, 34);
            button2.TabIndex = 3;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txt_tensp
            // 
            txt_tensp.Location = new Point(382, 110);
            txt_tensp.Name = "txt_tensp";
            txt_tensp.Size = new Size(195, 31);
            txt_tensp.TabIndex = 4;
            // 
            // txt_masp
            // 
            txt_masp.Location = new Point(382, 150);
            txt_masp.Name = "txt_masp";
            txt_masp.Size = new Size(195, 31);
            txt_masp.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 79);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 7;
            label1.Text = "Đường dẫn ảnh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 113);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 7;
            label2.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 150);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 7;
            label3.Text = "Mã sản phẩm:";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Location = new Point(487, 192);
            button3.Name = "button3";
            button3.Size = new Size(90, 34);
            button3.TabIndex = 3;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(22, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 219);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ảnh";
            // 
            // ThemAnhsp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(752, 278);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_masp);
            Controls.Add(txt_tensp);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "ThemAnhsp";
            Text = "ThemAnhsp";
            Load += ThemAnhsp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private TextBox txt_tensp;
        private TextBox txt_masp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
        private GroupBox groupBox1;
    }
}