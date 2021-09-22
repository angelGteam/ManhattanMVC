using ManhattanMVC.View.Models;
using ManhattanMVC.View.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManhattanMVC.View.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> movies = new List<Movie>();
        public ActionResult Random() {
            var movie = new Movie(){ Name = "Rapidos y furiosos"};
            var customers = new List<Customer>{
                new Customer{Name="C1"},
                new Customer{Name="C2"},
            };
            var viewModel = new RandomMovieViewModel{
                Movie = movie,
                customers = customers
            };
            return View(viewModel);
        }
    }
}