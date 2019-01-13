using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace DGCorERM.API.EntityFrameworkCore
{
    [ConnectionStringName("API")]
    public class APIDbContext : AbpDbContext<APIDbContext>, IAPIDbContext
    {
        public static string TablePrefix { get; set; } = APIConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = APIConsts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public APIDbContext(DbContextOptions<APIDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureAPI(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}