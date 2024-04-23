using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QL.Models;
using System.IO;
using System.Net.WebSockets;

namespace QL.Gui
{
    public partial class ThemAnhsp : Form
    {
        public ThemAnhsp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG files (*.jpg) |*.jpg|ALL files(*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                textBox1.Text = openFileDialog.FileName;

            }
            var Anhsp = File.ReadAllBytes(textBox1.Text);
            var context = new QlBanthucungContext();

            using (MemoryStream stream = new MemoryStream(Anhsp))
            {
                // Tạo hình ảnh từ MemoryStream và hiển thị nó trong PictureBox
                pictureBox1.Image = Image.FromStream(stream);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var newData = new Hanghoa
                {
                    Anhsp = File.ReadAllBytes(textBox1.Text),
                    Masp = txt_masp.Text,
                    Tensp = txt_tensp.Text
                };
                using (var context = new QlBanthucungContext())
                {
                    context.Hanghoas.Add(newData);
                    context.SaveChanges();
                    MessageBox.Show("Thêm sản phẩm thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void ThemAnhsp_Load(object sender, EventArgs e)
        {
       

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var nhaphang = Application.OpenForms.OfType<Nhaphang>().FirstOrDefault();
            if (nhaphang == null)
            {
                nhaphang = new Nhaphang();
            }
            nhaphang.Show();
            this.Hide();
        }
    }
}
