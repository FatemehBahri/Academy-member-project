using GroupProject.Models;
using GroupProject.Repositories.Implimentations;
using GroupProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace GroupProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController()
        {
            _studentRepository = new Studentrepositories();
        }

        // GET: StudentController/Details
        public ActionResult List()
        {
            List<StudentModel> studentModels = _studentRepository.GetAll();
            return View(studentModels);
        }

        // GET: StudentController/Create
       public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentModel StudentModel)
        {
            if (ModelState.IsValid)
            {
                bool result = await _studentRepository.Insert(StudentModel);
                return RedirectToAction("List", "Student");
            }
            return View();
        }

        // GET: StudentController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            StudentModel StudentModel = await _studentRepository.Get(id);
            return View(StudentModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(StudentModel StudentModel, StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                bool result = await _studentRepository.Update(StudentModel);
                return RedirectToAction("List", "Student");
            }
            StudentModel model = new StudentModel()
            {
                StudentID = StudentModel.StudentID,
                studentFristname = StudentModel.StudentLastname,
                StudentLastname = StudentModel.StudentLastname,
                Age = StudentModel.Age,
                Email = StudentModel.Email,
                phonenumber = StudentModel.phonenumber

            };

            return View(studentModel);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            StudentModel StudentModel = await _studentRepository.Get(id);
            return View(StudentModel);
        }
        // POST: StudentController/Delete/5
        [HttpPost]
        public async Task<IActionResult>Delete(StudentModel StudentModel)
        {
            bool resalt=await _studentRepository.Delete(StudentModel.StudentID);
            return RedirectToAction("List", "Student");
        }
    }
}
