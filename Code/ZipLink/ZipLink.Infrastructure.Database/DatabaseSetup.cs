using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ZipLink.Infrastructure.Database;
public static class DatabaseSetup
{
    public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("ZipLink");
        services.AddDbContext<ZipLinkContext>(options =>
        {
            options.UseSqlServer(connectionString,
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure();
                });
        });
    }
}
