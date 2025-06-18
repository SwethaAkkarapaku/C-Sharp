namespace MiddlewareExample
{
    public class MyTestMW
    {
        private RequestDelegate _next;
        public MyTestMW(RequestDelegate next) 
        { 
            _next = next; 
        }
        public async Task InvokeAsync(HttpContext ctx)
        {
            //await ctx.Response.WriteAsJsonAsync("From MyTestMW");
            await _next.Invoke(ctx);
        }
    }
}
