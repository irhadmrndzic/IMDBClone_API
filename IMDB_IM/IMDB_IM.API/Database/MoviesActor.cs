using System;
using System.Collections.Generic;

#nullable disable

namespace IMDB_IM.API.Database
{
    public partial class MoviesActor
    {
        public int MovieActorId { get; set; }
        public int? FkMovieId { get; set; }
        public int? FkActorId { get; set; }

        public virtual Actor FkActor { get; set; }
        public virtual Movie FkMovie { get; set; }
    }
}
