using GroupProject.Models;
using GroupProject.Repositories.Interfaces;

namespace GroupProject.Repositories.Implimentations
{
    public class TeacherRepository : ITeacherRepository
    {
        Context.Context _context;

        public TeacherRepository()
        {
            _context = new();
        }
        public bool AddTeacherInformation(TeacherModel teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteTeacherAccountByID(int teacherID)
        {
            TeacherModel deleteTeacherModel = GetTeacherInformationByID(teacherID);
            _context.Teachers.Remove(deleteTeacherModel);
            _context.SaveChanges();
            return true;
        }

        public bool EditTeacher(TeacherModel teacher)
        {
            _context.Teachers.Update(teacher);
            _context.SaveChanges();
            return true;
        }

        public List<TeacherModel> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }

        public TeacherModel GetTeacherInformationByID(int teacherID)
        {
            return _context.Teachers.FirstOrDefault(t => t.teacherID == teacherID);
        }
    }
}
