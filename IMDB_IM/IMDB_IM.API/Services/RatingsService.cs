
using AutoMapper;
using IMDB_IM.API.Database;
using IMDB_IM.API.Interfaces;
using IMDB_IM.Model.Ratings;

namespace IMDB_IM.API.Services
{
    public class RatingsService : IRating
    {

        private readonly IMapper _mapper;
        private readonly IMDBMistralContext _dbContext;

        public RatingsService(IMapper mapper, IMDBMistralContext context)
        {
            _mapper = mapper;
            _dbContext = context;
        }

        public RatingsModel Insert(RatingInsertRequest request)
        {
            var entity = new Rating 
            { 
            FkMovieId = request.MovieId,
            RatingN = request.RatingNumber
            };

            _dbContext.Ratings.Add(entity);
            _dbContext.SaveChanges();

            return _mapper.Map<RatingsModel>(entity);
        }
    }
}
