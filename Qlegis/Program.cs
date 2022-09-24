using Microsoft.EntityFrameworkCore;
using Qlegis.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
// https://www.youtube.com/watch?v=zr3QiQDZ0-k&ab_channel=DEVNETCOREValdirFerreira
builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer
    ("Data Source=BR\\SQLEXPRESS;Initial Catalog=a;Integrated Security=False;User ID=sa;Password=123456;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"));


//builder.Services.AddDbContext<BancoContext>
//  (options => options.UseMySql(
//    "server=localhost;initial catalog=qlegis;uid=root;pwd=123456",
//  Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql")));

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
