//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework_Linq
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.SelectedCourse = new HashSet<SelectedCourse>();
        }
    
        public string No { get; set; }
        public string Name { get; set; }
        public string Pinyin { get; set; }
        public string PreCourseNo { get; set; }
        public decimal Credit { get; set; }
        public string StudyType { get; set; }
        public string ExamType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelectedCourse> SelectedCourse { get; set; }
    }
}