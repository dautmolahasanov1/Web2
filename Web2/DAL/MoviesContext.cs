using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Web2.DAL
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() : base("SchoolContext")
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}