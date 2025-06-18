using MiddlewareExample;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.Use(async (ctx, nxt) =>
    {
        await ctx.Response.WriteAsync("Inside Middleware A before");
        await nxt.Invoke();
        await ctx.Response.WriteAsync("Inside Middleware B After");
    });
app.Use(async (ctx, nxt) =>
{
    await ctx.Response.WriteAsync("Inside Middleware P before");
    await nxt.Invoke();
    await ctx.Response.WriteAsync("Inside Middleware Q After");
});

app.UseMiddleware<MyTestMW>();
app.Run();
