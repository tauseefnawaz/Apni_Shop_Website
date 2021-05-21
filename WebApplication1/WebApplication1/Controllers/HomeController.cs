using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }


        //private readonly UserManager<ApplicationDbContext> UserManager;
        public IActionResult Index()
        {
            IEnumerable<Product> Products = _db.Products;
            return View(Products);
        }
        [HttpGet]
        public IActionResult Index(string Name)
        {
            IEnumerable<Product> Products = _db.Products.Where(x => x.title.Contains(Name) || Name == null).ToList();
            return View(Products);
        }
        public IActionResult categories(String categories)
        {
            IEnumerable<Product> Products = _db.Products.Where(x => x.Type.Contains(categories) || categories == null).ToList();
            return View(Products);
        }
        [Route("book-details/{id:int:min(0)}", Name = "bookDetailsRoute")]
        public async Task<ViewResult> ProductDetailAsync(int id)
        {
            var product = await GetProductById(id);
            var user = _db.User.FirstOrDefault(x => x.UserId == product.userId);
            var data = new MultipleData();
            data.product = product;
            data.user = user;
            return View(data);
        }
        public IActionResult Privacy()
        {

            return View();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _db.Products.Where(x => x.productId == id)
                 .Select(product => new Product()
                 {
                     condition = product.condition,
                     Type = product.Type,
                     title = product.title,
                     Description = product.Description,
                     price = product.price,
                     ImageName = product.ImageName,
                     userId = product.userId
                 }).FirstOrDefaultAsync();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
