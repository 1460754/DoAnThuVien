using DoAnThuVien.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.BUS
{
   public class LoaiDocGiaBus
   {
      LoaiDocGiaDao loaiDocGia = new LoaiDocGiaDao();
      public DataTable LayDanhSach()
      {
         try
         {
            return loaiDocGia.LayDsLoaiDG();
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      public int LaySoNgayMuon(int id)
      {
         if(id == 2)
         {
            return 12;
         }
         else
         {
            return 4;
         }
      }
      public int LaySoSachMuon (int id)
      {
         if (id == 2)
         {
            return 10;
         }
         else
         {
            return 5;
         }
      }
   }
}
