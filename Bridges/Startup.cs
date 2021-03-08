using BridgesDomain.Interfaces;
using BridgesDomain.Model;
using BridgesRepo;
using BridgesRepo.Data;
using BridgesRepo.Interfaces;
using BridgesService.Interfaces;
using BridgesService.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Bridges
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        private IConfig config;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = configuration.GetConnectionString("BridgesDbContext");
            config = new Config { ConnectionString = connectionString };

            services.AddRazorPages();

            services.AddServerSideBlazor();

            services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/Pages");
            
            services.AddSingleton(config);

            services.AddScoped<IBridgeRepo, BridgeRepoSqlServer>();
            services.AddScoped<ICommentRepo, CommentRepoSqlServer>();
            services.AddScoped<ICoordsService, CoordsService>();

            services.AddDbContext<BridgesDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IBridgesService, BridgesService.Services.BridgesService>();
            services.AddScoped<ICommentService, BridgesService.Services.CommentService>();

            #region mocks
            //services.AddScoped<IBridgeRepo, BridgeRepoMock>();
            //services.AddScoped<ICommentRepo, CommentRepoMock>();
            #endregion

            services.AddAuthentication(sharedOptions =>
            {
                sharedOptions.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                sharedOptions.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
            .AddAzureAd(options => configuration.Bind("AzureAd", options))
            .AddCookie();

            services.AddApplicationInsightsTelemetry(configuration["APPINSIGHTS_CONNECTIONSTRING"]);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                config.Environment = "development";
                //app.UseDirectoryBrowser();
                //app.UseDeveloperExceptionPage();
            }
            else
            {
                config.Environment = "production";
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseDeveloperExceptionPage();

            app.UseStaticFiles();
            app.UseAuthentication();
            //app.UseMvc();
            
            app.UseHttpsRedirection();
            //app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
