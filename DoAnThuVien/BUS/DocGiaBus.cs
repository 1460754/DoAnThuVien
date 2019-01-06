using DoAnThuVien.DAO;
using DoAnThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuVien.BUS
{
   public class DocGiaBus
   {
      DocGiaDao docGiaDao = new DocGiaDao();
      public DataTable LayDanhSach()
      {
         try
         {
            return docGiaDao.LayDsDocGia();
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      public string ThemDocGia(DocGiaDto docGia)
      {
         string kq = "";
         if (docGiaDao.ThemDocGia(docGia) != -1)
         {
            kq = "Đã thêm thành công!";
         }
         else
         {
            kq = "Thêm thất bại!";
         }
         return kq;
      }
      public string SuaDocGia(DocGiaDto docGia)
      {
         string kq = "";
         int temp = docGiaDao.CapNhatDocGia(docGia);
         if (temp != -1)
         {
            if (temp == 0)
            {
               kq = "Độc giả không tồn tại";
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
      public string XoaDocGia(int maDocGia)
      {
         string kq = "";
         //if (!sachDao.KiemTraMaSach(masach))
         //{
         //   return "Mã sách không tồn tại!";
         //}
         int temp = docGiaDao.XoaDocGia(maDocGia);
         if (temp != -1)
         {
            if (temp == 0)
            {
               kq = "Độc giả không tồn tại";
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
