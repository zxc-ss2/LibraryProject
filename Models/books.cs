//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public books()
        {
            this.trading = new HashSet<trading>();
        }
    
        public int book_id { get; set; }
        public string author { get; set; }
        public string name { get; set; }
        public string bbk { get; set; }
        public string isbn { get; set; }
        public string place { get; set; }
        public Nullable<int> year { get; set; }
        public int knowledge_field_id { get; set; }
        public int interpreter_id { get; set; }
        public Nullable<int> chamber_id { get; set; }
        public Nullable<int> trading_id { get; set; }
    
        public virtual chambers chambers { get; set; }
        public virtual fields fields { get; set; }
        public virtual interpretors interpretors { get; set; }
        public virtual quantity quantity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trading> trading { get; set; }
    }
}
