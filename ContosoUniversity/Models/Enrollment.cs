using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
  
    
        public enum Grade
        {
            A, B, C, D, F
        }

        public class Enrollment
        {
            public int Id { get; set; }

        //pk of course table
            public int CourseID { get; set; }

        //pk of studednt table
            public int StudentID { get; set; }
            public Grade Grade { get; set; }
        /// <summary>
        /// automatically sets 
        /// </summary>
        [ValidateNever]
            public virtual Course Course { get; set; } // proxy  data
        [ValidateNever]
        public virtual Student Student { get; set;  }
        }
    
}
