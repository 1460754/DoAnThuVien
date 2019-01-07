using DoAnThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.DAO
{
   public class PhieuMuonDao
   {
      ConnectString connect = new ConnectString();
      public int ThemPhieuMuon(PhieuMuonDto phieuMuonDto)
      {
         //Xử lý dữ liệu
         string sql = string.Format("Insert Into PhieuMuon (ID_DG, TongSoSachMuon, NgayMuon, NgayTra) Values({0},0,'{1}','{2}') select @@IDENTITY", phieuMuonDto.ID_DG, phieuMuonDto.NgayMuon, phieuMuonDto.NgayTra);

         return connect.ThemID(sql);
      }

      public int XoaPhieuMuon(int id)
      {
         string sql = string.Format("Delete PhieuMuon where ID={0}", id);

         return connect.ThucThi(sql);
      }
   }
}
