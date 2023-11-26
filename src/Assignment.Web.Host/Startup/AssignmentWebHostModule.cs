using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Assignment.Configuration;

namespace Assignment.Web.Host.Startup
{
    [DependsOn(
       typeof(AssignmentWebCoreModule))]
    public class AssignmentWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AssignmentWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AssignmentWebHostModule).GetAssembly());
        }
    }
}
