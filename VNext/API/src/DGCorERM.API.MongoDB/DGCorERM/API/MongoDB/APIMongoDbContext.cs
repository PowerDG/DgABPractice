using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace DGCorERM.API.MongoDB
{
    [ConnectionStringName("API")]
    public class APIMongoDbContext : AbpMongoDbContext, IAPIMongoDbContext
    {
        public static string CollectionPrefix { get; set; } = APIConsts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureAPI(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }


    public class MyDbContext : AbpMongoDbContext
    {
        public IMongoCollection<Question> Questions => Collection<Question>();

        public IMongoCollection<Category> Categories => Collection<Category>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>(b =>
            {
                b.CollectionName = "Questions";
            });
        }
    }

}