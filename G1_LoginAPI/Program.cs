using BlazorEcuasolmovsa.Services;
using G1_LoginAPI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
//builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009") });
builder.Services.AddScoped<IEcuasolmovsaAPIClient, EcuasolmovsaAPIClient>();

await builder.Build().RunAsync();
