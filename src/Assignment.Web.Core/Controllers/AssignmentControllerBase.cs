using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Assignment.Controllers
{
    public abstract class AssignmentControllerBase: AbpController
    {
        protected AssignmentControllerBase()
        {
            LocalizationSourceName = AssignmentConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
