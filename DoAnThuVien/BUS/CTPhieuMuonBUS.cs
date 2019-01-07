using DoAnThuVien.DAO;
using DoAnThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.BUS
{
   public class CTPhieuMuonBUS
   {
      CTPhieuMuonDao phieuMuonDao = new CTPhieuMuonDao();
      public DataTable LayDanhSach(int id)
      {
         try
         {
            return phieuMuonDao.LayDsSach(id);
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      public string ThemCTPhieuMuon(CTPhieuMuonDto phieuMuon)
      {
         string kq = "";
         QLThuVienEntities tv = new QLThuVienEntities();
         Sach sach = tv.Saches.Where(s => s.ID == phieuMuon.ID_Sach).SingleOrDefault() as Sach;
         if(sach == null)
         {
            return "Sách không tồn tại";
         }
         CTPhieuMuon ctPhieuMuon = tv.CTPhieuMuons.Where(c => c.ID_PhieuMuon == phieuMuon.ID_PhieuMuon && c.ID_Sach == phieuMuon.ID_Sach).SingleOrDefault() as CTPhieuMuon;
         if(ctPhieuMuon != null)
         {
            return "Mỗi sách chỉ được mượn một cuốn";
         }
         if (phieuMuonDao.ThemCTPhieuMuon(phieuMuon) != -1)
         {
            kq = "Đã thêm thành công!";
         }
         else
         {
            kq = "Thêm thất bại!";
         }
         return kq;
      }
      public string XoaCTPhieuMuon(int idsach, int idpm)
      {
         string kq = "";
         int temp = phieuMuonDao.XoaCTPhieuMuon(idsach, idpm);
         if (temp != -1)
         {
            if (temp == 0)
            {
               kq = "Phiếu mượn không tồn tại";
            }
            else
            {
               kq = "Đã xóa thành công!";
            }
         }
         else
         {
            kq = "Xóa thất bại!";
         }
         return kq;
      }
   }
}
