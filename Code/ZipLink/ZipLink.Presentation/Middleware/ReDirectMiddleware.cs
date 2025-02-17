
using Microsoft.IdentityModel.Tokens;
using ZipLink.Application.Contracts.Interface;

namespace ZipLink.Presentation.Middleware
{
    public class ReDirectMiddleware : IMiddleware
    {
        private readonly IRedirectService _redirect;
        private readonly IStatisticService _statisticService;

        public ReDirectMiddleware(IRedirectService redirect, IStatisticService statisticService)
        {
            _redirect = redirect;
            _statisticService = statisticService;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var path = context.Request.Path;
            if (path.ToString().Length == 7)
            {
                var orginalLink = await _redirect.GetOrginalLinkAsync(path);
                if (orginalLink.IsNullOrEmpty())
                {
                    await next.Invoke(context);
                }
                else
                {
                    var linkId = await _redirect.GetLinkId(path);
                    var ip = " ";
                    await _statisticService.AddRedirectRecord(linkId, ip);
                    context.Response.Redirect(orginalLink);
                }
            }
            else
            {
                await next.Invoke(context);
                
            }
        }
    }
}
