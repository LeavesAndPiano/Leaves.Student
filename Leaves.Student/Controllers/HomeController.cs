using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//
using Leaves.Student.Models;
using Leaves.Student.ViewModels;

namespace Leaves.Student.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Leaves.Student.Models.Student> students = _studentRepository.GetAllStudents();

            return View(students);

        }

        public IActionResult Details(int? id)
        {

            //实例化HomeDetailsViewModel并存储Student详细信息和PageTitle
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Student = _studentRepository.GetStudent(id ?? 1),
                PageTitle = "学生详细信息"
            };
            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create(int? id)
        {
            Leaves.Student.Models.Student student = _studentRepository.GetStudent(id ?? 0);
            return View(student);
        }

        public void Delete(int id)
        { 
            _studentRepository.Delete(id);
            RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Create(Leaves.Student.Models.Student student)
        {
            Leaves.Student.Models.Student newStudent = new Models.Student();
            if (student.Id==0)
            {
                newStudent = _studentRepository.Add(student);
            }
            else
            {
                newStudent = _studentRepository.Update(student);
            } 
            if (ModelState.IsValid)
            {
               return RedirectToActionPermanent("Details",new { id= newStudent.Id });
                
            }
            else
            {
                return View();
            }
           
        }

    }
}