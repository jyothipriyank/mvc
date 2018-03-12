using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMvCApplication.ViewModel
{
    public class RandomMovieViewmModel
    {
        public Models.Movie Movie { get; set; }
        public List<Models.Customer> Customers { get; set; }
    }
}