using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.DAO
{
   public class LoaiDocGiaDao
   {
      ConnectString connect = new ConnectString();
      public DataTable LayDsLoaiDG()
      {
         return connect.LayDuLieu("Select * from LoaiDocGia where Xoa == false");
      }
   }
}
