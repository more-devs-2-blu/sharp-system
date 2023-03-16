using Microsoft.EntityFrameworkCore;
using SharpSystem.Application.Services.SQLServerServices;
using SharpSystem.Application.SQLServerServices.NFSServices;
using SharpSystem.Domain.IRepositories.INFSRespositories;
using SharpSystem.Domain.IRepositories.IUsuarioRepositories;
using SharpSystem.Domain.IServices;
using SharpSystem.Domain.IServices.INFSServices;
using SharpSystem.Infra.Data.Context;
using SharpSystem.Infra.Data.Repositories;
using SharpSystem.Infra.Data.Respositories.NFSRespositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Conect SQL Server
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer("Server=PCDOPH\\SQLEXPRESS;Database=SistemaXML;User Id=sa;Password=admin;TrustServerCertificate=True;Encrypt=False;"));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// ### Dependency Injection
// # Repositories
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IItensRepository, ItensRepository>();
builder.Services.AddScoped<IListaRepository, ListaRepository>();
builder.Services.AddScoped<INFSERespository, NFSERepository>();
builder.Services.AddScoped<INotaFiscalRepository, NotaFiscalRepository>();
builder.Services.AddScoped<IPrestadorRepository, PrestadorRepository>();
builder.Services.AddScoped<ITomadorRespository, TomadorRespository>();

// # Services
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IItensService, ItensService>();
builder.Services.AddScoped<IListaService, ListaService>();
builder.Services.AddScoped<INFSEService, NFSEService>();
builder.Services.AddScoped<INotaFicaslService, NotaFiscalService>();
builder.Services.AddScoped<IPrestadorService, PrestadorService>();
builder.Services.AddScoped<ITomadorService, TomadorService>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
