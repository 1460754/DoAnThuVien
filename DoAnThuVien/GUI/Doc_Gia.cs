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
   public partial class Doc_Gia : Form
   {
      QLThuVienEntities tv = new QLThuVienEntities();
      DocGiaBus docGiaBus = new DocGiaBus();
      public Doc_Gia()
      {
         InitializeComponent();
         cmbGioiTinh.Items.Add("Nu");
         cmbGioiTinh.Items.Add("Nam");

         cmbLoaiDG.DisplayMember = "TenLoaiDocGia";
         cmbLoaiDG.ValueMember = "ID";
         cmbLoaiDG.DataSource = tv.LoaiDocGias.ToList();

         dateTimePickerLap.Value = DateTime.Now;
         dateTimePickerHet.Value = DateTime.Now.AddMonths(6);
        // dataGridView1.DataSource = tv.DocGias.Where(dg => dg.Xoa == false).ToList();
      }

      private void btnThemDG_Click(object sender, EventArgs e)
      {
         DocGiaDto dg = new DocGiaDto();
         dg.HoTen = txbTen.Text;
         dg.GioiTinh = cmbGioiTinh.SelectedItem.ToString();
         dg.LoaiDG = int.Parse(cmbLoaiDG.SelectedValue.ToString());
         dg.SDT = txbSDT.Text;
         dg.CMND = txbCMND.Text;
         dg.NgayHetHan = dateTimePickerHet.Value;
         dg.NgayLapThe = dateTimePickerLap.Value;
         dg.NgaySinh = dateTimePickerNgSinh.Value;
         dg.SoSachMuon = 0;
         txbSoSachMuon.Text = "0";
         // kiểm tra tình trạng thẻ
         dg.TinhTrangThe = KiemTraTinhTrangThe(dg.NgayHetHan);
         string mess = docGiaBus.ThemDocGia(dg);
         MessageBox.Show(mess);
      }

      private void btnXoa_Click(object sender, EventArgs e)
      {
         int temp = 0;
         if (txbMaDG.Text != "" && int.TryParse(txbMaDG.Text, out temp))
         {
            string mess = docGiaBus.XoaDocGia(int.Parse(txbMaDG.Text));
            MessageBox.Show(mess);
         }
         else
         {
            MessageBox.Show("Vui lòng nhập mã độc giả đúng!!!");
         }
      }

      private void btnCapNhat_Click(object sender, EventArgs e)
      {
         int temp = 0;
         if (txbMaDG.Text != "" && int.TryParse(txbMaDG.Text, out temp))
         {
            DocGiaDto dg = new DocGiaDto();
            dg.ID = temp;
            dg.HoTen = txbTen.Text;
            dg.GioiTinh = cmbGioiTinh.SelectedItem.ToString();
            dg.LoaiDG = int.Parse(cmbLoaiDG.SelectedValue.ToString());
            dg.SDT = txbSDT.Text;
            dg.CMND = txbCMND.Text;
            dg.NgayHetHan = dateTimePickerHet.Value;
            dg.NgayLapThe = dateTimePickerLap.Value;
            dg.NgaySinh = dateTimePickerNgSinh.Value;
            dg.TinhTrangThe = KiemTraTinhTrangThe(dg.NgayHetHan);
            string mess = docGiaBus.SuaDocGia(dg);
            MessageBox.Show(mess);
         }
         else
         {
            MessageBox.Show("Vui lòng nhập mã độc giả đúng!!!");
         }
      }

      private void btnReset_Click(object sender, EventArgs e)
      {
         txbMaDG.Text = "";
         txbTen.Text = "";
         txbSoSachMuon.Text = "";
         txbSDT.Text = "";
         txbCMND.Text = "";
         dateTimePickerLap.Value = DateTime.Now;
         dateTimePickerHet.Value = DateTime.Now;
         dateTimePickerNgSinh.Value = DateTime.Now;
         txbTinhTrangThe.Text = "";
      }

      // Kiem tra tinh trang the doc gia
      public string KiemTraTinhTrangThe(DateTime NgayHetHan)
      {
         string mess = "";
         if(NgayHetHan < DateTime.Now)
         {
            mess = "Het han su dung";
         }
         else
         {
            if (NgayHetHan.AddDays(-15) < DateTime.Now)
            {
               mess = "Gan het han su dung";
            }
            else
            {
               mess = "Con han su dung";
            }
         }
         txbTinhTrangThe.Text = mess;
         return mess;
      }

      private void btnTim_Click(object sender, EventArgs e)
      {
         int MaDG = 0;
         if(txbMaDGTim.Text != "")
         {
            if(int.TryParse(txbMaDGTim.Text, out MaDG))
            {
               dataGridView1.DataSource = tv.DocGias.Where(dg => dg.ID == MaDG && dg.Xoa == false).ToList();
            }
            else
            {
               MessageBox.Show("Vui lòng nhập mã độc giả đúng!!!");
            }
         }
         else
         {
            if(txbTenDGTim.Text!="")
            {
               dataGridView1.DataSource = tv.DocGias.Where(dg => dg.HoTen.Contains(txbTenDGTim.Text) && dg.Xoa == false).ToList();
            }
            else
            {
               if(txbCMNDTim.Text !="")
               {
                  dataGridView1.DataSource = tv.DocGias.Where(dg => dg.CMND.Contains(txbCMNDTim.Text) && dg.Xoa == false).ToList();
               }
               else
               {
                  dataGridView1.DataSource = tv.DocGias.Where(dg => dg.Xoa == false).ToList();
               }
            }
         }
         if (dataGridView1.RowCount == 0)
         {
            MessageBox.Show("Không có độc giả cần tìm!!!");
         }
      }

      private void dateTimePickerLap_ValueChanged(object sender, EventArgs e)
      {
         dateTimePickerHet.Value = dateTimePickerLap.Value.AddMonths(6);
      }
   }
}
