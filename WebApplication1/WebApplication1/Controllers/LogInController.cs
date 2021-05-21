using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class LogInController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LogInController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login(User reg)//Login Varification
        {
            bool isValid = _db.User.Any(x => x.Email == reg.Email && x.Password == reg.Password);
            if (isValid) {
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.Message = "Invalid Email or Password";
                return View(reg);
            }
        }

    }
}
