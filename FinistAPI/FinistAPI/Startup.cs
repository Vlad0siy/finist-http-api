using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace FinistAPI
{
   /* public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDatabaseContext>(options =>
            {
                options.UseSqlServer($"Data Source=localhost;Initial Catalog={nameof(AppDatabaseContext)};Integrated Security=True", x => x.MigrationsAssembly("FinistAPI"));
            });

            services.AddControllersWithViews();

            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}");
            });

            app.Run();
        }
    }*/
}