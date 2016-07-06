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
        List<Movie> movies = new List<Movie>
        {
             new Movie{Name = "Shrek!", Id = 0},
             new Movie{Name = "Finding Dori", Id = 1}
        };

        // GET: Movies
        public ActionResult Index()
        {
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            if (id >= 0 && id < movies.Count)
                return View(movies[id]);
            else
                return HttpNotFound();
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{Name = "Customer 1"},
                new Customer{Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}