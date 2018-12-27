using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RQCore.Controllers
{
    public abstract class RQCoreControllerBase: AbpController
    {
        protected RQCoreControllerBase()
        {
            LocalizationSourceName = RQCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
