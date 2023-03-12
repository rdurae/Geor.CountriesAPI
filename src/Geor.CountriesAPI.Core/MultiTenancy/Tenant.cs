using Abp.MultiTenancy;
using Geor.CountriesAPI.Authorization.Users;

namespace Geor.CountriesAPI.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
