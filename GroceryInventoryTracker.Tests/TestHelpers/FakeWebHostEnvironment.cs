using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;

namespace GroceryInventoryTracker.Tests.TestHelpers
{
    /// <summary>Minimal IWebHostEnvironment stand-in so services that only need a WebRootPath (e.g. for image resolution) can be constructed outside a running host.</summary>
    public class FakeWebHostEnvironment : IWebHostEnvironment
    {
        public string WebRootPath { get; set; } = Path.GetTempPath();
        public IFileProvider WebRootFileProvider { get; set; } = new NullFileProvider();
        public string ApplicationName { get; set; } = "GroceryInventoryTracker.Tests";
        public IFileProvider ContentRootFileProvider { get; set; } = new NullFileProvider();
        public string ContentRootPath { get; set; } = Path.GetTempPath();
        public string EnvironmentName { get; set; } = "Testing";
    }
}
