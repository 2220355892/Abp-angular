
using System.Reflection;
using Abp.Dependency;
using Abp.Reflection.Extensions;
using DependsOnAttribute = Abp.Modules.DependsOnAttribute;
using Abp.Domain.Repositories;
using Abc.Projects.Share.Core._Business.Entities;

namespace Abc.Projects.Share.Core
{
    [DependsOn(
          typeof(Abc.Projects.Share.Core.Module)

      )]
    public class Module : Abp.Modules.AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;
      
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Module).GetAssembly());


            base.Initialize();
        }
    }
}
