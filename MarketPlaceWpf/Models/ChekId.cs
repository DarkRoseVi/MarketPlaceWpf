//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketPlaceWpf.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChekId
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChekId()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        public string Numger { get; set; }
        public string CSV { get; set; }
        public Nullable<System.DateTime> Age { get; set; }
        public Nullable<int> BankId { get; set; }
    
        public virtual Bank Bank { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}