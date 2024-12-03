using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using MovieStore.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.BL.Services
{
    internal class MovieBlService : IMovieBlService
    {
        private readonly IMovieService movieService;
        private readonly IActorRepository actorRepository;

        public MovieBlService
        public IEnumerable<MoviesView> GetDetailedMovies()
        {
            var result 
            var movies:List < Movie > = movieService.GetAllMovies();

            foreach (var movie in movies)
            {
                var actors = new List<Actor>
                var movieView = new MoviesView
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Year = movie.Year,
                    Actors = new List<Actor>(capacity: movie.Actors.Count())
                };
                
             
            }
        }
    }
}
