using AutoMapper;
using IMDB_IM.Model.Movies;
using IMDB_IM.Model.Ratings;
using System.Linq;

namespace IMDB_IM.API.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Movie, MoviesModel>()
                .ForMember(q=>q.AvgRating, src=>src.MapFrom(a=>a.Ratings.Average(x=>x.RatingN)))
                .ReverseMap();


            CreateMap<Database.Rating, RatingsModel>()
            .ForMember(x => x.RatingNumber, src => src.MapFrom(q => q.RatingN)).ReverseMap();
        }



    }
}
