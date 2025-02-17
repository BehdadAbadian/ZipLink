using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using ZipLink.Domain.Link;
using ZipLink.Domain.Statistic;
using ZipLink.Infrastructure.Pattern;
using ZipLink.Infrastructure.Repository;

namespace ZipLink.Infrastructure;

public static class InfrastructureSetup
{
    public static void AddInfrastructureSetup(this IServiceCollection service)
    {
        service.AddTransient<IUnitOfwork, UnitOfwork>();
        service.AddTransient<ILinkRepository, LinkRepository>();
        service.AddTransient<ILinkStatisticRepository, LinksStatisticRepository>();

    }
}
