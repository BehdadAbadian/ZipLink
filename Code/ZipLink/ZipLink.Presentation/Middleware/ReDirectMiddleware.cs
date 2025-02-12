
using Microsoft.IdentityModel.Tokens;
using ZipLink.Application.Contracts.Interface;

namespace ZipLink.Presentation.Middleware
{
    public class ReDirectMiddleware : IMiddleware
    {
        private readonly IRedirectService _redirect;

        public ReDirectMiddleware(IRedirectService redirect)
        {
            _redirect = redirect;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var path = context.Request.Path;
            if (path.ToString().Length == 7)
            {
                var orginlLink = await _redirect.GetOrginalLinkAsync(path);
                if (orginlLink.IsNullOrEmpty())
                {
                    await next.Invoke(context);
                }
                else
                {
                    context.Response.Redirect(orginlLink);
                }
            }
            else
            {
                await next.Invoke(context);
            }
            
            //
        }
    }
}
