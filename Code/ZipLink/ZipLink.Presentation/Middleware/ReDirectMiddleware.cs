
namespace ZipLink.Presentation.Middleware
{
    public class ReDirectMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var path = context.Request.Path;

            await next.Invoke(context);
        }
    }
}
