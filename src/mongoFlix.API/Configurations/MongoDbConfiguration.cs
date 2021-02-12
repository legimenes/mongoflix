using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization.Conventions;
using mongoFlix.API.Infra.Data;
using mongoFlix.API.Infra.Data.Mappings;
using mongoFlix.API.Infra.Data.Mappings.Conventions;

namespace mongoFlix.API.Configurations
{
    public static class MongoDbConfiguration
    {
        public static IServiceCollection AddMongoDbConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoFlixDatabaseSettings>(configuration.GetSection(nameof(MongoFlixDatabaseSettings)));
            services.AddSingleton<IMongoFlixDatabaseSettings>(sp => sp.GetRequiredService<IOptions<MongoFlixDatabaseSettings>>().Value);
            
            ConfigureConventions();
            Map();

            return services;
        }

        private static void ConfigureConventions()
        {
            ConventionPack pack = new ConventionPack();
            pack.Add(new LowerCaseElementNameConvention());
            ConventionRegistry.Register("LowerCaseElementName", pack, t => true);
        }
        private static void Map()
        {
            MovieMap.Configure();
        }
    }
}