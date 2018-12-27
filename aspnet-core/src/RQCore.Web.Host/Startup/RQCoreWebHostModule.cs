﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RQCore.Configuration;

namespace RQCore.Web.Host.Startup
{
    [DependsOn(
       typeof(RQCoreWebCoreModule))]
    public class RQCoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RQCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RQCoreWebHostModule).GetAssembly());
        }
    }
}
