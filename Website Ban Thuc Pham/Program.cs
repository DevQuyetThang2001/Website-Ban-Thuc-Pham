using Microsoft.EntityFrameworkCore;
using Website_Ban_Thuc_Pham.Models;
using Website_Ban_Thuc_Pham.Reponsitory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("Bantraicayraucu1Context");
builder.Services.AddDbContext<Bantraicayraucu1Context>(x=>x.UseSqlServer(connectionString));

builder.Services.AddScoped<ILoaiSpReponsitory, LoaiSpReponsitory>();

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
