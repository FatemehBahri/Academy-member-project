using GroupProject.Models;
using GroupProject.Repositories.Implimentations;
using GroupProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GroupProject.Controllers
{
    public class TeacherController : Controller
    {
        ITeacherRepository _teacherRepository;
        TeacherController()
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
        public IActionResult Create(string _teacherFistName, string _teacherLastName, string _teacherNationalCode, string _teacherTeachingArea)
        {
            TeacherModel model = new TeacherModel()
            {
                teacherFistName = _teacherFistName,
                teacherLastName = _teacherLastName,
                teacherNationalCode = _teacherNationalCode,
                teacherTeachingArea = _teacherTeachingArea
            };
            if (_teacherRepository.AddTeacherInformation(model))
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
        public IActionResult Edit(string _teacherFistName, string _teacherLastName, string _teacherNationalCode, string _teacherTeachingArea, int _teacherID)
        {
            TeacherModel model = new TeacherModel()
            {
                teacherID = _teacherID,
                teacherFistName = _teacherFistName,
                teacherLastName = _teacherLastName,
                teacherNationalCode = _teacherNationalCode,
                teacherTeachingArea = _teacherTeachingArea
            };
            if (_teacherRepository.EditTeacher(model))
            {
                return RedirectToAction("List");
            }
            else
            {
                TeacherModel BackModel = new TeacherModel()
                {
                    teacherID = _teacherID,
                    teacherFistName = _teacherFistName,
                    teacherLastName = _teacherLastName,
                    teacherNationalCode = _teacherNationalCode,
                    teacherTeachingArea = _teacherTeachingArea
                };
                return View(BackModel);
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
