using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Models;
using Demo.Domain.Contract;
using Demo.Domain.ApplicationService;
using Demo.Domain.Entittes;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        IStudentFacade StudentFacade;
        public HomeController()
        {
            StudentFacade = new StudentFacade();
        }
        public IActionResult Index()
        {
            ViewBag.data = StudentFacade.GetStudents();
            return View();
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
            ViewBag.student= StudentFacade.GetStudent(id);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            StudentFacade.EditStudent(student);
            return RedirectToAction("index");
        }

    }
}
