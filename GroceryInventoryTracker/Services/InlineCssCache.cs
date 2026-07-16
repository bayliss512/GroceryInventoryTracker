using System.Collections.Concurrent;

namespace GroceryInventoryTracker.Services
{
    /// <summary>
    /// Reads a wwwroot CSS file's contents once and caches it in memory so it can be
    /// embedded directly in the page's &lt;head&gt; instead of fetched via a separate
    /// &lt;link&gt; request. Removes any race between HTML parsing/painting and the
    /// stylesheet arriving, which otherwise shows briefly as unstyled content.
    /// </summary>
    public static class InlineCssCache
    {
        private static readonly ConcurrentDictionary<string, string> _cache = new();

        public static string Get(IWebHostEnvironment env, string webRootRelativePath)
        {
            return _cache.GetOrAdd(webRootRelativePath, path =>
                File.ReadAllText(Path.Combine(env.WebRootPath, path.Replace('/', Path.DirectorySeparatorChar))));
        }
    }
}
