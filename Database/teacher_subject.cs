//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class teacher_subject
    {
        public int id { get; set; }
        public Nullable<int> teacher_id { get; set; }
        public Nullable<int> subject_id { get; set; }
    
        public virtual subject subject { get; set; }
        public virtual user user { get; set; }
    }
}
