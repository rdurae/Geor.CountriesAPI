using Abp.Authorization;
using Geor.CountriesAPI.Authorization.Roles;
using Geor.CountriesAPI.Authorization.Users;

namespace Geor.CountriesAPI.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
