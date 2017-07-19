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
        // Get: movies/Index or Movies/
        public ActionResult Index()
        {
            var movies = new List<Movie>();
            movies.Add(new Movie { ID = 1, Name = "Shrek!" });
            movies.Add(new Movie { ID = 2, Name = "Avengers" });

            var moviesList = new Movies()
            {
                MoviesList = movies
            };



            return View(moviesList);
        }

        public ActionResult Detail(int id)
        {
            if (id > 2)
                return HttpNotFound("Id not found!");
            return Content("id="+id);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {ID=1,Name = "Shrek!" };
            return View(movie);
        }
    }
}