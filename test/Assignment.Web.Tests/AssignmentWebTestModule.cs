using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Assignment.EntityFrameworkCore;
using Assignment.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Assignment.Web.Tests
{
    [DependsOn(
        typeof(AssignmentWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AssignmentWebTestModule : AbpModule
    {
        public AssignmentWebTestModule(AssignmentEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AssignmentWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AssignmentWebMvcModule).Assembly);
        }
    }
}