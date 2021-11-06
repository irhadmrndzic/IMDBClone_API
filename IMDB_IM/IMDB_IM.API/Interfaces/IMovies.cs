using IMDB_IM.API.Helper;
using IMDB_IM.Model.Movies;
using System.Collections.Generic;

namespace IMDB_IM.API.Interfaces
{
    public interface IMovies
    {
        PagedList<MoviesModel> Get(MoviesSearchRequest request);
    }
}
