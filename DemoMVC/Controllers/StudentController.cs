using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controller;
public class StudentController : Controller
{
    public IActionResult Index1()
    {
        return View();
    }
}