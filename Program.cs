using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Menambahkan Middleware MVC
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Mengambil Konfigurasi DefaultConnection
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
// Menambahkan file dbContext ke builder
builder.Services.AddDbContext<PortfoliodbContext>
// Menambahkan koneksi kedatabase
(options => options.UseNpgsql(connection));


//Konfigurasi Request Http
app.UseStaticFiles();

//Menambahkan Routing
app.UseRouting();

//Konfigurasi Routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{Action=Index}/{Id?}");
app.Run();
