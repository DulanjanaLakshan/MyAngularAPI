using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAngularAPI.models;

namespace MyAngularAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie { Id = "M001", Title = "Spider Man", Description = "Sample Descriptio 01" });
            movies.Add(new Movie { Id = "M002", Title = "Iorn Man", Description = "Sample Descriptio 02" });
            movies.Add(new Movie { Id = "M003", Title = "Mr:Been", Description = "Sample Descriptio 03" });
            return movies;
        }
    }
}
