using DGCorERM.API.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DGCorERM.API
{
    [DependsOn(
        typeof(APIEntityFrameworkCoreTestModule)
        )]
    public class APIDomainTestModule : AbpModule
    {
        
    }
}
