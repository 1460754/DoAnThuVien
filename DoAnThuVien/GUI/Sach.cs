using DoAnThuVien.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThuVien.GUI
{
   public partial class Sach : Form
   {
      QLThuVienEntities tv = new QLThuVienEntities();
      SachBus sachBUS = new SachBus();
      public Sach()
      {
         InitializeComponent();
         cmbTheLoai.Items.Add("Tieu thuyet");
         cmbTheLoai.Items.Add("Sach thieu nhi");
         cmbTheLoai.Items.Add("Tam ly, tam linh, ton gia");
         cmbTheLoai.Items.Add("Van hoc nghe thuat");
         cmbTheLoai.Items.Add("Van hoa xa hoi - Lich su");
         cmbTheLoai.Items.Add("Khoa hoc cong nghe - Kinh te");
         cmbTheLoai.Items.Add("Chinh tri - phap luat");
         cmbTheLoai.Items.Add("Giao duc");

      }

      private void button1_Click(object sender, EventArgs e)
      {
         dataGridView1.DataSource = null;
         if(checkBox1.Checked == true)
         {
            dataGridView1.DataSource = sachBUS.LayDanhSach();
         }
         else
         {
            if (txbTenSach.Text != "")
            {
               dataGridView1.DataSource = sachBUS.TimSachTheoTen(txbTenSach.Text);
            }
            else
            {
               if(cmbTheLoai.SelectedIndex != -1)
               {
                  dataGridView1.DataSource = sachBUS.TimSachTheoTheLoai(cmbTheLoai.SelectedItem.ToString());
               }
               else
               {
                  if(txbTacGia.Text!="")
                  {
                     dataGridView1.DataSource = sachBUS.TimSachTheoTacGia(txbTacGia.Text);
                  }
                  else
                  {
                     MessageBox.Show("Vui lòng nhập tên sách hoặc thể loại hoặc tác giả cần tìm!");
                  }
               }
            }
            if (dataGridView1.RowCount == 0)
            {
               MessageBox.Show("Không có sách cần tìm!!!");
            }
         }
      }
   }
}
