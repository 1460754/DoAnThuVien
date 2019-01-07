using DoAnThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.DAO
{
   public class CTPhieuMuonDao
   {
      ConnectString connect = new ConnectString();
      public DataTable LayDsSach(int id)
      {
         string sql = "Select * from CTPhieuMuon where ID_PhieuMuon = " + id.ToString();
         return connect.LayDuLieu(sql);
      }
      public int ThemCTPhieuMuon(CTPhieuMuonDto phieuMuonDto)
      {
         //Xử lý dữ liệu
         string sql = string.Format("Insert Into CTPhieuMuon (ID_PhieuMuon, ID_Sach) Values({0},{1})", phieuMuonDto.ID_PhieuMuon, phieuMuonDto.ID_Sach);

         return connect.ThucThi(sql);
      }

      public int XoaCTPhieuMuon(int idsach, int idpm)
      {
         string sql = string.Format("Delete CTPhieuMuon where ID_Sach={0} && ID_PhieuMuon", idsach, idpm);

         return connect.ThucThi(sql);
      }
   }
}
