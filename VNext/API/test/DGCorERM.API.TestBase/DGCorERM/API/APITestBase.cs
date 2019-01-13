using Volo.Abp;
using Volo.Abp.Modularity;

namespace DGCorERM.API
{
    public abstract class APITestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> 
        where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
