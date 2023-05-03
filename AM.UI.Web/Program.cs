using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IServiceFlight, ServiceFlight>();
builder.Services.AddScoped<IServicePlane, ServicePlane>();
//IServiceFlight = new ServiceFlight();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();//Obligatoire!!//
//IunitOfWork UOW = new UnitOfWork(dbContext, Type);
builder.Services.AddDbContext<DbContext, AmContexte>();//Obligatoire!!//
builder.Services
    .AddSingleton<Type>(p => typeof(GenericRepository<>));//Obligatoire!!//


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
