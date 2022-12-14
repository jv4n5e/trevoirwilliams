using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShoppingCartList.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseAddress = "http://localhost:7071/api/";
/*var baseAddress = "https://function-app-test-jv4n5e.azurewebsites.net";
if (builder.HostEnvironment.IsProduction())
{
    baseAddress = "https://shoppingcartlist-api.azurewebsites.net";
}
*/
////builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });
await builder.Build().RunAsync();
