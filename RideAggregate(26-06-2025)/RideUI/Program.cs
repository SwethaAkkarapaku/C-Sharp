using Microsoft.AspNetCore.Authentication.Cookies;
using RideUI.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddCors(act =>
//{
//    act.AddPolicy("AllowAll", pol =>
//    {
//        pol.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
//    });
//});
builder.Services.AddHttpClient();
//builder.Services.Add

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
 .AddCookie(options =>
 {
     options.LoginPath = "/Accounts/Login";
 });
builder.Services.AddTransient<ClientServices>();
builder.Services.AddSession();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseRouting();

app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Accounts}/{action=Login}/{id?}")
    .WithStaticAssets();


app.Run();
