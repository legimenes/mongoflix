namespace mongoFlix.API.Infra.Data
{
    public interface IMongoFlixDatabaseSettings
    {
        string MovieCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        //string User { get; set; }
        //string Password { get; set; }
    }
}