using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProjectABP.EntityFrameworkCore;
using ProjectABP.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ProjectABP.Web.Tests
{
    [DependsOn(
        typeof(ProjectABPWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ProjectABPWebTestModule : AbpModule
    {
        public ProjectABPWebTestModule(ProjectABPEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectABPWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ProjectABPWebMvcModule).Assembly);
        }
    }
}