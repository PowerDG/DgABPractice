using Volo.Abp.Modularity;

namespace DGCorERM.API
{
    [DependsOn(
        typeof(APIApplicationModule),
        typeof(APIDomainTestModule)
        )]
    public class APIApplicationTestModule : AbpModule
    {

    }
}
