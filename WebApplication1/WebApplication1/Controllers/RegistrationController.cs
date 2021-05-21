using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RegistrationController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(User reg)
        {
            if (ModelState.IsValid)
            {
                _db.User.Add(reg);
                _db.SaveChanges();
                return RedirectToAction("LogIn", "login");
            }
            return View(reg);
        }
    }
}
