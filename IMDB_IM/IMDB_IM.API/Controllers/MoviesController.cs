using IMDB_IM.API.Interfaces;
using IMDB_IM.Model.Movies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IMDB_IM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovies _moviesService;
        public MoviesController(IMovies movies)
        {
            _moviesService = movies;
        }


        [HttpGet]
        public IActionResult Get([FromQuery]MoviesSearchRequest request)
        {
            var res = _moviesService.Get(request);
            var metadata = new
            {
               res.TotalCount,
               res.PageSize,
               res.CurrentPage,
               res.HasNext,
               res.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            return Ok(res);
        }
    }
}
