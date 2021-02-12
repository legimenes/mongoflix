using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using mongoFlix.API.Domain.Entities;

namespace mongoFlix.API.Infra.Data.Mappings
{
    public class MovieMap
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<Movie>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.SetDiscriminator("movies");
                map.MapIdMember(x => x.Id).SetSerializer(new StringSerializer(BsonType.ObjectId));
                //map.MapMember(x => x.Plot).SetElementName("plot");
                //map.MapMember(x => x.Poster).SetElementName("poster");
                //map.MapMember(x => x.Title).SetElementName("title");
            });
        }
    }
}