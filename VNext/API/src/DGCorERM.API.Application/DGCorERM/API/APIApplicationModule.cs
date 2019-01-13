using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace DGCorERM.API
{
    [DependsOn(
        typeof(APIDomainModule),
        typeof(APIApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class APIApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<APIApplicationAutoMapperProfile>(validate: true);
            });

            Configure<SettingOptions>(options =>
            {
                options.DefinitionProviders.Add<APISettingDefinitionProvider>();
            });
        }
    }
}
