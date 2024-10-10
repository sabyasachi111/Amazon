using AspNetCoreHero.ToastNotification;
using DataLayer.DataContext;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AmazonDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnectionString")));
builder.Services.AddNotyf(
    Config =>
    {
        Config.DurationInSeconds = 10; Config.IsDismissable = true;
        Config.Position = NotyfPosition.TopRight;
    }
    );
builder.Services.AddSession();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
