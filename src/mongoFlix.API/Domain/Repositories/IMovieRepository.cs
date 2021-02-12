using System.Collections.Generic;
using System.Threading.Tasks;
using mongoFlix.API.Domain.Entities;

namespace mongoFlix.API.Domain.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> Get();
        Task<Movie> Get(string id);
    }
}