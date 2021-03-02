using BridgesRepo;
using BridgesRepo.Data;
using BridgesRepo.Interfaces;
using BridgesRepo.Mocks;
using BridgesService.Interfaces;
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
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("BridgesDbContext");
            
            services.AddRazorPages();
            
            services.AddServerSideBlazor();
            
            services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/Pages");
            
            services.AddDbContext<BridgesDbContext>(options => options.UseSqlServer(connectionString));
            
            services.AddScoped<IBridgeRepo, BridgeRepoSqlServer>();
            services.AddScoped<ICommentRepo, CommentRepoSqlServer>();

            //services.AddScoped<IBridgeRepo, BridgeRepoMock>();
            //services.AddScoped<ICommentRepo, CommentRepoMock>();

            //services.AddScoped<ICoordsService, BridgesService.Services.CoordService>();
            services.AddScoped<IBridgesService, BridgesService.Services.BridgesService>();
            services.AddScoped<ICommentService, BridgesService.Services.CommentService>();

            //services.Configure<EmailSettingsOptions>(Configuration.GetSection("EmailSettings"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}