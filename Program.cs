using Microsoft.EntityFrameworkCore;
using MyVideostore.Data;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Register the ApplicationDbContext with SQL Server (use your actual connection string)
IServiceCollection serviceCollection = builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
IMvcBuilder mvcBuilder = builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();

// Configure middleware pipeline
if (app.Environment.IsDevelopment())
{
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Map controller routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
