using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpSimpleCRUD.Controllers
{
    public abstract class AbpSimpleCRUDControllerBase: AbpController
    {
        protected AbpSimpleCRUDControllerBase()
        {
            LocalizationSourceName = AbpSimpleCRUDConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
