using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvcMovie.Data;
using MvcMovie.Models.Entities;
namespace  MvcMovie.Controllers;

    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customer.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer cus)
        {
            try{
               if(ModelState.IsValid){
                _context.Customer.Add(cus);
                await _context.SaveChangesAsync();
            return  RedirectToAction("Index");
            }  
            }
            catch(Exception ex ){
                return BadRequest("Đã xảy ra lỗi :"+ex.Message);
            }         
            return View(cus);
        }

    }
