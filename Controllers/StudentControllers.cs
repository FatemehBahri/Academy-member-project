using GroupProject.Models;
using GroupProject.Repositories.studentinterfaces;
using Microsoft.AspNetCore.Mvc;

namespace GroupProject.Controllers
{
    public class StudentControllers
    {
        public class StudentController : Controller
        {
            private IStudentRepository _studentRepository;
            public StudentController(IStudentRepository studentRepository)
            {
                _studentRepository = studentRepository;
            }

            public IActionResult Index()
            {
                return View();
            }

            // GET: StudentController/Details
            public ActionResult lists()
            {
                List<StudentModel> lists = _studentRepository.GetAll();
                return View(lists);
            }

            // GET: StudentController/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: StudentController/Create
            [HttpPost]
            public async Task<IActionResult> Create(StudentModel StudentModel)
            {
                bool result = await _studentRepository.Insert(StudentModel);
                if (result)
                {
                    return RedirectToAction("lists", "model");
                }
                else
                {
                    return View();
                }
            }

            // GET: StudentController/Edit/5
            public async Task<IActionResult> Edit(int id)
            {
                StudentModel StudentModel = await _studentRepository.Get(id);

                return View(StudentModel);
            }

            public Task<IActionResult> Edit(StudentModel StudentModel)
            {
                return Edit(StudentModel, StudentModel);
            }

            // POST: StudentController/Edit/5
            [HttpPost]
            public async Task<IActionResult> Edit(StudentModel StudentModel, StudentModel studentModel)
            {
                bool result = await _studentRepository.Update(StudentModel);
                if (result)
                {
                    return RedirectToAction("lists", "model");
                }
                else
                {
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
            }

            // POST: StudentController/Delete/5
            [HttpPost]
            public async Task<IActionResult> Delete(int id)
            {
                _studentRepository.Delete(id);
                return RedirectToAction("lists", "model");
            }
        }
    }
}
