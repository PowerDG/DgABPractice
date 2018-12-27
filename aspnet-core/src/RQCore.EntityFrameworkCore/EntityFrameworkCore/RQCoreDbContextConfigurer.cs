using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RQCore.EntityFrameworkCore
{
    public static class RQCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RQCoreDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RQCoreDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
