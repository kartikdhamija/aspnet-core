using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Assignment.Authorization;

namespace Assignment
{
    [DependsOn(
        typeof(AssignmentCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AssignmentApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AssignmentAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AssignmentApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
