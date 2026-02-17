using Microsoft.EntityFrameworkCore;
using VictorMVCv1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Añadir todas las lineas desde la 9-15 para todos los proyectos, para que se pueda conectar a la base de datos
IConfiguration configuration = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json")
                                .AddEnvironmentVariables()
                                .Build();
builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlServer(configuration.GetConnectionString("Contexto")));
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
