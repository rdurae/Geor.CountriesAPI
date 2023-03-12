using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Geor.CountriesAPI.EntityFrameworkCore
{
    public static class CountriesAPIDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CountriesAPIDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public static void Configure(DbContextOptionsBuilder<CountriesAPIDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection, ServerVersion.AutoDetect(connection.ConnectionString));
        }
    }
}