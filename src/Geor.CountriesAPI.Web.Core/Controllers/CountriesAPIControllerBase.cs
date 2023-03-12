using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Geor.CountriesAPI.Controllers
{
    public abstract class CountriesAPIControllerBase: AbpController
    {
        protected CountriesAPIControllerBase()
        {
            LocalizationSourceName = CountriesAPIConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
