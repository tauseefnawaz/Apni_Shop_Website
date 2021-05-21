using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment WebHostEnvirnment;

        public ProductController(ApplicationDbContext db, IWebHostEnvironment webHostEnvirnment)
        {
            _db = db;
            WebHostEnvirnment = webHostEnvirnment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Product ProdObj)
        {
            if (ModelState.IsValid)
            {
                string FileName = UploadImage(ProdObj);

                var product = new Product();
                product.condition = ProdObj.condition;
                product.Type = ProdObj.Type;
                product.title = ProdObj.title;
                product.Description = ProdObj.Description;
                product.price = ProdObj.price;
                product.ImageName = FileName;
                User user = new User();
                user = _db.User.FirstOrDefault(x => x.PhoneNumber==ProdObj.PhoneNumber);
                product.userId = user.UserId;
                product.user = user;
                _db.Products.Add(product);
                _db.SaveChanges();
                ViewBag.SuccessMessage = "Product is Added";
                return RedirectToAction("Index");
            }
            
            return View(ProdObj);        
        }
        private string UploadImage(Product prodObj)
        {
            string fileName = null;
            if (prodObj.ImageFile != null)
            {
                string ImgDir = Path.Combine(WebHostEnvirnment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + "-" + prodObj.ImageFile.FileName;
                string filePath = Path.Combine(ImgDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    prodObj.ImageFile.CopyTo(fileStream);
                }
            }
            return fileName;
        }

    }
}
