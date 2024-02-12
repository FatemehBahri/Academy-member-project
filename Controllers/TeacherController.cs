using GroupProject.Models;
using GroupProject.Repositories.Implimentations;
using GroupProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GroupProject.Controllers
{
    public class TeacherController : Controller
    {
        ITeacherRepository _teacherRepository;
        public TeacherController()
        {
            _teacherRepository = new TeacherRepository();
        }
        #region List Action
        public IActionResult List()
        {
            // List<TeacherModel> model = _teacherRepository.GetAllTeachers();
            return View();
        }
        #endregion

        #region Create Action
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TeacherModel teacher)
        {
            if (_teacherRepository.AddTeacherInformation(teacher))
            {
                return RedirectToAction("List");
            }
            else
            {
                return View();
            }
        }
        #endregion

        #region Edit Action
        public IActionResult Edit(int teacherId)
        {
            TeacherModel model = _teacherRepository.GetTeacherInformationByID(teacherId);

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(TeacherModel teacher)
        {
            if (_teacherRepository.EditTeacher(teacher))
            {
                return RedirectToAction("List");
            }
            else
            {
                return View(teacher);
            }
        }
        #endregion

        #region Delete Action
        public IActionResult Delete(int _teacherId)
        {
            _teacherRepository.DeleteTeacherAccountByID(_teacherId);
            return RedirectToAction("List");
        }
        #endregion

    }
}
