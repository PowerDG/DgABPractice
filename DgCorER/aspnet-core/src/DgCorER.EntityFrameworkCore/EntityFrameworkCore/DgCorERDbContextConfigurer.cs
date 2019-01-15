using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DgCorER.EntityFrameworkCore
{
    public static class DgCorERDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DgCorERDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DgCorERDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
