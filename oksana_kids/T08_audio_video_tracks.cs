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
    
    public partial class T08_audio_video_tracks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T08_audio_video_tracks()
        {
            this.T03_testing_task_modules = new HashSet<T03_testing_task_modules>();
        }
    
        public long id_av_track { get; set; }
        public string name_av_track { get; set; }
        public Nullable<long> code_type { get; set; }
        public string author { get; set; }
        public Nullable<long> duration_sec { get; set; }
        public string source { get; set; }
        public string image_size_pix { get; set; }
        public string filesize { get; set; }
        public Nullable<long> date_create { get; set; }
        public string note { get; set; }
    
        public virtual R14_track_types R14_track_types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T03_testing_task_modules> T03_testing_task_modules { get; set; }
    }
}
