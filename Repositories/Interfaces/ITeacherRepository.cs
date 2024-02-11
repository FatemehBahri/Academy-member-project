using GroupProject.Models;
namespace GroupProject.Repositories.Interfaces
{
    public interface ITeacherRepository
    {
        bool AddTeacherInformation(TeacherModel teacher);
        bool DeleteTeacherAccountByID(int teacherID);
        List<TeacherModel> GetAllTeachers();
        TeacherModel GetTeacherInformationByID(int teacherID);
        bool EditTeacher(TeacherModel teacher);
    }
}
