using MVCCoreApp.Infra;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<BDService>();//Dependency injection 
//AddTransient will create new object every time we inject that into
//builder.Services.AddScoped<BDService>();//Scoped object between request and response
//BDService bDService = new BDService();
//builder.Services.AddSingleton<BDService>(bDService);
//builder.Services.AddSingleton(typeof(BDService));

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
