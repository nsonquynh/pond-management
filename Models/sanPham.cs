//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_AoNuoi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sanPham
    {
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string maNH { get; set; }
        public string maNhomHang { get; set; }
        public string dvTinh { get; set; }
        public string thue { get; set; }
        public string ghiChu { get; set; }
    
        public virtual nganhHang nganhHang { get; set; }
        public virtual nhomHang nhomHang { get; set; }
    }
}
