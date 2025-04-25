var builder = WebApplication.CreateBuilder(args);

//Initialiser les vues et contrôleurs
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Associer les routes (URL) aux action de contrôleurs
app.MapControllerRoute(
    name: "default",
    defaults: new { controller = "Home" },
    pattern: "{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
