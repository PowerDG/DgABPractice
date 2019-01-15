using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DgCorER.Controllers
{
    public abstract class DgCorERControllerBase: AbpController
    {
        protected DgCorERControllerBase()
        {
            LocalizationSourceName = DgCorERConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
