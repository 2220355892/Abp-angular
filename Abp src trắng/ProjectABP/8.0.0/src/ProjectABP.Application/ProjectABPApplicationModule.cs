using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProjectABP.Authorization;

namespace ProjectABP
{
    [DependsOn(
        typeof(ProjectABPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProjectABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProjectABPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProjectABPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
