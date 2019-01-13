using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace DGCorERM.API.EntityFrameworkCore
{
    [ConnectionStringName("API")]
    public interface IAPIDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}