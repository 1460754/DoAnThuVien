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
        public Quan_Ly_Thong_Tin_Sach()
        {
            InitializeComponent();
        }

      private void button2_Click(object sender, EventArgs e)
      {
         int temp = 0;
         float gia = 0;
         if(!int.TryParse(txbSoLuong.Text,out temp) || !float.TryParse(txtGia.Text, out gia))
         {
            MessageBox.Show("Vui lòng điền số!");
         }
         else
         {
            SachDto sachDto = new SachDto();
            // sachDto.ID = textBox1.Text;
            sachDto.TenSach = txbTen.Text;
            sachDto.TacGia = txbTacGia.Text;
            sachDto.TheLoai = txbTheLoai.Text;
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
            sachDto.TheLoai = txbTheLoai.Text;
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
         txbTheLoai.Text = "";
         txbNXB.Text = "";
         txtNamXB.Text = "";
         txbSoLuong.Text = "";
         txtGia.Text = "";
      }
   }
}
