//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnThuVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sach
    {
        public int ID { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string TheLoai { get; set; }
        public string NXB { get; set; }
        public string NamXB { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public Nullable<int> ID_Loai { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public Nullable<bool> Xoa { get; set; }
    }
}
