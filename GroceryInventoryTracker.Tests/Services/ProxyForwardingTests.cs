using System.Net;
using GroceryInventoryTracker.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Xunit;

namespace GroceryInventoryTracker.Tests.Services
{
    public class ProxyForwardingTests
    {
        // Runs the real ForwardedHeadersMiddleware with the app's settings against a request arriving
        // from a Docker-bridge address (how cloudflared reaches the containerized app).
        private static async Task<HttpContext> SendThroughMiddlewareAsync(Action<HttpRequest> setup)
        {
            var options = new ForwardedHeadersOptions();
            ProxyForwarding.Configure(options);
            var middleware = new ForwardedHeadersMiddleware(_ => Task.CompletedTask, NullLoggerFactory.Instance, Options.Create(options));

            var context = new DefaultHttpContext();
            context.Request.Scheme = "http";
            context.Connection.RemoteIpAddress = IPAddress.Parse("172.17.0.1");
            setup(context.Request);

            await middleware.Invoke(context);
            return context;
        }

        [Fact]
        public async Task ForwardedProtoHttps_FromANonLoopbackProxy_MakesTheRequestHttps()
        {
            var context = await SendThroughMiddlewareAsync(r => r.Headers["X-Forwarded-Proto"] = "https");

            Assert.Equal("https", context.Request.Scheme);
            Assert.True(context.Request.IsHttps);
        }

        [Fact]
        public async Task WithoutForwardedProto_TheRequestStaysHttp()
        {
            var context = await SendThroughMiddlewareAsync(_ => { });

            Assert.Equal("http", context.Request.Scheme);
        }

        [Fact]
        public async Task ForwardedFor_IsNotTrusted()
        {
            var context = await SendThroughMiddlewareAsync(r => r.Headers["X-Forwarded-For"] = "203.0.113.9");

            Assert.Equal(IPAddress.Parse("172.17.0.1"), context.Connection.RemoteIpAddress);
        }
    }
}
