using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Proy1.Shared.Entity
{
    public class Movie
    {
        public int Id{get;set;}
        [Required]
        public string Name{get;set;}
        public string Sinopsis{get;set;}
        public string Poster{get;set;}
        public string Trailer{get;set;}
        public int Score{get;set;}
        [Required]
        public DateTime? Premier{get;set;}
        public List<CategoryMovie> CategoryMovie {get;set;} = new List<CategoryMovie> ();
        public List<ActorMovie> ActorMovie {get;set;} = new List<ActorMovie> ();
    }
}