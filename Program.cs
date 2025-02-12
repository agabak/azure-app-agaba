var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello, from the web");

app.Run(async (HttpContext httpContext) =>
{
    httpContext.Response.StatusCode = 400;
    await httpContext.Response.WriteAsync("Hello there from http word");
});

app.Run();
