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
    public partial class Tao_Phieu_Muon_Sach : Form
    {
      QLThuVienEntities tv = new QLThuVienEntities();
      DocGia docGia = new DocGia();
      public Tao_Phieu_Muon_Sach()
        {
            InitializeComponent();
        }

      private void btnKiemTra_Click(object sender, EventArgs e)
      {
        // DocGia docGia = new DocGia();
         int temp = 0;
         if (txbMaDG.Text!="" && int.TryParse(txbMaDG.Text, out temp))
         {
            docGia = tv.DocGias.Where(dg => dg.ID == temp).SingleOrDefault() as DocGia;
         }
         else
         {
            if(txbCMND.Text!="")
            {
               docGia = tv.DocGias.Where(dg => dg.CMND == txbCMND.Text).SingleOrDefault() as DocGia;
            }
            else
            {
               if(txbHoTen.Text!="")
               {
                  docGia = tv.DocGias.Where(dg => dg.HoTen == txbHoTen.Text).SingleOrDefault() as DocGia;
               }
               else
               {
                  MessageBox.Show("Vui lòng nhập mã độc giả hoặc CMND hoặc họ tên!");
                  return;
               }
            }
         }
         if (docGia == null)
         {
            MessageBox.Show("Không có độc giả cần tìm!!!");
         }
         else
         {
            txbMaDG.Text = docGia.ID.ToString();
            txbHoTen.Text = docGia.HoTen;
            txbCMND.Text = docGia.CMND;
            LoaiDocGia ldg = tv.LoaiDocGias.Where(l => l.ID == docGia.LoaiDG).SingleOrDefault() as LoaiDocGia;
            txbLoaiDG.Text = ldg.TenLoaiDocGia;
            txbSoNgay.Text = ldg.SoNgayMuon.ToString();
            txbSoSachDg.Text = ldg.SoSachMuon.ToString();
         }
      }

      private void button5_Click(object sender, EventArgs e)
      {
         Sach sach = new Sach();
         int temp = 0;
         if(txbMaDG.Text == "" || docGia == null)
         {
            MessageBox.Show("Vui lòng chọn độc giả trước");
            return;
         }
         if(txbMaSach.Text != "" && int.TryParse(txbMaSach.Text,out temp))
         {
           sach = tv.Saches.Where(s => s.ID == temp).SingleOrDefault() as Sach;
         }
         else
         {
            if(txbTenSach.Text!="")
            {
               sach = tv.Saches.Where(s => s.TenSach == txbTenSach.Text).SingleOrDefault() as Sach;
            }
            else
            {
               MessageBox.Show("Vui lòng nhập mã sách hoặc tên sách");
               return;
            }
         }
         if(sach == null)
         {
            MessageBox.Show("Không có sách cần tìm");
         }
         else
         {
            txbMaDG.Text = sach.ID.ToString();
            txbTenSach.Text = sach.TenSach;
            txbSLTon.Text = sach.SoLuongTon.ToString();
            if(docGia != null)
            {
               int SachDuocMuon = (int.Parse(txbSoSachDg.Text) - int.Parse(docGia.SoSachMuon.ToString()));
               txbDuocMuon.Text = SachDuocMuon.ToString();
            }
            else
            {
               MessageBox.Show("Vui lòng chọn độc giả trước");
            }
            
         }
      }

      private void btnThemSach_Click(object sender, EventArgs e)
      {


      }
   }
}
