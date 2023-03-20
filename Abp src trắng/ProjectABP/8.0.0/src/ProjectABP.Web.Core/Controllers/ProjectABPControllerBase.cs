using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ProjectABP.Controllers
{
    public abstract class ProjectABPControllerBase: AbpController
    {
        protected ProjectABPControllerBase()
        {
            LocalizationSourceName = ProjectABPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
