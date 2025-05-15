using App.Domain.Core.Mayne.Base.Data;
using App.Domain.Core.Mayne.Cars.Data;
using App.Domain.Core.Mayne.Reservation.Data;
using App.Domain.Core.Mayne.User.Data.CostomerRepository;
using App.Infra.Db.SqlServer;
using App.Infra.Repo.Dapper.Mayne.Reservation;
using App.Infra.Repository.Ef.Mayne.Base;
using App.Infra.Repository.Ef.Mayne.Car;
using App.Infra.Repository.Ef.Mayne.User.Costmer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MayneDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IDbConnection>(sp =>
	new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICarRepository, CarRepository>();


builder.Services.AddScoped<IBaseRepository, BaseRepository>();


builder.Services.AddScoped<IHistoryRepository, HistoryRepository>();


builder.Services.AddScoped<ICostomerRepository , CostomerRepository>();

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

app.MapControllerRoute(

	name: "areas",
	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(

	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
