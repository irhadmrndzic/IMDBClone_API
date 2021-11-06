using System;
using System.Collections.Generic;

#nullable disable

namespace IMDB_IM.API.Database
{
    public partial class Rating
    {
        public int RatingId { get; set; }
        public int? RatingN { get; set; }
        public int? FkMovieId { get; set; }

        public virtual Movie FkMovie { get; set; }
    }
}
