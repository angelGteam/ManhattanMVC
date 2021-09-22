using ManhattanMVC.View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManhattanMVC.View.ViewModels {
    public class RandomMovieViewModel {
        public Movie Movie { get; set; }
        public List<Customer> customers { get; set; }
    }
}