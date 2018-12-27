using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RQCore.Authorization;

namespace RQCore
{
    [DependsOn(
        typeof(RQCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RQCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RQCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RQCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
