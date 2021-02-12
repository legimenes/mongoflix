namespace mongoFlix.API.Infra.Data
{
    public class MongoFlixDatabaseSettings : IMongoFlixDatabaseSettings
    {
        public string MovieCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        //public string User { get; set; }
        //public string Password { get; set; }
    }
}