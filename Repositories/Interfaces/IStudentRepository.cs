using GroupProject.Models;

namespace GroupProject.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Task<StudentModel> Get(int id);
        List<StudentModel> GetAll();
        Task<bool> Delete(int id);
        Task<bool> Update(StudentModel student);
        Task<bool> Insert(StudentModel student);
    }
}
