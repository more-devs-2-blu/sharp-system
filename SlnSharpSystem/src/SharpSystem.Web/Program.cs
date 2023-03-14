using Microsoft.EntityFrameworkCore;
using SharpSystem.Application.Services.SQLServerServices;
using SharpSystem.Domain.IRepositories.IUsuarioRepositories;
using SharpSystem.Domain.IServices;
using SharpSystem.Infra.Data.Context;
using SharpSystem.Infra.Data.Repositories;
using SharpSystem.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Conect SQL Server
var connectionStringUser = builder.Configuration.GetConnectionString("SQLServerConnection");
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer(connectionStringUser));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// ## Dependency Injection

// Repositories
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ISessaoService, SessaoService>();

// Services
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<INotaFicalService, NotaFiscalService>();

// Cookies
builder.Services.AddSession(o =>
{
    o.Cookie.HttpOnly = true;
    o.Cookie.IsEssential = true;
});

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
