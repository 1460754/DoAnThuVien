﻿using DoAnThuVien.DTO;
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

      public int ThemSach(SachDto sachDto)
      {
         //Xử lý dữ liệu
         string sql = string.Format("Insert Into Sach(TenSach,TacGia,TheLoai, NXB, NamXB, NgayNhap, ID_Loai, DonGia, SoLuong, SoLuongTon, Xoa) Values('{0}','{1}','{2}','{3}','{4}',{5},{6},{7},{8},{9},false)", sachDto.TenSach, sachDto.TacGia, sachDto.TheLoai, sachDto.NXB, sachDto.NamXB, sachDto.NgayNhap, sachDto.ID_Loai, sachDto.DonGia, sachDto.SoLuong, sachDto.SoLuongTon);

         return connect.ThucThi(sql);
      }

      public int CapNhatSach(SachDto sachDto)
      {
         //Xử lý dữ liệu
         string sql = string.Format("Update Sach set TenSach='{1}', TacGia='{2}',TheLoai='{3}', NXB='{4}', NamXB='{5}', NgayNhap={6}, ID_Loai={7}, DonGia={8}, SoLuong={9},SoLuongTon={10} where MaSach={0}", sachDto.ID, sachDto.TenSach, sachDto.TacGia, sachDto.TheLoai, sachDto.NXB, sachDto.NamXB, sachDto.NgayNhap, sachDto.ID_Loai, sachDto.DonGia, sachDto.SoLuong, sachDto.SoLuongTon);

         return connect.ThucThi(sql);
      }

      public int XoaSach(int MaSach)
      {
         string sql = string.Format("Update Sach set Xoa = true where MaSach={0}", MaSach);

         return connect.ThucThi(sql);
      }

      public int XoaSachThat(int MaSach)
      {
         string sql = string.Format("Delete Sach where MaSach={0}", MaSach);

         return connect.ThucThi(sql);
      }
   }
}
