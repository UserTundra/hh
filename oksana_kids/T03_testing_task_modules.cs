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
    
    public partial class T03_testing_task_modules
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T03_testing_task_modules()
        {
            this.B05_testing_task_modules_to_tests = new HashSet<B05_testing_task_modules_to_tests>();
        }
    
        public long id_module { get; set; }
        public Nullable<long> id_track { get; set; }
        public Nullable<long> id_av_track { get; set; }
        public Nullable<long> code_instruction { get; set; }
        public Nullable<long> id_task { get; set; }
        public Nullable<long> code_variant { get; set; }
        public Nullable<long> id_comment { get; set; }
        public Nullable<long> comment_view_duration_sec { get; set; }
        public Nullable<long> max_passing_duration_sec { get; set; }
        public Nullable<long> code_action { get; set; }
        public string note { get; set; }
        public Nullable<long> additional_teaching_material { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<B05_testing_task_modules_to_tests> B05_testing_task_modules_to_tests { get; set; }
        public virtual R10_next_action_variants R10_next_action_variants { get; set; }
        public virtual R11_variants_of_passing_tasks_results_analysis R11_variants_of_passing_tasks_results_analysis { get; set; }
        public virtual R12_instructions_to_test_tasks_types R12_instructions_to_test_tasks_types { get; set; }
        public virtual T07_soundtracks T07_soundtracks { get; set; }
        public virtual T04_testing_tasks T04_testing_tasks { get; set; }
        public virtual T08_audio_video_tracks T08_audio_video_tracks { get; set; }
        public virtual T09_comment_variants_on_passing_tasks T09_comment_variants_on_passing_tasks { get; set; }
    }
}
