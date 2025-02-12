using Microsoft.Extensions.DependencyInjection;
using ZipLink.Application.Contracts.Interface;
using ZipLink.Application.Services;

namespace ZipLink.Application;
public static class ServiceSetup
{
    public static void AddServiceSetup(this IServiceCollection service)
    {
        service.AddTransient<IRedirectService, RediretService>();
    }
}
