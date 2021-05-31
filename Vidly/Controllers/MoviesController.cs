using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name = "John"},
                new Customer { Name = "Jim"},
                new Customer { Name = "Jack"},
                new Customer { Name = "Tam"},
                new Customer { Name = "Jimmy"},
                new Customer { Name = "Dross"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

        }

        //Get: Movies/
        public ActionResult Index()
        {
       
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id=1, Name = "Shrek" },
                new Movie { Id=2, Name = "Lord of the Rings" },
                new Movie { Id=3, Name = "Wall-e" }
            };
        }

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleaseYear(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}


        //public ActionResult Edit (int id)
        //{
        //    return Content("Id = " + id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;


        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}


// Example of other action results: 

//return Content("Hello World");
//return HttpNotFound();
//return new EmptyResult();
//return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

// Quick way to create an action. Type "mvcaction4" and press the tab key