var builder = WebApplication.CreateBuilder(args);
// Menambahkan Middleware MVC
builder.Services.AddControllersWithViews();
var app = builder.Build();
// app.MapGet("/", () => "Hello World!");

//Konfigurasi Request Http
app.UseStaticFiles();

//Konfigurasi Routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{Action=Index}/{Id?}");
app.Run();
