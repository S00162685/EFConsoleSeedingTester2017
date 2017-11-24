using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubModel
{
    [Table("Course")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseID { get; set; }
        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }
        [Display(Name = "Year")]
        public string Year { get; set; }
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
    }
}