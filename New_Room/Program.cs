using Microsoft.EntityFrameworkCore;
using RoomManagementMVCApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string sqlConString=builder.Configuration.GetConnectionString("DbCon");
builder.Services.AddDbContext<RoomManagementDbContext>(cfg=>
{
    cfg.UseSqlServer(sqlConString);
}
);
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
    pattern: "{controller=AddRoom}/{action=Add}/{id?}");

app.Run();
