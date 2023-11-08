using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
      
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        [ValidateNever]

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
