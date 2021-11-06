using IMDB_IM.API.Interfaces;
using IMDB_IM.Model.Ratings;
using Microsoft.AspNetCore.Mvc;

namespace IMDB_IM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly IRating _ratingsService;
        public RatingsController(IRating ratings)
        {
            _ratingsService = ratings;
        }

        [HttpPost]
        public IActionResult Insert([FromBody] RatingInsertRequest request)
        {
            return Ok(_ratingsService.Insert(request));
        }
    }
}
