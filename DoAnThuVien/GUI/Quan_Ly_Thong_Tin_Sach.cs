using DoAnThuVien.BUS;
using DoAnThuVien.DTO;
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
   public partial class Quan_Ly_Thong_Tin_Sach : Form
   {
      SachBus sachBUS = new SachBus();
      QLThuVienEntities tv = new QLThuVienEntities();
      public Quan_Ly_Thong_Tin_Sach()
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

         //cmb The loai cua sach can tim
         cmbTheLoaiTim.Items.Add("Tieu thuyet");
         cmbTheLoaiTim.Items.Add("Sach thieu nhi");
         cmbTheLoaiTim.Items.Add("Tam ly, tam linh, ton gia");
         cmbTheLoaiTim.Items.Add("Van hoc nghe thuat");
         cmbTheLoaiTim.Items.Add("Van hoa xa hoi - Lich su");
         cmbTheLoaiTim.Items.Add("Khoa hoc cong nghe - Kinh te");
         cmbTheLoaiTim.Items.Add("Chinh tri - phap luat");
         cmbTheLoaiTim.Items.Add("Giao duc");

         dataGridView1.DataSource = tv.Saches.Where(s => s.Xoa == false).ToList();
      }

      private void button2_Click(object sender, EventArgs e)
      {
         int temp = 0;
         float gia = 0;
         if (!int.TryParse(txbSoLuong.Text, out temp) || !float.TryParse(txtGia.Text, out gia))
         {
            MessageBox.Show("Vui lòng điền số!");
         }
         else
         {
            SachDto sachDto = new SachDto();
            // sachDto.ID = textBox1.Text;
            sachDto.TenSach = txbTen.Text;
            sachDto.TacGia = txbTacGia.Text;
            sachDto.TheLoai = cmbTheLoai.SelectedItem.ToString();
            sachDto.ID_Loai = 0;
            sachDto.NXB = txbNXB.Text;
            sachDto.NamXB = txtNamXB.Text;
            sachDto.NgayNhap = DateTime.Now;
            sachDto.SoLuong = int.Parse(txbSoLuong.Text);
            sachDto.SoLuongTon = int.Parse(txbSoLuong.Text);
            sachDto.DonGia = float.Parse(txtGia.Text);
            string mess = sachBUS.ThemSach(sachDto);
            MessageBox.Show(mess);
         }

      }

      private void button4_Click(object sender, EventArgs e)
      {
         int temp = 0;
         float gia = 0;
         if (!int.TryParse(txbSoLuong.Text, out temp) || !float.TryParse(txtGia.Text, out gia) || !int.TryParse(txbMa.Text, out temp))
         {
            MessageBox.Show("Vui lòng điền số!");
         }
         else
         {
            SachDto sachDto = new SachDto();
            sachDto.ID = int.Parse(txbMa.Text);
            sachDto.TenSach = txbTen.Text;
            sachDto.TacGia = txbTacGia.Text;
            sachDto.TheLoai = cmbTheLoai.SelectedItem.ToString();
            sachDto.ID_Loai = 0;
            sachDto.NXB = txbNXB.Text;
            sachDto.NamXB = txtNamXB.Text;
            sachDto.NgayNhap = DateTime.Now;
            sachDto.SoLuong = int.Parse(txbSoLuong.Text);
            sachDto.SoLuongTon = int.Parse(txbSoLuong.Text);
            sachDto.DonGia = float.Parse(txtGia.Text);
            string mess = sachBUS.SuaSach(sachDto);
            MessageBox.Show(mess);
         }
      }

      private void button3_Click(object sender, EventArgs e)
      {
         int temp = 0;
         if (!int.TryParse(txbMa.Text, out temp))
         {
            MessageBox.Show("Vui lòng đúng mã!");
         }
         else
         {
            string mess = sachBUS.XoaSach(int.Parse(txbMa.Text));
            MessageBox.Show(mess);
         }
      }

      private void button5_Click(object sender, EventArgs e)
      {
         txbMa.Text = "";
         txbTen.Text = "";
         txbTacGia.Text = "";
         cmbTheLoai.SelectedItem = -1;
         txbNXB.Text = "";
         txtNamXB.Text = "";
         txbSoLuong.Text = "";
         txtGia.Text = "";
      }

      private void button1_Click(object sender, EventArgs e)
      {
         if (txbTenSachTim.Text != "")
         {
            dataGridView1.DataSource = tv.Saches.Where(s => s.TenSach.Contains(txbTenSachTim.Text) && s.Xoa == false).ToList();
         }
         else
         {
            if (cmbTheLoaiTim.SelectedIndex != -1)
            {
               dataGridView1.DataSource = tv.Saches.Where(s => s.TheLoai == cmbTheLoaiTim.SelectedItem.ToString() && s.Xoa == false).ToList();
            }
            else
            {
               if (txbTacGiaTim.Text != "")
               {
                  dataGridView1.DataSource = tv.Saches.Where(s => s.TacGia.Contains(txbTacGiaTim.Text) && s.Xoa == false).ToList();
               }
               else
               {
                  dataGridView1.DataSource = tv.Saches.Where(s => s.Xoa == false).ToList();
               }
            }
         }
         if(dataGridView1.RowCount == 0)
         {
            MessageBox.Show("Không có sách cần tìm!!!");
         }
      }
   }
}
