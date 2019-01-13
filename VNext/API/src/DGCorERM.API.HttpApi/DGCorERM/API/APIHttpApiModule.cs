using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace DGCorERM.API
{
    [DependsOn(
        typeof(APIApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class APIHttpApiModule : AbpModule
    {
        
    }
}
