using Microsoft.AspNetCore.HttpOverrides;

namespace GroceryInventoryTracker.Services
{
    /// <summary>
    /// Forwarded-header settings for running behind a TLS-terminating reverse proxy (in production, a
    /// Cloudflare Tunnel). The tunnel connects to Kestrel over plain HTTP, so without this the app
    /// believes every request is http:// — it then builds http:// redirect URLs (e.g. the login
    /// redirect), never marks the auth cookie Secure, and never emits HSTS.
    /// </summary>
    public static class ProxyForwarding
    {
        public static void Configure(ForwardedHeadersOptions options)
        {
            // Only the original scheme is taken from the proxy. X-Forwarded-For is deliberately not
            // trusted: nothing in the app depends on the client IP, and accepting it from an unknown
            // proxy address would let a direct caller spoof it.
            options.ForwardedHeaders = ForwardedHeaders.XForwardedProto;

            // cloudflared reaches the app from the Docker host / bridge network rather than from
            // loopback inside the container, and that address isn't fixed, so the default
            // loopback-only trust list would silently ignore the header.
            options.KnownIPNetworks.Clear();
            options.KnownProxies.Clear();
        }
    }
}
