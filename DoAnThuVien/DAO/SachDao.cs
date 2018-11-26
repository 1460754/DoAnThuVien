using DoAnThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.DAO
{
   public class SachDao
   {
      ConnectString connect = new ConnectString();

      public DataTable LayDanhSachSach()
      {
         return connect.LayDuLieu("Select * from Sach where Xoa == false");
      }

      public Boolean KiemTraMaSach(int MaSach)
      {
         string sql = "Select * from Sach where Xoa == false and ID=" + MaSach;
         DataTable data = connect.LayDuLieu(sql);
         if(data.Rows.Count > 0)
         {
            return true;
         }
         return false;
      }
      public int ThemSach(SachDto sachDto)
      {
         //Xử lý dữ liệu
         string sql = string.Format("Insert Into Sach(TenSach,TacGia,TheLoai, NXB, NamXB, NgayNhap, ID_Loai, DonGia, SoLuong, SoLuongTon, Xoa) Values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},{8},{9},0)", sachDto.TenSach, sachDto.TacGia, sachDto.TheLoai, sachDto.NXB, sachDto.NamXB, sachDto.NgayNhap.ToShortDateString(), sachDto.ID_Loai, sachDto.DonGia, sachDto.SoLuong, sachDto.SoLuongTon);

         return connect.ThucThi(sql);
      }

      public int CapNhatSach(SachDto sachDto)
      {
         //Xử lý dữ liệu
         string sql = string.Format("Update Sach set TenSach='{1}', TacGia='{2}',TheLoai='{3}', NXB='{4}', NamXB='{5}', NgayNhap='{6}', ID_Loai={7}, DonGia={8}, SoLuong={9},SoLuongTon={10} where ID={0}", sachDto.ID, sachDto.TenSach, sachDto.TacGia, sachDto.TheLoai, sachDto.NXB, sachDto.NamXB, sachDto.NgayNhap, sachDto.ID_Loai, sachDto.DonGia, sachDto.SoLuong, sachDto.SoLuongTon);

         return connect.ThucThi(sql);
      }

      public int XoaSach(int MaSach)
      {
         string sql = string.Format("Update Sach set Xoa = 1 where ID={0}", MaSach);

         return connect.ThucThi(sql);
      }

      public int XoaSachThat(int MaSach)
      {
         string sql = string.Format("Delete Sach where MaSach={0}", MaSach);

         return connect.ThucThi(sql);
      }
   }
}
