using Application.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            #region PostgreSQL configuration
            services.AddDbContext<PostgresDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("PostgresConnectionString"));
            });
            #endregion

            #region Oracle configuration
            services.AddDbContext<OracleDbContext>(options =>
            {
                options.UseOracle(configuration.GetConnectionString("OracleConnectionString"), opt => opt.UseOracleSQLCompatibility("11"));
            });
            #endregion

            services.AddScoped<IPostgresDbContext>(provider => provider.GetService<PostgresDbContext>());
            services.AddScoped<IOracleDbContext>(provider => provider.GetService<OracleDbContext>());

            return services;
        }
    }
}
