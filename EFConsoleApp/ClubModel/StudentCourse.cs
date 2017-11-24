using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubModel
{
    [Table("StudentCourse")]
    public class StudentCourse
    {
        [Key, Column(Order = 1)]
        [Display(Name = "Course ID")]
        public string CourseID { get; set; }

        [Key, Column(Order = 2)]
        [Display(Name = "Student ID")]
        public string StudentID { get; set; }
        public virtual Course course { get; set; }
        public virtual Student student { get; set; }
    }
}