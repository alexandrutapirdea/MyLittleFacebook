using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MyLittleFacebook.Models;

namespace MyLittleFacebook.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shadowhunters"};

//            return View(movie);
            return HttpNotFound();
        }

        public ActionResult Index(int? cm, string Name)
        {
            if (!cm.HasValue)
                cm = 15;
            if (String.IsNullOrWhiteSpace(Name))
                Name = "JohnG";

            return Content("Hello");
        }
    }
}
