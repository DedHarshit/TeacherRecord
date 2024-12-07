using Microsoft.AspNetCore.Mvc;
using TeacherRecord.Data;
using TeacherRecord.Models;

namespace TeacherRecord.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TeacherController(ApplicationDbContext db)
        {
            _db = db;
        }

       
        public IActionResult Index()
        {
            List<Teacher> _objTeacher = _db.Teachers.ToList();
            return View(_objTeacher);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Teacher obj )
        {
            _db.Teachers.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
