using Calculate.Component;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents().AddInteractiveServerComponents();

var app = builder.Build();

app.UseAntiforgery();

app.MapRazorComponents<Home>().AddInteractiveServerRenderMode();

//app.MapGet("/", () => "Hello World!");

app.Run();
