using Project4_EntityFrameworkCodeFirstMovie.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFrameworkCodeFirstMovie.DAL.Context
{
    public class MovieContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}
