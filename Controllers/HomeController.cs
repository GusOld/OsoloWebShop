using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OsoloWebShop.Helpers;
using OsoloWebShop.Models;

namespace OsoloWebShop.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ProductList productList = new ProductList();
            ViewBag.productList = productList.GetAllProducts();

            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;

            return View();
        }
    }
}
