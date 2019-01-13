using Microsoft.Extensions.DependencyInjection;
using DGCorERM.API.Localization;
using Volo.Abp.Application;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace DGCorERM.API
{
    [DependsOn(
        typeof(APIDomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class APIApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<PermissionOptions>(options =>
            {
                options.DefinitionProviders.Add<APIPermissionDefinitionProvider>();
            });

            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<APIApplicationContractsModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<APIResource>()
                    .AddVirtualJson("/DGCorERM/API/Localization/ApplicationContracts");
            });
        }
    }
}
