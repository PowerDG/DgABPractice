using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DgCorER.EntityFrameworkCore
{
    public static class DgCorERDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DgCorERDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseNpgsql(connectionString);
            //options.UseNpgsql(sqlConnectionString)
        }

        public static void Configure(DbContextOptionsBuilder<DgCorERDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseNpgsql(connection);


    //        "Default": "User ID=postgres;Password=wsx1001;Host=127.0.0.1;Port=5432;Database=DgCorERDb;Pooling=true;",
    //"Default3": "User ID=fonour;Password=123456;Host=localhost;Port=5432;Database=Fonour;Pooling=true;",
    //"Default5": "Server=localhost; Database=DgCorERDb; Trusted_Connection=True;",
    //"Default2": "host=127.0.0.1;port=5432;database=DgCorERDb;user id=######;password=wsx1001;Persist Security Info = true"


        }
    }
}
