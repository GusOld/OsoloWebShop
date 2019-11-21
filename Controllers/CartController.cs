using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OsoloWebShop.Helpers;
using OsoloWebShop.Models;

namespace OsoloWebShop.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        private readonly DataContext _context;

        public CartController(DataContext context)
        {
            _context = context;
        }

        [Route("index")]
        public ActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart?.Sum(item => item.Product.Price * item.Quantity);
            return View();
        }

        //Adds items to the "Cart" session and stacks Quantity if it already exists

        [Route("buy")]
        public ActionResult Buy(string id)
        {
            ProductList productList = new ProductList();

            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = productList.GetProduct(id), ProductName = productList.GetProduct(id).Name, Quantity = 1 });
                SessionHelper.SetObjectAsJSon(HttpContext.Session, "cart", cart);
            }

            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = _locateItem(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    var numOfItems = cart.Count<Item>();
                    cart.Add(new Item { Product = productList.GetProduct(id), ProductName = productList.GetProduct(id).Name, Quantity = 1 });
                }

                SessionHelper.SetObjectAsJSon(HttpContext.Session, "cart", cart);
            }

            return RedirectToAction("Index", "Home");
        }

        //Removes items from "Cart" session

        [Route("remove/{id}")]
        public IActionResult Remove(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = _locateItem(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJSon(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        
        //Stores all data i the database 

        [Route("add")]
        [HttpPost]
        public IActionResult Add()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                return RedirectToAction("Index");
            }
            
            var order = new Order()
            {
                Products = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart"),
                Price = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart").Sum(item => item.Product.Price * item.Quantity)
            };

            foreach(var obj in order.Products)
            {
                _context.Products.Add(obj.Product);
                _context.Items.Add(obj);
            }

            _context.Orders.Add(order);
            _context.SaveChanges();

            return RedirectToAction("Checkout", new { orderId = order.OrderId });
        }

        //Gets the item-table and total price for presentation

        [Route("Checkout")]
        [HttpGet]
        public ActionResult Checkout(int orderId)
        {
            ViewBag.cart = _context.Items.Where(i => i.OrderId == orderId).ToList();
            ViewBag.total = _context.Orders.Find(orderId).Price;
            ViewBag.orderID = orderId;

            return View();
        }
        
        //Checks the Cart for items with given id and returns its Index 

        private int _locateItem(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductNumber.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }


    }
}