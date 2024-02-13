using GroupProject.Models;
using Microsoft.EntityFrameworkCore;
using GroupProject.Repositories.Interfaces;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using GroupProject.Context;

namespace GroupProject.Repositories.Implimentations
{
    public class Studentrepositories : IStudentRepository
    {
        Context.Context db;

        public Studentrepositories()
        {
            db = new();
        }

        public async Task<bool> Delete(int id)
        {
            var data = db.Students.Find(id);
            db.Remove(data);
            db.SaveChanges();

            return true;
        }

        public async Task<StudentModel> Get(int id)
        {
            return await db.Students.SingleOrDefaultAsync(StudentModel => StudentModel.StudentID == id);
        }

        public List<StudentModel> GetAll()
        {
            var studentlist = db.Students.ToList();
            return studentlist;
        }
        public async Task<bool> Insert(StudentModel student)
        {
            
                db.Students.Add(student);
                db.SaveChanges();
                return true;
        }

        public async Task<bool> Update(StudentModel student)
        {
            db.Students.Update(student);
            db.SaveChanges();
            return true;

        }

    }
}


