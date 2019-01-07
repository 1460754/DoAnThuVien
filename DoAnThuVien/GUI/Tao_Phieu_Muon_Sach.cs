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
         docGia = null;
      }

      private void btnKiemTra_Click(object sender, EventArgs e)
      {
         // DocGia docGia = new DocGia();
         int temp = 0;
         if (txbMaDG.Text != "" && int.TryParse(txbMaDG.Text, out temp))
         {
            docGia = tv.DocGias.Where(dg => dg.ID == temp).SingleOrDefault() as DocGia;
         }
         else
         {
            if (txbCMND.Text != "")
            {
               docGia = tv.DocGias.Where(dg => dg.CMND == txbCMND.Text).SingleOrDefault() as DocGia;
            }
            else
            {
               if (txbHoTen.Text != "")
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
            dateTimePicker1.Value = DateTime.Now.AddDays(int.Parse(txbSoNgay.Text));
         }
      }

      private void button5_Click(object sender, EventArgs e)
      {
         Sach sach = new Sach();
         sach = null;
         int temp = 0;
         if (txbMaDG.Text == "" || docGia == null)
         {
            MessageBox.Show("Vui lòng chọn độc giả trước");
            return;
         }
         if (txbMaSach.Text != "" && int.TryParse(txbMaSach.Text, out temp))
         {
            sach = tv.Saches.Where(s => s.ID == temp).SingleOrDefault() as Sach;
         }
         else
         {
            if (txbTenSach.Text != "")
            {
               sach = tv.Saches.Where(s => s.TenSach == txbTenSach.Text).SingleOrDefault() as Sach;
            }
            else
            {
               MessageBox.Show("Vui lòng nhập mã sách hoặc tên sách");
               return;
            }
         }
         if (sach == null)
         {
            MessageBox.Show("Không có sách cần tìm");
         }
         else
         {
            txbMaDG.Text = sach.ID.ToString();
            txbTenSach.Text = sach.TenSach;
            txbSLTon.Text = sach.SoLuongTon.ToString();
            if (docGia != null)
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
         int idpm = 0;
         if (txbMaPM.Text != "" && int.TryParse(txbMaPM.Text, out idpm))
         {
            PhieuMuon pm = new PhieuMuon();
            pm = tv.PhieuMuons.Where(pms => pms.ID == idpm).SingleOrDefault() as PhieuMuon;
            if (pm != null)
            {
               int idsach = 0;
               if (txbMaSach.Text != "" && int.TryParse(txbMaSach.Text, out idsach))
               {
                  CTPhieuMuonBUS cTPhieuMuon = new CTPhieuMuonBUS();
                  CTPhieuMuonDto dto = new CTPhieuMuonDto();
                  dto.ID_PhieuMuon = idpm;
                  dto.ID_Sach = idsach;
                  string mess = cTPhieuMuon.ThemCTPhieuMuon(dto);
                  MessageBox.Show(mess);
                  LoadDSSach(idpm);
                  txbSLTon.Text = (int.Parse(txbSLTon.Text) - 1).ToString();
                  txbDuocMuon.Text = (int.Parse(txbDuocMuon.Text) - 1).ToString();
               }
               else
               {
                  MessageBox.Show("Vui lòng nhập mã sách đúng");
               }
            }
            else
            {
               MessageBox.Show("Vui lòng lập phiếu mượn sách");
            }
         }
         else
         {
            MessageBox.Show("Vui lòng lập phiếu mượn sách");
         }

      }

      private void btnLapPM_Click(object sender, EventArgs e)
      {
         if (docGia == null)
         {
            MessageBox.Show("Vui lòng chọn độc giả trước");
            return;
         }
         else
         {
            PhieuMuonBus phieuMuonBus = new PhieuMuonBus();
            PhieuMuonDto phieuMuonDto = new PhieuMuonDto();
            phieuMuonDto.ID_DG = docGia.ID;
            phieuMuonDto.NgayMuon = DateTime.Now;
            phieuMuonDto.TongSoSachMuon = 0;
            phieuMuonDto.NgayTra = DateTime.Now.AddDays(int.Parse(txbSoNgay.Text));
            int idpm = phieuMuonBus.ThemPhieuMuon(phieuMuonDto);
            if (idpm != 0)
            {
               MessageBox.Show("Đã lập phiếu mượn");
               txbMaPM.Text = idpm.ToString();
            }
         }
      }
      public void LoadDSSach(int idpm)
      {
         CTPhieuMuonBUS cTPhieuMuon = new CTPhieuMuonBUS();
         dataGridView1.DataSource = cTPhieuMuon.LayDanhSach(idpm);
      }

      private void btnXoa_Click(object sender, EventArgs e)
      {
         int idpm = 0;
         if (txbMaPM.Text != "" && int.TryParse(txbMaPM.Text, out idpm))
         {
            PhieuMuon pm = new PhieuMuon();
            pm = tv.PhieuMuons.Where(pms => pms.ID == idpm).SingleOrDefault() as PhieuMuon;
            if (pm != null)
            {
               int idsach = 0;
               if (txbMaSach.Text != "" && int.TryParse(txbMaSach.Text, out idsach))
               {
                  CTPhieuMuonBUS cTPhieuMuon = new CTPhieuMuonBUS();
                  string mess = cTPhieuMuon.XoaCTPhieuMuon(idsach, idpm);
                  MessageBox.Show(mess);
                  LoadDSSach(idpm);
                  txbSLTon.Text = (int.Parse(txbSLTon.Text) + 1).ToString();
                  txbDuocMuon.Text = (int.Parse(txbDuocMuon.Text) + 1).ToString();
               }
               else
               {
                  MessageBox.Show("Vui lòng nhập mã sách đúng");
               }
            }
            else
            {
               MessageBox.Show("Vui lòng lập phiếu mượn sách");
            }
         }
         else
         {
            MessageBox.Show("Vui lòng lập phiếu mượn sách");
         }
      }

      private void btnReset_Click(object sender, EventArgs e)
      {
         txbMaSach.Text = "";
         txbSLTon.Text = "";
         txbTenSach.Text = "";
         txbDuocMuon.Text = "";
      }

      private void btnResetAll_Click(object sender, EventArgs e)
      {
         txbMaSach.Text = "";
         txbSLTon.Text = "";
         txbTenSach.Text = "";
         txbDuocMuon.Text = "";

         txbMaDG.Text = "";
         txbHoTen.Text = "";
         txbCMND.Text = "";
         txbLoaiDG.Text = "";
         txbSoNgay.Text = "";
         txbSoSachDg.Text = "";
         txbMaPM.Text = "";
      }

      private void btnXoaPM_Click(object sender, EventArgs e)
      {
         PhieuMuonBus pmBus = new PhieuMuonBus();
         int idpm = 0;
         if (txbMaPM.Text != "" && int.TryParse(txbMaPM.Text, out idpm))
         {
            PhieuMuon pm = new PhieuMuon();
            pm = tv.PhieuMuons.Where(pms => pms.ID == idpm).SingleOrDefault() as PhieuMuon;
            if (pm != null)
            {
               pmBus.XoaPhieuMuon(idpm);
            }
            else
            {
               MessageBox.Show("Không có phiếu mượn này");
            }
         }
         else
         {
            MessageBox.Show("Vui lòng nhập mã phiếu mượn sách");
         }


      }

      private void button1_Click(object sender, EventArgs e)
      {
         CTPhieuMuonBUS ctpm = new CTPhieuMuonBUS();
         int idpm = 0;
         if (txbMaPM.Text != "" && int.TryParse(txbMaPM.Text, out idpm))
         {
            PhieuMuon pm = new PhieuMuon();
            pm = tv.PhieuMuons.Where(pms => pms.ID == idpm).SingleOrDefault() as PhieuMuon;
            if (pm != null)
            {
               dataGridView1.DataSource = ctpm.LayDanhSach(idpm);
               if (dataGridView1.Rows.Count == 0)
               {
                  MessageBox.Show("Không có sách nào được mượn");
               }
            }
            else
            {
               MessageBox.Show("Không có phiếu mượn này");
            }
         }
         else
         {
            MessageBox.Show("Vui lòng nhập mã phiếu mượn sách");
         }
      }
   }
}
