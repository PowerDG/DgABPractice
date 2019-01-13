using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace DGCorERM.API.MongoDB
{
    public class APIMongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public APIMongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = APIConsts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}