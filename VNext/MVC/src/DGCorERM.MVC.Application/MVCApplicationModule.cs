using DGCorERM.MVC.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace DGCorERM.MVC
{
    [DependsOn(
        typeof(MVCDomainModule),
        typeof(AbpIdentityApplicationModule))]
    public class MVCApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<PermissionOptions>(options =>
            {
                options.DefinitionProviders.Add<MVCPermissionDefinitionProvider>();
            });

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<MVCApplicationAutoMapperProfile>();
            });
        }
    }
}
