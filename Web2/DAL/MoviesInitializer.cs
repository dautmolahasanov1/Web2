using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Web2.Models;

namespace Web2.DAL
{
    public class MoviesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MoviesContext>
    {
        protected override void Seed(MoviesContext context)
        {
            var Actors = new List<Actor>
            {
            new Actor{ActorID=1,FirstName="Matt",LastName="Damon"},
            new Actor{ActorID=2,FirstName="Christian",LastName="Bale"},
            new Actor{ActorID=3,FirstName="Leaonardo",LastName="DiCaprio"},
            new Actor{ActorID=4,FirstName="Tim",LastName="Robbins"},
            new Actor{ActorID=5,FirstName="Morgan",LastName="Freeman"},
            new Actor{ActorID=6,FirstName="Kate",LastName="Winslet"},
            new Actor{ActorID=7,FirstName="John",LastName="Travolta"},
            new Actor{ActorID=8,FirstName="Samuel",LastName="Jackson"},
            new Actor{ActorID=9,FirstName="Uma",LastName="Thurman"},
            new Actor{ActorID=10,FirstName="Harrison",LastName="Ford"},
            new Actor{ActorID=11,FirstName="Kate",LastName="Capshaw"},
            new Actor{ActorID=12,FirstName="Keanu",LastName="Reeves"},
            new Actor{ActorID=13,FirstName="Keanu",LastName="Reeves"},
            new Actor{ActorID=14,FirstName="Russell",LastName="Crowe"},
            new Actor{ActorID=15,FirstName="Matthew",LastName="McConaughey"}
            };

            Actors.ForEach(s => context.Actors.Add(s));
            context.SaveChanges();
            var Genres = new List<Genre>
            {
            new Genre{GenreID=1,Title="Thriller",},
            new Genre{GenreID=2,Title="Horror",},
            new Genre{GenreID=3,Title="Drama",},
            new Genre{GenreID=4,Title="Comedy",},
            new Genre{GenreID=5,Title="Criminal",},
            new Genre{GenreID=6,Title="Action",},
            new Genre{GenreID=7,Title="Fantasy",}
            };
            Genres.ForEach(s => context.Genres.Add(s));
            context.SaveChanges();
            var Movies = new List<Movie>
            {
            new Movie{Title="The Shawshank Redemption",ActorID=new int[] {4,5},GenreID=3,},
            new Movie{Title="Titanic",ActorID=new int[] {3,6 },GenreID=3,},
            new Movie{Title="Ford vs Ferrari",ActorID=new int[] {1,2 },GenreID=6,},
            new Movie{Title="Indiana Johnes",ActorID=new int[] {10,11},GenreID=6,},
            new Movie{Title="The Dark Knight",ActorID=new int[] {2 },GenreID=4,},
            new Movie{Title="The Matrix",ActorID=new int[] {12},GenreID=6,},
            new Movie{Title="Pulp Fiction",ActorID=new int[] {7,8,9},GenreID=1,},
            new Movie{Title="Shutter Island",ActorID=new int[] {3},GenreID=1,},
            new Movie{Title="Beautiful Mind",ActorID=new int[] {14},GenreID=3,},
            new Movie{Title="Interstellar",ActorID=new int[] {15},GenreID=7,},
            };
            Movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();
        }
    }
}