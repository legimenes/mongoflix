using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using mongoFlix.API.Domain.Entities;
using mongoFlix.API.Domain.Repositories;

namespace mongoFlix.API.Domain.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> Get();
        Task<Movie> Get(string id);
    }

    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<Movie>> Get()
        {
            try
            {
                return await _movieRepository.Get();
            }
            catch (Exception exception)
            {
                throw;
            }
        }
        public async Task<Movie> Get(string id)
        {
            try
            {
                return await _movieRepository.Get(id);
            }
            catch (Exception exception)
            {
                throw;
            }
        }
    }
}