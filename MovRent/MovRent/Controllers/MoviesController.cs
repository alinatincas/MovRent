using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovRent.Models;
using MovRent.ViewModel;

namespace MovRent.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            // Create an instance of our MovieModel
            var movie = new Movie() { Name = "Cinderella" };
            var customers = new List<Customer> //create list customers
            {
                new Customer { Name = "Customer1"},
                new Customer { Name = "Customer2"}
            };

            //create view model object
            var viewModel = new RandomMovieViewModel {
                Movie = movie,
                Customers = customers      
            };

            return View(viewModel);
        }

        

        //[Route("movies/released/{year}/{month:regex(\\d{2}:range(1, 12)}")] //regex- regular expression

        public ActionResult ByReleaseDate(int year, int month) //this action takes 2 param, year, month
        {
            return Content(year + "/" + month);
        }
    }
}




//// MVC maps requests data to parameters our actions
//public ActionResult Edit(int id)
//{
//    return Content("id=" + id);
//}

//// optional param in pur actions
//// action called when we navigate to movies
//// return view with list of movies in the DB
//public ActionResult Index(int? pageIndex, string sortBy) 
//{
//    if (!pageIndex.HasValue)
//        pageIndex = 1;
//    if (string.IsNullOrWhiteSpace(sortBy))
//        sortBy = "Name";

//    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
//}
