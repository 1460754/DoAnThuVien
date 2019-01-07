using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.DTO
{
   public class PhieuMuonDto
   {
      public int ID { get; set; }
      public int ID_DG { get; set; }
      public int TongSoSachMuon { get; set; }
      public DateTime NgayMuon { get; set; }
      public DateTime NgayTra { get; set; }
      public string TinhTrang { get; set; }
   }
}
