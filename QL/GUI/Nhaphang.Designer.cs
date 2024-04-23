namespace QL
{
    partial class Nhaphang
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
            txt_soluong = new TextBox();
            txt_giatien = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            imageList1 = new ImageList(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(477, 123);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(150, 31);
            txt_soluong.TabIndex = 0;
            // 
            // txt_giatien
            // 
            txt_giatien.Location = new Point(477, 160);
            txt_giatien.Name = "txt_giatien";
            txt_giatien.Size = new Size(150, 31);
            txt_giatien.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 123);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 1;
            label1.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 160);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 1;
            label2.Text = "Giá tiền:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(82, 243);
            button1.Name = "button1";
            button1.Size = new Size(150, 34);
            button1.TabIndex = 2;
            button1.Text = "Thêm sản phẩm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(12, 10);
            listView1.Name = "listView1";
            listView1.Size = new Size(329, 227);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ảnh";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã sản phẩm";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên sản phẩm";
            columnHeader3.Width = 125;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(60, 60);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(477, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(477, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 55);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 5;
            label3.Text = "Mã sản phẩm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 92);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 5;
            label4.Text = "Tên sản phẩm:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(642, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(764, 243);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "Nhập hàng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Nhaphang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1040, 336);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_giatien);
            Controls.Add(txt_soluong);
            Name = "Nhaphang";
            Text = "Form1";
            Load += Nhaphang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_soluong;
        private TextBox txt_giatien;
        private Label label1;
        private Label label2;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ImageList imageList1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button2;
    }
}
