using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _db;
        public CartController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddToCart(int? id)
        {
            Product obj = new Product();
            IEnumerable<Product> objList = _db.Products;
            foreach (var o in objList)
            {
                if (o.Id.Equals(id))
                    return View(o);
            }

            return View();
        }
    }
}
