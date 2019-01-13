using Microsoft.Extensions.DependencyInjection;
using DGCorERM.API.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace DGCorERM.API
{
    [DependsOn(
        typeof(APIDomainSharedModule)
        )]
    public class APIDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<APIDomainModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Get<APIResource>().AddVirtualJson("/DGCorERM/API/Localization/Domain");
            });

            Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("API", typeof(APIResource));
            });
        }
    }
}
