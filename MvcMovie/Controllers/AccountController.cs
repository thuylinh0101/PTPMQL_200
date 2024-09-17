using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models.Entities;

namespace MvcMovie.Controllers;
    public class AccountController: Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }

 