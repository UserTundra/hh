//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace oksana_kids
{
    using System;
    using System.Collections.Generic;
    
    public partial class T10_organizations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T10_organizations()
        {
            this.T01_personalities = new HashSet<T01_personalities>();
        }
    
        public long id_org { get; set; }
        public string full_name { get; set; }
        public string short_name { get; set; }
        public Nullable<long> code_ownership { get; set; }
        public string address { get; set; }
        public string contact_info { get; set; }
        public string web_site { get; set; }
        public string note { get; set; }
    
        public virtual R05_legal_ownership_forms R05_legal_ownership_forms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T01_personalities> T01_personalities { get; set; }
    }
}
