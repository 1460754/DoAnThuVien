using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.DTO
{
   public class DocGiaDto
   {
      public int ID { get; set; }
      public string HoTen { get; set; }
      public string GioiTinh { get; set; }
      public DateTime NgaySinh { get; set; }
      public string DiaChi { get; set; }
      public string SDT { get; set; }
      public string CMND { get; set; }
      public int LoaiDG { get; set; }
      public DateTime NgayLapThe { get; set; }
      public DateTime NgayHetHan { get; set; }
      public int SoSachMuon { get; set; }
      public string TinhTrangThe { get; set; }
      public Boolean Xoa { get; set; }
   }
}
