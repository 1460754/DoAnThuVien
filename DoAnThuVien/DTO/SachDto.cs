using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.DTO
{
   public class SachDto
   {
      public int ID { get; set; }
      public string TenSach { get; set; }
      public string TacGia { get; set; }
      public string TheLoai { get; set; }
      public string NXB { get; set; }
      public string NamXB { get; set; }
      public DateTime NgayNhap { get; set; }
      public int ID_Loai { get; set; }
      public float DonGia { get; set; }
      public int SoLuong { get; set; }
      public int SoLuongTon { get; set; }
      public Boolean Xoa { get; set; }

   }
}
