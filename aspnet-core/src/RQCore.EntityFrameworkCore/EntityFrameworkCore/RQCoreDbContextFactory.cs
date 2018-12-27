using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RQCore.Configuration;
using RQCore.Web;

namespace RQCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RQCoreDbContextFactory : IDesignTimeDbContextFactory<RQCoreDbContext>
    {
        public RQCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RQCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RQCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RQCoreConsts.ConnectionStringName));

            return new RQCoreDbContext(builder.Options);
        }
    }
}
