using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Domain.ApplicationService;
using Demo.Domain.Contract;
using Demo.Domain.Entittes;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class NewStudentController : Controller
    {
        IStudentFacade StudentFacade;
        public NewStudentController()
        {
            StudentFacade = new StudentFacade();
        }
        public IActionResult Index()
        {
            List<Student> data = StudentFacade.GetStudents();

            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            StudentFacade.AddStudent(student);
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            var student = StudentFacade.GetStudent(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            StudentFacade.EditStudent(student);
            return RedirectToAction("index");
        }
    }
}
