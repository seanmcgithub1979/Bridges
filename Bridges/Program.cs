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
            IHostBuilder configureWebHostDefaults = Host.CreateDefaultBuilder(args);

            configureWebHostDefaults.ConfigureAppConfiguration((hostingContext, builder) =>
                {
                    //IHostEnvironment env = hostingContext.HostingEnvironment;
                    builder.Sources.Clear();

                    builder.AddJsonFile("appsettings.json", false, true);
                    //builder.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true,
                    //    reloadOnChange: true);

                    //builder.AddJsonFile("custom.json", optional: true, reloadOnChange: true);
                    //builder.AddXmlFile("custom.xml", optional: true, reloadOnChange: true);
                    //builder.AddIniFile("custom.ini", optional: true, reloadOnChange: true);

                    //IDictionary<string, string> memCollection = new Dictionary<string, string>
                    //{
                    //    {"MainSetting:SubSetting", "sub setting from dictionary"},
                    //    {"Key", "Value"}
                    //};
                    //builder.AddInMemoryCollection(memCollection);

                    if (hostingContext.HostingEnvironment.IsDevelopment()) builder.AddUserSecrets<Program>();

                    //uilder.AddEnvironmentVariables();
                    //builder.AddCommandLine(args);
                })
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });

            return configureWebHostDefaults;
        }
    }
}