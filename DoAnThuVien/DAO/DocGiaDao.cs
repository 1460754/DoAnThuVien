using DoAnThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.DAO
{
   public class DocGiaDao
   {
      ConnectString connect = new ConnectString();
      public DataTable LayDsDocGia()
      {
         return connect.LayDuLieu("Select * from DocGia where Xoa == false");
      }
      public int ThemDocGia(DocGiaDto docGiaDto)
      {
         //Xử lý dữ liệu
         string sql = string.Format("Insert Into DocGia (HoTen, GioiTinh, NgaySinh, DiaChi, SDT, CMND, LoaiDG, NgayLapThe, NgayHetHan, SoSachMuon, TinhTrangThe, Xoa) Values('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}',{9},'',0)", docGiaDto.HoTen, docGiaDto.GioiTinh, docGiaDto.NgaySinh, docGiaDto.DiaChi, docGiaDto.SDT, docGiaDto.CMND, docGiaDto.LoaiDG, docGiaDto.NgayLapThe, docGiaDto.NgayHetHan, docGiaDto.SoSachMuon, docGiaDto.TinhTrangThe);

         return connect.ThucThi(sql);
      }

      public int CapNhatDocGia(DocGiaDto docGiaDto)
      {
         //Xử lý dữ liệu
         string sql = string.Format("Update DocGia set HoTen='{1}', GioiTinh='{2}',NgaySinh='{3}', DiaChi='{4}', SDT='{5}', CMND='{6}', LoaiDG={7}, NgayLapThe='{8}', NgayHetHan='{9}',SoSachMuon={10}, TinhTrangThe='{11}' where ID={0}", docGiaDto.ID, docGiaDto.HoTen, docGiaDto.GioiTinh, docGiaDto.NgaySinh, docGiaDto.DiaChi, docGiaDto.SDT, docGiaDto.CMND, docGiaDto.LoaiDG, docGiaDto.NgayLapThe, docGiaDto.NgayHetHan, docGiaDto.SoSachMuon, docGiaDto.TinhTrangThe);

         return connect.ThucThi(sql);
      }

      public int XoaDocGia(int MaDocGia)
      {
         string sql = string.Format("Update DocGia set Xoa = 1 where ID={0}", MaDocGia);

         return connect.ThucThi(sql);
      }

      public int XoaDocGiaThat(int MaDocGia)
      {
         string sql = string.Format("Delete DocGia where ID={0}", MaDocGia);

         return connect.ThucThi(sql);
      }
   }
}
