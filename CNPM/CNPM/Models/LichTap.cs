//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LichTap
    {
        public int MaLT { get; set; }
        public Nullable<int> MaDK { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public System.TimeSpan GioBatDau { get; set; }
        public Nullable<System.TimeSpan> GioKetThuc { get; set; }
        public string TenPhong { get; set; }
        public string MoTa { get; set; }
    
        public virtual ThongTinDangKy ThongTinDangKy { get; set; }
    }
}
