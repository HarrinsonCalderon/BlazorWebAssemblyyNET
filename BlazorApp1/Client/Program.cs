using BlazorApp1;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            //para traer la url de la api del appsetting
            var apiUrl = builder.Configuration.GetValue<string>("apiUrl");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiUrl) });

            //Para inyectar los componentes
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICaregoryService, CategoryService>();


            await builder.Build().RunAsync();
        }
    }
}