using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web2.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int GenreID { get; set; }
        public int [] ActorID { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Actor Actor { get; set; }
    }
}