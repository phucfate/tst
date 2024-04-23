using QL.Bus;
using QL.Gui;
using QL.Models;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace QL
{
    public partial class Nhaphang : Form
    {
        private readonly BUSNhapHang _nhapHangBUS;
        public Nhaphang()
        {
            InitializeComponent();
            _nhapHangBUS = new BUSNhapHang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var themsanpham = Application.OpenForms.OfType<ThemAnhsp>().FirstOrDefault();
            if (themsanpham == null)
            {
                themsanpham = new ThemAnhsp();
            }
            themsanpham.Show();
            this.Hide();
        }

        private void Nhaphang_Load(object sender, EventArgs e)
        {
            var hanghoa = _nhapHangBUS.GetHangHoa() ;

            foreach (var i in hanghoa)
            {
                Image anh = Image.FromStream(new MemoryStream(i.Anhsp));
                imageList1.Images.Add(anh);
                var item = new ListViewItem();
                item.ImageIndex = imageList1.Images.Count - 1;
                item.SubItems.Add(i.Masp);
                item.SubItems.Add(i.Tensp);
                listView1.Items.Add(item);
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedListViewItem = listView1.SelectedItems[0];
                string maSP = selectedListViewItem.SubItems[1].Text;
                string tenSP = selectedListViewItem.SubItems[2].Text;
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("MaSP", "Mã sản phẩm");
                dataGridView1.Columns.Add("TenSP", "Tên sản phẩm");
                dataGridView1.Rows.Add(maSP, tenSP);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
