using App.Domain.AppService.Mayne.User.Costomer;
using App.Domain.Core.Mayne.Base.Data;
using App.Domain.Core.Mayne.Base.Services;
using App.Domain.Core.Mayne.Cars.Data;
using App.Domain.Core.Mayne.Cars.Service;
using App.Domain.Core.Mayne.History.Data;
using App.Domain.Core.Mayne.History.Service;
using App.Domain.Core.Mayne.Reservation.Data;
using App.Domain.Core.Mayne.User.AppService.CostomerAppService;
using App.Domain.Core.Mayne.User.Data.CostomerRepository;
using App.Domain.Core.Mayne.User.Services.CostomerService;
using App.Domain.Service.Mayne.Base;
using App.Domain.Service.Mayne.Car;
using App.Domain.Service.Mayne.History;
using App.Domain.Service.Mayne.User.Costomer;
using App.Infra.Db.SqlServer;
using App.Infra.Repo.Dapper.Mayne.Reservation;
using App.Infra.Repository.Ef.Mayne.Base;
using App.Infra.Repository.Ef.Mayne.Car;
using App.Infra.Repository.Ef.Mayne.History;
using App.Infra.Repository.Ef.Mayne.User.Costmer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MayneDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IDbConnection>(sp =>
	new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IcarService, CarService>();

builder.Services.AddScoped<ICarRepository, CarRepository>();




builder.Services.AddScoped<IBaseRepository, BaseRepository>();
builder.Services.AddScoped<IBaseService , BaseService>();



builder.Services.AddScoped<ICarHsitoryRepository, CarHistoryRepository>();
builder.Services.AddScoped<IHsitoryService, HistoryService>();


builder.Services.AddScoped<ICostomerRepository , CostomerRepository>();
builder.Services.AddScoped<ICostomerService, CostomerService>();
builder.Services.AddScoped<ICostomerAppService, CostomerAppService>();	

builder.Services.AddScoped<IReservationRepository , ReservationRepositoryDapper>();



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

//app.MapControllerRoute(

//	name: "areas",
//	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


//app.MapControllerRoute(

//	name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(

    name: "costomer",
    pattern: "{controller=Costomer}/{action=CostomerProfile}/{id?}");

app.Run();
