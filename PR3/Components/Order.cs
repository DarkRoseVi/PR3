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
    
    public partial class Order
    {
        public int Id { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> SliderId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual Slider Slider { get; set; }
    }
}
