using Proy1.Shared.Entity;
using System.Collections.Generic;
using System;

namespace Proy1.Client.Services
{
    public class ServiceMovie:IServiceMovie
    {
        
        public List<Movie> GetMovies(){
            return new List<Movie>(){
                    new Movie(){Id=1 ,Name="movie One",Sinopsis="Description movie One",Poster="/images/movies/1.jpg",Score=100, Premier = new DateTime(2021,09,24)},
                    new Movie(){Id=2 ,Name="movie Two",Sinopsis="Description movie Two",Poster="/images/movies/1.jpg",Score=100, Premier = new DateTime(2021,09,24)},
                    new Movie(){Id=3 ,Name="movie Trhee",Sinopsis="Description movie Trhee",Poster="/images/movies/1.jpg",Score=100, Premier = new DateTime(2021,09,24)},
                    new Movie(){Id=4 ,Name="movie Four",Sinopsis="Description movie Four",Poster="/images/movies/1.jpg",Score=100, Premier = new DateTime(2021,09,24)},
                    new Movie(){Id=5 ,Name="movie Five",Sinopsis="Description movie Five",Poster="/images/movies/1.jpg",Score=100, Premier = new DateTime(2021,09,24)},
                    new Movie(){Id=6 ,Name="movie Six",Sinopsis="Description movie Six",Poster="/images/movies/1.jpg",Score=100, Premier = new DateTime(2021,09,24)},
            };
        }
    }
}