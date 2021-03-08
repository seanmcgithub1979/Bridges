using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Bridges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHostBuilder hostBuilder = CreateHostBuilder(args);
            IHost build = hostBuilder.Build();
            build.Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            IHostBuilder defaultBuilder = Host.CreateDefaultBuilder(args);

            IHostBuilder configureAppConfiguration = defaultBuilder.ConfigureAppConfiguration((hostingContext, builder) =>
            {
                //IHostEnvironment env = hostingContext.HostingEnvironment;
                builder.Sources.Clear();

                builder.AddJsonFile("appsettings.json", false, true);

                if (hostingContext.HostingEnvironment.IsDevelopment())
                {
                    builder.AddUserSecrets<Program>();
                }

                //builder.AddEnvironmentVariables();
                //builder.AddCommandLine(args);
            });

            configureAppConfiguration.ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());

            return defaultBuilder;
        }
    }
}