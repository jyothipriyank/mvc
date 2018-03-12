using MyMvCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvCApplication.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        [Route("Movie/Index")]
        public ActionResult Index()
        {
            ViewModel.RandomMovieViewmModel model = new ViewModel.RandomMovieViewmModel
            {
                Movie = new Movie { Id = 1, Name = "NameOftheMovieIsMovie" },
               // Customers = new List<Customer> { new Customer { Id = 1, Name = "Customer1" }, new Customer { Id = 2, Name = "Customer2" } }
            };
            //Movie movie2 = new Movie { Id = 1, Name = "Movie2" };
            //Movie movie3 = new Movie { Id = 1, Name = "Movie3" };
           // ViewData["movie"] = movie;
            return View(model);
        }
    }
}