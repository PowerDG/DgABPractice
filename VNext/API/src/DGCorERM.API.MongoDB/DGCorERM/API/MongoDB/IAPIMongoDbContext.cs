using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace DGCorERM.API.MongoDB
{
    [ConnectionStringName("API")]
    public interface IAPIMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
