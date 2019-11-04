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
    
    public partial class ProductTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductTable()
        {
            this.SizeTable = new HashSet<SizeTable>();
        }
    
        public int ProductID { get; set; }
        public string productName { get; set; }
        public string productBrand { get; set; }
        public string productDetails { get; set; }
        public string picture1 { get; set; }
        public string picture2 { get; set; }
        public string picture3 { get; set; }
        public string picture4 { get; set; }
        public int SubCategoryID { get; set; }
        public int SellerID { get; set; }
        public int SuitableID { get; set; }
    
        public virtual SellerTable SellerTable { get; set; }
        public virtual SubCategoryTable SubCategoryTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SizeTable> SizeTable { get; set; }
        public virtual SuitableForTable SuitableForTable { get; set; }
    }
}
