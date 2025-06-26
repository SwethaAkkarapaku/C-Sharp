using Microsoft.EntityFrameworkCore;
using RideAPI.Data;
using RideAPI.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

string sqlBuilder = builder.Configuration.GetConnectionString("DbCon");
builder.Services.AddDbContext<RideDbContext>(cfg =>
{
    cfg.UseSqlServer(sqlBuilder);
});

builder.Services.AddTransient<DbAccess>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
