using Movies.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.ApiServices
{
    public interface IMoviesApiService
    {

        Task<IEnumerable<Movie>> GetMovies();
        //Task<Movie> GetMovie(string id);
        //Task<Movie> CreateMovie(Movie movie);
        //Task<Movie> UpdateMovie(Movie movie);
        //Task DeleteMovie(int id);
    }
}
