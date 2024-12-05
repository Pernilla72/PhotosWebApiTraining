using PhotosMvc.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<DataService>();
var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();