//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelMVPDataBasePart
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserDataTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserDataTable()
        {
            this.EventTimeTable = new HashSet<EventTimeTable>();
        }
    
        public decimal ID { get; set; }
        public Nullable<decimal> UserGroup { get; set; }
        public decimal NumOfEvents { get; set; }
        public short UserID { get; set; }
        public string Name { get; set; }
        public byte[] sid { get; set; }
        public Nullable<short> status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventTimeTable> EventTimeTable { get; set; }
    }
}
