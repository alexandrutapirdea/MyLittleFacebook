using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLittleFacebook.Models;
using MyLittleFacebook.ViewModel;

namespace MyLittleFacebook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customers()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Shadowhunters"},
                new Movie {Name = "Jordi el nino polla"},
            };

            return View(movies);
        }

        public ActionResult Movies()
        {
            var movie = new Movie() { Name = "Shadowhunters" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Tap"},
                new Customer {Name = "John"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

        }
    }
}