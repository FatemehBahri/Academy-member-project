using GroupProject.Models;
using System.Threading.Tasks;

namespace GroupProject.Repositories.studentinterfaces
{
    public interface IStudentRepository
    {
        object Tasks { get; set; }
    
        Task<StudentModel> Get(int id);
        List<StudentModel> GetAll();
        Task<bool> Delete(int id);
        Task<bool> Update(StudentModel model);
        Task<bool> Insert(StudentModel model);
    }
}
