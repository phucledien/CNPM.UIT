//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            this.CTPTs = new HashSet<CTPT>();
        }
    
        public int MAKHACHHANG { get; set; }
        public string TENKHACHHANG { get; set; }
        public int MALOAIKHACH { get; set; }
        public string CMND { get; set; }
        public string DIACHI { get; set; }
        public Nullable<int> MAPHONG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPT> CTPTs { get; set; }
        public virtual LOAIKHACH LOAIKHACH { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}
