using Proy1.Shared.Entity;
using System.Collections.Generic;
using System;

namespace Proy1.Client.Services
{
    public interface IServiceMovie
    {
         List <Movie> GetMovies();
    }
}