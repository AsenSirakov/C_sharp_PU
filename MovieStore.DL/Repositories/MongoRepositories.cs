using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieStore.DL.Interfaces;
using MovieStore.Models.Configurations;
using MovieStore.Models.DTO;
namespace MovieStore.DL.Repositories.MongoRepositories
{
    public class MongoRepositories : IMovieRepository
    {
        private readonly IOptionsMonitor<MongoDbConfiguration> options;
        private readonly IMongoCollection<Movie> movies;

        public List<Movie> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public void AddMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Movie? GetMovieById(string id)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(string id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
   
 
