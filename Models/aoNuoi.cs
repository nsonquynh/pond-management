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
    
    public partial class aoNuoi
    {
        public string maAO { get; set; }
        public string tenAo { get; set; }
        public string kvNuoi { get; set; }
        public string maKho { get; set; }
        public Nullable<int> A { get; set; }
        public Nullable<int> B { get; set; }
        public Nullable<int> C { get; set; }
        public Nullable<int> D { get; set; }
        public Nullable<double> dienTich { get; set; }
        public Nullable<double> doSau { get; set; }
    
        public virtual QLKho QLKho { get; set; }
    }
}