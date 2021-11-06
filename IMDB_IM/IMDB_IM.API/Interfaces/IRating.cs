
using IMDB_IM.Model.Ratings;
using System.Collections.Generic;

namespace IMDB_IM.API.Interfaces
{
    public interface IRating
    {
         RatingsModel Insert(RatingInsertRequest request);
    }
}
