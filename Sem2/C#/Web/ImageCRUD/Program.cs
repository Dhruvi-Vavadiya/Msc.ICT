using ImageCRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using ImageCRUD.Data;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
//connectionstring register
var provider = builder.Services.BuildServiceProvider();
var config = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<CUsersPlanetOneDriveDocumentsDhruviMdfContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ImageCRUDContext") ?? throw new InvalidOperationException("Connection string 'ImageCRUDContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();//1
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();//1

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
