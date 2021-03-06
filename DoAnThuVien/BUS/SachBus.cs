﻿using DoAnThuVien.DAO;
using DoAnThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.BUS
{
   public class SachBus
   {
      SachDao sachDao = new SachDao();
      public DataTable LayDanhSach()
      {
         try
         {
            return sachDao.LayDanhSachSach();
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      public DataTable TimSachTheoTen(string TenSach)
      {
         try
         {
            return sachDao.TimSachTheoTen(TenSach);
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      public DataTable TimSachTheoTheLoai(string TheLoai)
      {
         try
         {
            return sachDao.TimSachTheoTheLoai(TheLoai);
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      public DataTable TimSachTheoTacGia(string TacGia)
      {
         try
         {
            return sachDao.TimSachTheoTacGia(TacGia);
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      public string ThemSach(SachDto sach)
      {
         string kq = "";
         if (sachDao.ThemSach(sach) != -1)
         {
            kq = "Đã thêm thành công!";
         }
         else
         {
            kq = "Thêm thất bại!";
         }
         return kq;
      }
      public string SuaSach(SachDto sach)
      {
         string kq = "";
        /* if(!sachDao.KiemTraMaSach(sach.ID))
         {
            return "Mã sách không tồn tại!";
         }*/
         int temp = sachDao.CapNhatSach(sach);
         if (temp != -1)
         {
            if (temp == 0)
            {
               kq = "Sách không tồn tại";
            }
            else
            {
               kq = "Đã cập nhật thành công!";
            }
         }
         else
         {
            kq = "Cập nhật thất bại!";
         }
         return kq;
      }
      public string XoaSach(int masach)
      {
         string kq = "";
         //if (!sachDao.KiemTraMaSach(masach))
         //{
         //   return "Mã sách không tồn tại!";
         //}
         int temp = sachDao.XoaSach(masach);
         if (temp != -1)
         {
            if (temp == 0)
            {
               kq = "Sách không tồn tại";
            }
            else
            {
               kq = "Đã xóa thành công!";
            }  
         }
         else
         {
            kq = "Xóa thất bại!";
         }
         return kq;
      }
   }
}
