using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models.Entities;

namespace MvcMovie.Controllers;
    public class HelloWorldController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index(HelloWorld hello) 
        {
            ViewBag.message = hello.StudentID + "-" + hello.FullName ;
            return View();
        }
        public IActionResult Demo()
        {
                return View();
        }
    }

