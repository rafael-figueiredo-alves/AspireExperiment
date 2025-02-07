using AspireExperiment.Web2.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7522/") // Usa a URL do Server
});
builder.Services.AddScoped<WeatherApiClient>();

await builder.Build().RunAsync();
