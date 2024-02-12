using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentID { get; set; }
        public string studentFristname { get; set; }
        public string StudentLastname { get; set; }
        public int Age { get; set; }
        public int phonenumber { get; set; }
        public string Email { get; set; }


    }
}
