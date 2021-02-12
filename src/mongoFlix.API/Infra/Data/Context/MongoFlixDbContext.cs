using MongoDB.Driver;
using mongoFlix.API.Domain.Entities;

namespace mongoFlix.API.Infra.Data.Context
{
    public class MongoFlixDbContext
    {
        private readonly MongoClient _mongoClient;
        private readonly IMongoDatabase _mongoDatabase;
        private readonly IMongoFlixDatabaseSettings _settings;

        public MongoFlixDbContext(IMongoFlixDatabaseSettings settings)
        {
            _settings = settings;
            _mongoClient = new MongoClient(settings.ConnectionString);
            _mongoDatabase = _mongoClient.GetDatabase(settings.DatabaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _mongoDatabase.GetCollection<T>(name);
        }

        public IMongoCollection<Movie> Movies { get { return _mongoDatabase.GetCollection<Movie>(_settings.MovieCollectionName); } }
    }
}