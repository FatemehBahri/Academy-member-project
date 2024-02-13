using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class TeacherModel
    {
        #region Teacher Parameter
        [Key]
        public int teacherID { get; set; }
        public string teacherFistName { get; set; } = "Not Set";
        public string teacherLastName { get; set; } = "Not Set";
        public string teacherNationalCode { get; set; } = "Not Set";
        public string teacherTeachingArea { get; set; }

        #endregion
    }
}
