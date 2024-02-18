using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GroupProject.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentID { get; set; }
        [Display(Name = "Student Fristname")]
        [Required(ErrorMessage ="Please Enter {0}")]
        public string studentFristname { get; set; }
        [Display(Name = "Student Lastnamee")]
        [Required(ErrorMessage = "Please Enter {0}")]
        public string StudentLastname { get; set; }
        [Display(Name = "Age")]
        [Required(ErrorMessage = "Please Enter {0}")]
        public int Age { get; set; }
        [DisplayFormat(DataFormatString = "{0:###-###-####}")]
        public string? phonenumber { get; set; }
        [EmailAddress(ErrorMessage = "The Email field is not a valid email address.")]
        public string? Email { get; set; }


    }
}
