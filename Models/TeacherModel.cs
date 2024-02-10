namespace GroupProject.Models
{
    public class TeacherModel
    {
        public int teacherID { get; set; }
        public string? teacherFistName { get; set; } = "Not Set";
        public string? teacherLastName { get; set; } = "Not Set";
        public string? teacherNationalCode { get; set; } = "Not Set";
        public byte teacherTeachingArea { get; set; }
    }
}
