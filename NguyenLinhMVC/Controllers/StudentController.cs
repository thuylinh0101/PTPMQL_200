using Microsoft.AspNetCore.Mvc;

namespace NguyenLinhMVC.Controllers
{
    public class StudentController: Controller
    {
        public IActionResult NguyenLinh()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NguyenLinh(string Hoten)
        {
            ViewBag.Hello = "Xin chao" + Hoten;
            ViewData["Hello2"]= "Xin chao" + Hoten;
            return View();
        }

    }
}