using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace DGCorERM.API
{
    [DependsOn(
        typeof(APIApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class APIHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "API";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(APIApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
