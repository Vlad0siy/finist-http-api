using FinistAPI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDatabaseContext>(options =>
{
    options.UseSqlServer($"Data Source=DESKTOP-PM78I88\\SQLEXPRESS;Initial Catalog=FinistTestDB;Integrated Security=True"/*, x => x.MigrationsAssembly("FinistAPI")*/);    
});

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

// Add services to the container.

//builder.Services.AddControllers();

var app = builder.Build();
// Configure the HTTP request pipeline.

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseHttpsRedirection();
app.UseRouting();
app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "default",
        template: "{controller}/{action}/{id?}");
});

app.Run();
