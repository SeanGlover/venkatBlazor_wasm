using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using venkatBlazor_wasm.Client;

// https://www.pragimtech.com/courses/blazor-webassembly-tutorial/
// https://www.pragimtech.com/blog/blazor-webassembly/asp-net-5-rest-api-tutorial

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddIgniteUIBlazor();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
