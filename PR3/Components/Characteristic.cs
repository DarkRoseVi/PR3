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
    
    public partial class Characteristic
    {
        public int Id { get; set; }
        public int SliderId { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<int> ColorId { get; set; }
    
        public virtual Color Color { get; set; }
        public virtual Slider Slider { get; set; }
        public virtual Type Type { get; set; }
    }
}
