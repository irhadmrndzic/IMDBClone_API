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
            bool flagSearched = false;
            bool hasElements = false;



            entity = entity.OrderByDescending(q => q.Ratings.Average(x => x.RatingN)).Include(q => q.Ratings);

            if (request.Type.HasValue)
            {
                entity = entity.Where(q => q.Type == request.Type);
            }



            if (!string.IsNullOrEmpty(request.Search))
            {
                string searchString = request.Search.ToLower();

                if (entity.Any(q => q.Title.ToLower().Contains(searchString) || q.Description.ToLower().Contains(searchString)))
                {
                    entity = entity.Where(q => q.Title.ToLower().Contains(searchString) || q.Description.ToLower().Contains(searchString) && q.Type == request.Type);
                    if (entity.Any())
                    {
                        hasElements = true;
                    }
                    flagSearched = true;
                }

                if (!entity.Any(q => q.Title.Contains(request.Search) || q.Description.Contains(request.Search)))
                {
                    bool containsDigit = searchString.Any(c => char.IsDigit(c));
                    if (containsDigit)
                    {
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
                                    flagSearched = true;
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
                                    flagSearched = true;
                                }
                            }
                        }
                        else if (searchString.Contains("after"))
                        {
                            if (int.TryParse(number.ToString(), out int pNumber))
                            {
                                var year = Convert.ToDateTime("1/1/" + pNumber.ToString());

                                entity = entity.Where(x => x.ReleaseDate.Year >= year.Year);
                                if (entity.Any())
                                {
                                    hasElements = true;
                                }
                                flagSearched = true;

                            }
                        }
                        else if (searchString.Contains("before"))
                        {
                            if (int.TryParse(number.ToString(), out int pNumber))
                            {
                                var year = Convert.ToDateTime("1/1/" + pNumber.ToString());

                                entity = entity.Where(x => x.ReleaseDate.Year <= year.Year);
                                if (entity.Any())
                                {
                                    hasElements = true;
                                }
                                flagSearched = true;

                            }
                        }
                    }

                }
                 if (!flagSearched && !hasElements || (flagSearched && !hasElements))
                {
                    var movieActors = _dbContext.MoviesActors.Where(q => q.FkActor.FirstName.ToLower().Contains(searchString)).Include(m => m.FkMovie).Include(a => a.FkActor);
                    foreach (var ma in movieActors)
                    {
                        tempMoviesList.Add((Movie)entity.Where(x => x.MovieId == ma.FkMovieId).SingleOrDefault());
                    }

                   
                    flagSearched = true;
                }
            }


            if (!flagSearched)
            {
                list = entity.ToList();
            }
            else if (flagSearched && !hasElements && tempMoviesList.Count == 0)
            {
                list = null;
            }
            else if (flagSearched && hasElements)
            {
                list = entity.ToList();
            }
            else if (tempMoviesList.Count > 0 && flagSearched)
            {
                list = tempMoviesList;
            }


            var castedList = _mapper.Map<List<MoviesModel>>(list);

            var pagedList = PagedList<MoviesModel>.ToPagedList(castedList, request.PageNumber, request.PageSize);


            return pagedList;

        }
    }
}
