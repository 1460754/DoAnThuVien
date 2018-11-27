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
        public Doc_Gia()
        {
            InitializeComponent();
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Nam");
        }

      private void btnThemDG_Click(object sender, EventArgs e)
      {
         DocGiaDto dg = new DocGiaDto();
         dg.HoTen = txbTen.Text;
         dg.GioiTinh = cmbGioiTinh.SelectedText;
         //dg.DiaChi =
         // dg.LoaiDG = cmbLoaiDG.SelectedValue;
         dg.SDT = txbSDT.Text;
         dg.CMND = txbCMND.Text;
         dg.NgayHetHan = dateTimePickerHet.Value;
         dg.NgayLapThe = dateTimePickerLap.Value;
         //dg.TinhTrangThe = cmb
      }

      private void btnXoa_Click(object sender, EventArgs e)
      {

      }

      private void btnCapNhat_Click(object sender, EventArgs e)
      {

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
      }
   }
}
