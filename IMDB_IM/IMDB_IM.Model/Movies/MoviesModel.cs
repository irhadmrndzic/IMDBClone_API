using System;


namespace IMDB_IM.Model.Movies
{
  public  class MoviesModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public byte[] CoverImage { get; set; }
        public decimal? AvgRating { get; set; }
        public int Type { get; set; }


    }
}
