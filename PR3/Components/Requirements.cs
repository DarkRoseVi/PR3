//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR3.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class Requirements
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requirements()
        {
            this.Client = new HashSet<Client>();
        }
    
        public int Id { get; set; }
        public Nullable<int> TargetId { get; set; }
        public Nullable<int> RequiredCharacteristicId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Client { get; set; }
        public virtual RequiredCharacteristic RequiredCharacteristic { get; set; }
        public virtual Target Target { get; set; }
    }
}
