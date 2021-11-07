using AutoMapper;
using IMDB_IM.API.Database;
using IMDB_IM.API.Helper;
using IMDB_IM.API.Interfaces;
using IMDB_IM.Model.Movies;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace IMDB_IM.API.Services
{
    public class MoviesService : IMovies
    {
        private readonly IMapper _mapper;
        private readonly IMDBMistralContext _dbContext;
        public MoviesService(IMapper mapper, IMDBMistralContext context)
        {
            _mapper = mapper;
            _dbContext = context;
        }


        public PagedList<MoviesModel> Get(MoviesSearchRequest request)
        {
            var tempMoviesList = new List<Movie>();
            var list = new List<Movie>();
            var entity = _dbContext.Movies.AsQueryable();
            bool digitSearch = false;


            entity = entity.OrderByDescending(q => q.Ratings.Average(x => x.RatingN)).Include(q => q.Ratings).Include(q=>q.MoviesActors).ThenInclude(a=>a.FkActor);

            if (request.Type.HasValue)
            {
                entity = entity.Where(q => q.Type == request.Type);
            }



            if (!string.IsNullOrEmpty(request.Search))
            {
                string searchString = request.Search.ToLower().Trim();

                bool containsDigit = searchString.Any(c => char.IsDigit(c));
                if (containsDigit)
                {
                    digitSearch = true;
                    var number = Regex.Match(searchString, @"\d+").Value;
                    if (searchString.Contains("stars"))
                    {
                        if (searchString.Contains("at least"))
                        {
                            if (int.TryParse(number.ToString(), out int pNumber))
                            {

                                var ratings = _dbContext.Ratings.AsQueryable();


                                foreach (var item in entity.ToList())
                                {
                                    if (ratings.Where(x => x.FkMovieId == item.MovieId).Average(q => q.RatingN) >= pNumber)
                                    {
                                        tempMoviesList.Add(item);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (int.TryParse(number.ToString(), out int pNumber))
                            {

                                var ratings = _dbContext.Ratings.AsQueryable();

                                foreach (var item in entity.ToList())
                                {
                                    if (ratings.Where(x => x.FkMovieId == item.MovieId).Average(q => q.RatingN) == pNumber)
                                    {
                                        tempMoviesList.Add(item);
                                    }
                                }
                            }
                        }
                    }
                    else if (searchString.Contains("after"))
                    {
                        if (int.TryParse(number.ToString(), out int pNumber))
                        {
                            var year = Convert.ToDateTime("1/1/" + pNumber.ToString());

                            entity = entity.Where(x => x.ReleaseDate.Year >= year.Year);


                        }
                    }
                    else if (searchString.Contains("before"))
                    {
                        if (int.TryParse(number.ToString(), out int pNumber))
                        {
                            var year = Convert.ToDateTime("1/1/" + pNumber.ToString());

                            entity = entity.Where(x => x.ReleaseDate.Year <= year.Year);
                        }
                    }
                }

                if (!digitSearch)
                {
                    var searchTitleDescEntity = entity.Where(q => q.Title.ToLower().Contains(searchString) || q.Description.ToLower().Contains(searchString) && q.Type == request.Type);

                    if (searchTitleDescEntity.Any())
                    {
                        List<Movie> movies = searchTitleDescEntity.ToList();
                        tempMoviesList.AddRange(movies);
                    }

                    var moviesActorsSearchEntity = _dbContext.MoviesActors
                            .Where(q => q.FkActor.FirstName.ToLower().Contains(searchString) || q.FkActor.LastName.ToLower().Contains(searchString)
                            || (q.FkActor.FirstName.ToLower() + " " + q.FkActor.LastName.ToLower()).Contains(searchString)
                            || q.FkActor.FirstName.ToLower().StartsWith(searchString) || q.FkActor.LastName.ToLower().StartsWith(searchString)
                            || q.FkActor.FirstName.ToLower().EndsWith(searchString) || q.FkActor.LastName.ToLower().EndsWith(searchString)
                            || (q.FkActor.FirstName.ToLower() + " " + q.FkActor.LastName.ToLower()).StartsWith(searchString)
                            || (q.FkActor.FirstName.ToLower() + " " + q.FkActor.LastName.ToLower()).EndsWith(searchString))
                            .Include(m => m.FkMovie).Include(a => a.FkActor);

                    if (moviesActorsSearchEntity.Any())
                    {
                        foreach (var ma in moviesActorsSearchEntity)
                        {
                            if (!tempMoviesList.Contains(ma.FkMovie))
                            {
                                tempMoviesList.Add((Movie)entity.Where(x => x.MovieId == ma.FkMovieId).Include(x => x.MoviesActors).ThenInclude(x => x.FkActor).SingleOrDefault());

                            }
                        }
                    }


                }
            }

            if (digitSearch)
            {
                if (tempMoviesList.Count > 0)
                {
                    list = tempMoviesList;
                }
                else
                {
                    list = entity.ToList();
                }
            }
            else if(tempMoviesList.Count >0 && !digitSearch)
            {
                list = tempMoviesList;
            }
            if(list.Count==0 || list == null)
            {
                list = null;
            }

            var castedList = _mapper.Map<List<MoviesModel>>(list);

            var pagedList = PagedList<MoviesModel>.ToPagedList(castedList, request.PageNumber, request.PageSize);

            return pagedList;

        }
    }
}
