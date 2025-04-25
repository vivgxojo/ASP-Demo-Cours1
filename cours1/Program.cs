var builder = WebApplication.CreateBuilder(args);

//Initialiser les vues et contr�leurs
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

//Associer les routes (URL) aux action de contr�leurs
app.MapControllerRoute(
    name: "default",
    defaults: new { controller = "Etudiant" },
    pattern: "{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
