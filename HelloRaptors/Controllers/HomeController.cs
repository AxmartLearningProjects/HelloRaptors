using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HelloRaptors.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HelloRaptors.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Models.Raptors player = new Models.Raptors() { PlayerName = "Kyle Lowry", ArrivalDate = new DateTime(2012,3,24) };

            //return View(player);


            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));

            if (!HttpContext.Request.Cookies.ContainsKey("first_Request"))
            {
                HttpContext.Response.Cookies.Append("first_Request", DateTime.Now.ToString(), cookieOptions);
                return Content("Wellcome new visitor");
            }
            else
            {
                DateTime firstRequest = DateTime.Parse(HttpContext.Request.Cookies["first_Request"]);

                return Content("Wellcome back user! You first visited us on " + firstRequest.ToString());
            }


            
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
            if (ModelState.IsValid)
            {
                return Content(raptor.PlayerName + " updated");
            }
            else
            {
                return View(raptor);
            }
            
            
            
            
        }


        public IActionResult QueryTest()
        {

            string name = "Paskal Siakim";

            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
            {

                name = HttpContext.Request.Query["name"];

            }

            return Content("Name from query string is " + name);

        }

    }
}
