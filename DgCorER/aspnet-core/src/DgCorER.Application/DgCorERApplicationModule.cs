using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DgCorER.Authorization;

namespace DgCorER
{
    [DependsOn(
        typeof(DgCorERCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DgCorERApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DgCorERAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DgCorERApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
