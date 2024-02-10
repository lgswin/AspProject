using Microsoft.EntityFrameworkCore;
using BPMeasurement.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connstr = builder.Configuration.GetConnectionString("BloodPressureConnectionString");
builder.Services.AddDbContext<BPDbContext>(option => option.UseSqlServer(connstr));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

