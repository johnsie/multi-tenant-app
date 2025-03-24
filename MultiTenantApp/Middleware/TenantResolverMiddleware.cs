using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MultiTenantApp.Middleware
{
    public class TenantResolverMiddleware
    {
        private readonly RequestDelegate _next;

        public TenantResolverMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var host = context.Request.Host.Host;
            var tenant = host.Split('.')[0];

            context.Items["TenantId"] = tenant; 

            await _next(context);
        }
    }
}
