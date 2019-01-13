using Volo.Abp;

namespace DGCorERM.MVC
{
    public abstract class MVCApplicationTestBase : AbpIntegratedTest<MVCApplicationTestModule>
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
