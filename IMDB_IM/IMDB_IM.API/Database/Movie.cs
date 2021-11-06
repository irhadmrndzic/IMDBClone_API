using System;
using System.Collections.Generic;

#nullable disable

namespace IMDB_IM.API.Database
{
    public partial class Movie
    {
        public Movie()
        {
            MoviesActors = new HashSet<MoviesActor>();
            Ratings = new HashSet<Rating>();
        }

        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte[] CoverImage { get; set; }
        public int Type { get; set; }

        public virtual ICollection<MoviesActor> MoviesActors { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
