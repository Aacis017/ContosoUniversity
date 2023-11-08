using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstMidName { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }

        [ValidateNever]

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
