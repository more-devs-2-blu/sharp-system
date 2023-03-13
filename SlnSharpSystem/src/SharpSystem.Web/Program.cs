using Microsoft.EntityFrameworkCore;
using SharpSystem.Application.Services.SQLServerServices;
using SharpSystem.Domain.IRepositories.IUsuarioRepositories;
using SharpSystem.Domain.IServices;
using SharpSystem.Infra.Data.Context;
using SharpSystem.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Conect SQL Server
var connectionStringUser = builder.Configuration.GetConnectionString("SQLServerConnection");
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer(connectionStringUser));

// ## Dependency Injection

// Repositories
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

// Services
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

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
