using appDemo2.Data;
using appDemo2.Models;
using Microsoft.AspNetCore.Mvc;

namespace appDemo2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var result = StaticDb.Students;
            return View(result);
        }
        public IActionResult CreateStudent()
        {
            var emptyStudent = new StudentViewModel();
            return View(emptyStudent);
        }
        [HttpPost]
        public IActionResult CreateStudent(StudentViewModel model)
        {
            model.Id = StaticDb.Students.Max(x => x.Id)+ 1;
            StaticDb.Students.Add(model);
            return RedirectToAction("Index");
        }
    }
}
