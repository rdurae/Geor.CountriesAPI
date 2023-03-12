using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Geor.CountriesAPI.Authorization.Roles;
using Geor.CountriesAPI.Authorization.Users;
using Geor.CountriesAPI.MultiTenancy;
using Geor.CountriesAPI.Application;

namespace Geor.CountriesAPI.EntityFrameworkCore
{
    public class CountriesAPIDbContext : AbpZeroDbContext<Tenant, Role, User, CountriesAPIDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Country> Countries { get; set; }
        
        public CountriesAPIDbContext(DbContextOptions<CountriesAPIDbContext> options)
            : base(options)
        {
        }
    }
}
