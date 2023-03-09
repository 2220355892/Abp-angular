
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Abc.Projects.Application
{
    [DependsOn(
        typeof(Abc.Projects.Share.Core.Module)
    )]
    public class Module : AbpModule
    {
        public override void Initialize()
        {
            var thisAssembly = typeof(Module).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                cfg =>
                {
                    cfg.AddMaps(thisAssembly);

                }
            );
            base.Initialize();
        }

    }
}