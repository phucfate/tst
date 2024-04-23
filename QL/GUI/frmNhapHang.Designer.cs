namespace GUI
{
    partial class frmNhapHang
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            imageList1 = new ImageList(components);
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_giatien = new TextBox();
            txt_soluong = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(642, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 94);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 16;
            label4.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 57);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 17;
            label3.Text = "Mã sản phẩm:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(477, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(477, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 15;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(329, 227);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(82, 245);
            button1.Name = "button1";
            button1.Size = new Size(150, 34);
            button1.TabIndex = 12;
            button1.Text = "Thêm sản phẩm";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 162);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 10;
            label2.Text = "Giá tiền:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 125);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 11;
            label1.Text = "Số lượng:";
            // 
            // txt_giatien
            // 
            txt_giatien.Location = new Point(477, 162);
            txt_giatien.Name = "txt_giatien";
            txt_giatien.Size = new Size(150, 31);
            txt_giatien.TabIndex = 8;
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(477, 125);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(150, 31);
            txt_soluong.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(764, 245);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 19;
            button2.Text = "Nhập hàng";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmNhapHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 305);
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
            Controls.Add(button2);
            Name = "frmNhapHang";
            Text = "frmNhapHang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ImageList imageList1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox txt_giatien;
        private TextBox txt_soluong;
        private Button button2;
    }
}