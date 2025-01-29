var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<InMemorySwitchRepository>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Switches}/{action=Index}/{id?}");

app.Run();
