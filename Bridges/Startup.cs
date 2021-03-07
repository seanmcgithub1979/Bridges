using BridgesRepo;
using BridgesRepo.Data;
using BridgesRepo.Interfaces;
using BridgesRepo.Mocks;
using BridgesService.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Bridges
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("BridgesDbContext");

            services.AddRazorPages();

            services.AddServerSideBlazor();

            services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/Pages");
            
            services.AddDbContext<BridgesDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IBridgeRepo, BridgeRepoSqlServer>();
            services.AddScoped<ICommentRepo, CommentRepoSqlServer>();

            services.AddScoped<IBridgeRepo, BridgeRepoMock>();
            services.AddScoped<ICommentRepo, CommentRepoMock>();
            
            services.AddScoped<IBridgesService, BridgesService.Services.BridgesService>();
            services.AddScoped<ICommentService, BridgesService.Services.CommentService>();

            services.AddAuthentication(sharedOptions =>
            {
                sharedOptions.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                sharedOptions.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
            .AddAzureAd(options => Configuration.Bind("AzureAd", options))
            .AddCookie();

            //services.AddMvc(options =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //        .RequireAuthenticatedUser()
            //        .Build();
            //    options.Filters.Add(new AuthorizeFilter(policy));
            //})
            //.AddRazorPagesOptions(options =>
            //{
            //    options.Conventions.AllowAnonymousToFolder("/Account");
            //});

            services.AddApplicationInsightsTelemetry(Configuration["APPINSIGHTS_CONNECTIONSTRING"]);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDirectoryBrowser();
                //app.UseDeveloperExceptionPage();
            }
            else
            {
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
