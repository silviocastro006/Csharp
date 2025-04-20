using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ScreenSound.Web;
using ScreenSound.Web.Services;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient<MusicaAPI>();
builder.Services.AddMudServices();


builder.Services.AddHttpClient<ArtistaAPI>(client =>
{
    // Corrigido o nome da chave de configuração removendo o espaço
    client.BaseAddress = new Uri(builder.Configuration["APISever:Url"]!);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

await builder.Build().RunAsync();
