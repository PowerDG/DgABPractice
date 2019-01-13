using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace DGCorERM.API.MongoDB
{
    public static class APIMongoDbContextExtensions
    {
        public static void ConfigureAPI(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new APIMongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}