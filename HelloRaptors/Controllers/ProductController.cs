using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloRaptors.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloRaptors.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details()
        {

            Product product = new Product();
            product.Title = "BasketBall";
            product.Price = 19.99;

            return View(product);
        }
    }
}
