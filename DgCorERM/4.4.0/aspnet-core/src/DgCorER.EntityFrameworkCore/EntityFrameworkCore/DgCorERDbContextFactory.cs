using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DgCorER.Configuration;
using DgCorER.Web;

namespace DgCorER.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DgCorERDbContextFactory : IDesignTimeDbContextFactory<DgCorERDbContext>
    {
        public DgCorERDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DgCorERDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DgCorERDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DgCorERConsts.ConnectionStringName));

            return new DgCorERDbContext(builder.Options);
        }
    }
}
