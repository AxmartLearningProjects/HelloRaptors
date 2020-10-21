using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HelloRaptors.Models;
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

        [HttpGet]
        public IActionResult SimpleBinding()
        {

            Player p = new Player();
            p.PlayerName = "Kyle Lowry";
            p.Position = "Guard";

            return View(p);

        }


        // The [HttpPost] attribute tells the routing engine tosend any POST request to that action method

        [HttpPost]
        public IActionResult SimpleBinding(Player raptor)
        {
            return Content(raptor.PlayerName+" updated");
        }

    }
}
