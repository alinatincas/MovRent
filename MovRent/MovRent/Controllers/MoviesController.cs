using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovRent.Models;

namespace MovRent.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            // Create an instance of our MovieModel
            var movie = new Movie() { Name = "Cinderella"}
            return View();
        }
    }
}