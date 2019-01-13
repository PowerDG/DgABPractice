using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DgCorER.Configuration;

namespace DgCorER.Web.Host.Startup
{
    [DependsOn(
       typeof(DgCorERWebCoreModule))]
    public class DgCorERWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DgCorERWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DgCorERWebHostModule).GetAssembly());
        }
    }
}
