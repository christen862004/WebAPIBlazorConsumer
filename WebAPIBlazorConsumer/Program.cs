using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace WebAPIBlazorConsumer
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            //register with different  web api provider url
            //builder.Services.AddScoped<IServices<Employee>, EmployeeServices>();//provider 127.0.0.1:4000

            //builder.Services.AddScoped<IServices<Department>, DepartementService>();//provider 172.0.0.111

            //builder.Services.AddScoped
            //    (sp => new HttpClient
            //    {
            //        BaseAddress = new Uri(builder.Configuration.GetValue<string>("ProviderUrl"))
            //    });

            builder.Services.AddHttpClient<IServices<Employee>, EmployeeServices>(
                client=>client.BaseAddress= new Uri(builder.Configuration.GetValue<string>("ProviderUrl"))
                );
            builder.Services.AddHttpClient<IServices<Department>, DepartementService>(
                client => client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ProviderUrl"))
                );
            await builder.Build().RunAsync();
        }
    }
}
