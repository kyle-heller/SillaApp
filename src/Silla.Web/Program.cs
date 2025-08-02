using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Silla.Web;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// point at your running API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7179/") });
await builder.Build().RunAsync();