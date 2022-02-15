using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieEticket.Models
{
    public class Actor_Movie
    {
        public int MoviesssId { get; set; }
        public Movies Movie { get; set; }


        public int ActorsssId { get; set; }
        public Actor Actors { get; set; }
       
        



    }
}
