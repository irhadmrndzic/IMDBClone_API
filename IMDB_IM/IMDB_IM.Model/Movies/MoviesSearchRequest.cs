
namespace IMDB_IM.Model.Movies
{
   public class MoviesSearchRequest
   {
        public int? Type { get; set; }

        public string Search { get; set; }

        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;

        public int PageSize { get { return _pageSize; } set { _pageSize = (value > maxPageSize) ? maxPageSize : value; } }
    }
}
