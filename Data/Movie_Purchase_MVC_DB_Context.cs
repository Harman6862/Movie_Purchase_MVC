using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie_Purchase_MVC.Models;

namespace Movie_Purchase_MVC.Data
{
    public class Movie_Purchase_MVC_DB_Context : DbContext
    {
        public Movie_Purchase_MVC_DB_Context (DbContextOptions<Movie_Purchase_MVC_DB_Context> options)
            : base(options)
        {
        }

        public DbSet<Movie_Purchase_MVC.Models.Movie> Movie { get; set; }

        public DbSet<Movie_Purchase_MVC.Models.Customer> Customer { get; set; }

        public DbSet<Movie_Purchase_MVC.Models.MovieRent> MovieRent { get; set; }
    }
}
