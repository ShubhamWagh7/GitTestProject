var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! This My First Changes Push and Pull in git");

app.Run();
