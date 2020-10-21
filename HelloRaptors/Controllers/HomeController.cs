using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloRaptors.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Models.Raptors player = new Models.Raptors() { PlayerName = "Kyle Lowry", ArrivalDate = new DateTime(2012,3,24) };

            return View(player);
        }

        [HttpGet]
        public IActionResult Edit()
        {


            return Content("Edit");
        }



    }
}
