using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AuditLogging.MongoDB;
using Volo.Abp.BackgroundJobs.MongoDB;
using Volo.Abp.Identity.MongoDB;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.MongoDB;
using Volo.Abp.SettingManagement.MongoDB;

namespace DGCorERM.MVC.MongoDb
{
    [DependsOn(
        typeof(AbpPermissionManagementMongoDbModule),
        typeof(AbpSettingManagementMongoDbModule),
        typeof(AbpIdentityMongoDbModule),
        typeof(BackgroundJobsMongoDbModule),
        typeof(AbpAuditLoggingMongoDbModule)
        )]
    public class MVCMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<MVCMongoDbContext>(options =>
            {
                options.AddDefaultRepositories();
            });
        }
    }
}
