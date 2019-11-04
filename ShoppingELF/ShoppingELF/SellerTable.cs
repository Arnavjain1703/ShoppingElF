//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingELF
{
    using System;
    using System.Collections.Generic;
    
    public partial class SellerTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SellerTable()
        {
            this.ProductTable = new HashSet<ProductTable>();
            this.SoldTable = new HashSet<SoldTable>();
        }
    
        public int SellerID { get; set; }
        public string yourName { get; set; }
        public string mobileNumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string pincode { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string AccountHolderName { get; set; }
        public string accountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string accountType { get; set; }
        public string Role { get; set; }
        public int shippingFeeDetails { get; set; }
        public string GSTNumber { get; set; }
        public string PANCardNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductTable> ProductTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoldTable> SoldTable { get; set; }
    }
}