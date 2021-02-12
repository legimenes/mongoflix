using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using mongoFlix.API.Domain.Entities;
using mongoFlix.API.Domain.Repositories;
using mongoFlix.API.Infra.Data.Context;

namespace mongoFlix.API.Infra.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        protected readonly MongoFlixDbContext _context;

        public MovieRepository(MongoFlixDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> Get()
        {
            IAsyncCursor<Movie> movies = await _context.Movies.FindAsync(Builders<Movie>.Filter.Empty);
            return await movies.ToListAsync();
        }
        public async Task<Movie> Get(string id)
        {
            ObjectId objectId = new ObjectId(id); 
            FilterDefinition<Movie> filter = Builders<Movie>.Filter.Eq("_id", objectId);
 
            return await _context.Movies.FindAsync(filter).Result.FirstOrDefaultAsync();
        }
    }
}