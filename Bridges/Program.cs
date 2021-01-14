using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace Bridges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            IHostBuilder configureWebHostDefaults = Host.CreateDefaultBuilder(args);

            configureWebHostDefaults.ConfigureAppConfiguration((hostingContext, builder) =>
                {
                    Dictionary<string, string> memCollection = new Dictionary<string, string>
                    {
                        {"MainSetting:SubSetting", "sub setting from dictionary"},
                        {"Key", "Value"}
                    };

                    IHostEnvironment env = hostingContext.HostingEnvironment;
                    builder.Sources.Clear();

                    builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                    builder.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true,
                        reloadOnChange: true);

                    builder.AddJsonFile("custom.json", optional: true, reloadOnChange: true);

                    builder.AddXmlFile("custom.xml", optional: true, reloadOnChange: true);

                    builder.AddIniFile("custom.ini", optional: true, reloadOnChange: true);

                    builder.AddInMemoryCollection(memCollection);

                    if (hostingContext.HostingEnvironment.IsDevelopment())
                    {
                        builder.AddUserSecrets<Program>();
                    }

                    builder.AddEnvironmentVariables();
                    builder.AddCommandLine(args);
                })
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });

            return configureWebHostDefaults;
        }
    }
}
