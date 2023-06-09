//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyShopQuanAo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            this.BillDetails = new HashSet<BillDetail>();
        }
    
        public string ID { get; set; }
        public string PartnerID { get; set; }
        public string BillType { get; set; }
        public Nullable<System.DateTime> EstablishedDate { get; set; }
        public string Stt { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> Tax { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }
        public virtual Partner Partner { get; set; }
    }
}
