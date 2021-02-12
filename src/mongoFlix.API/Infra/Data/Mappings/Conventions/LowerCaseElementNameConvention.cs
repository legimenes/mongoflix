using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;

namespace mongoFlix.API.Infra.Data.Mappings.Conventions
{
    public class LowerCaseElementNameConvention : IMemberMapConvention
    {
        public string Name => "Name all the elements the corresponding lower-case version of the member name";

        public void Apply(BsonMemberMap memberMap)
        {
            memberMap.SetElementName(memberMap.MemberName.ToLower());
            memberMap.SetElementName(memberMap.MemberName.ToLower());
        }
    }
}