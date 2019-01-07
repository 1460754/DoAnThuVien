using DoAnThuVien.DAO;
using DoAnThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.BUS
{
   public class PhieuMuonBus
   {
      PhieuMuonDao phieuMuonDao = new PhieuMuonDao();
      public int ThemPhieuMuon(PhieuMuonDto phieuMuon)
      {
         return phieuMuonDao.ThemPhieuMuon(phieuMuon);
      }
      public string XoaPhieuMuon(int id)
      {
         string kq = "";
         int temp = phieuMuonDao.XoaPhieuMuon(id);
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
