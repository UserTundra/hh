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
    
    public partial class R09_study_subjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public R09_study_subjects()
        {
            this.B03_study_subjects_to_courses = new HashSet<B03_study_subjects_to_courses>();
            this.B04_test_tasks_to_study_subjects = new HashSet<B04_test_tasks_to_study_subjects>();
        }
    
        public long code_subject { get; set; }
        public string name_subject { get; set; }
        public Nullable<long> academ_hours { get; set; }
        public string note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<B03_study_subjects_to_courses> B03_study_subjects_to_courses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<B04_test_tasks_to_study_subjects> B04_test_tasks_to_study_subjects { get; set; }
    }
}
