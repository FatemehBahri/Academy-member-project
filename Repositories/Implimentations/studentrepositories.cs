using GroupProject.Models;
using System.Threading.Tasks;
using GroupProject.Controllers;
using GroupProject.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GroupProject.Repositories.Interfaces;

namespace GroupProject.Repositories.Implimentations
{
    public class studentrepositories : IStudentRepository
    {
        private Context.Context db;
        public studentrepositories(Context.Context context)
        {
            db = context;
        }

        public object Tasks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task<bool> Delete(int id)
        {
            StudentModel StudentModel = new StudentModel();

            db.Remove(StudentModel);
            db.SaveChanges();

            return true;
        }

        public async Task<StudentModel> Get(int id)
        {
            return await db.Students.SingleOrDefaultAsync(StudentModel => StudentModel.StudentID == id);
        }

        public List<StudentModel> GetAll()
        {
            return db.Students.ToList();
        }
        public async Task<bool> Insert(StudentModel model)
        {
            StudentModel studentModel = new StudentModel()
            {
                StudentID = model.StudentID,
                studentFristname = model.studentFristname,
                StudentLastname = model.StudentLastname,
                Age = model.Age,
                phonenumber = model.phonenumber,
                Email = model.Email,
            };

            db.Students.Add(studentModel);
            db.SaveChanges();

            return true;
        }

        public async Task<bool> Update(StudentModel model)
        {
            StudentModel StudentModel = new StudentModel();
            StudentModel.StudentID = model.StudentID;
            StudentModel.studentFristname = model.studentFristname;
            StudentModel.StudentLastname = model.StudentLastname;
            StudentModel.Age = model.Age;
            StudentModel.phonenumber = model.phonenumber;
            StudentModel.Email = model.Email;




            db.Students.Add(StudentModel);
            db.SaveChanges();
            return true;
        }



    }

}
