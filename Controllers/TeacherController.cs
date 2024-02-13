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
            List<TeacherModel> model = _teacherRepository.GetAllTeachers();
            return View(model);
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
        public IActionResult Edit(int ID)
        {
            TeacherModel model = _teacherRepository.GetTeacherInformationByID(ID);
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
        public IActionResult Delete(int ID)
        {
            _teacherRepository.DeleteTeacherAccountByID(ID);
            return RedirectToAction("List");
        }
        #endregion

    }
}
