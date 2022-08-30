using MusicStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Product> objList = _db.Products;
            return View(objList);
        }

        public IActionResult Details(int id)
        {
            var categories = _db.Categories.OrderBy(x => x.Id).ToList();
            Product product = _db.Products.Find(id);
            var categoryName = "";
            var genreName = "";
            var artistName = "";
            foreach (var category in categories)
            {
                if (category.Id == product.CategoryId) categoryName = category.Name;
            }

            string imageFileName = product.Code + ".jpg";
            ViewBag.CategoryName = categoryName;
            ViewBag.GenreName = genreName;
            ViewBag.ArtistName = artistName;
            ViewBag.ImageFileName = imageFileName;
            return View(product);
        }

        //id ovdje prestavlja kategoriju
        public IActionResult List(string id = "All")
        {
            var categories = _db.Categories.OrderBy(x => x.Id).ToList();
            List<Product> products;
            if (id == "All")
            {
                products = _db.Products.OrderBy(x => x.Id).ToList();
            }
            else
            {
                products = _db.Products.Where(x => x.Category.Name == id).OrderBy(x => x.Id).ToList();
            }

            ViewBag.SelectedCategoryName = id;
            ViewBag.AllCategories = categories;
            return View(products);
        }

    }
}
