using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using DGCorERM.API.Localization;

namespace DGCorERM.API
{
    [DependsOn(
        typeof(AbpLocalizationModule)
        )]
    public class APIDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Add<APIResource>("en");
            });
        }
    }
}
