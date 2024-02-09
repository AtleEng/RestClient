using Data;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("/", DataManager.GetMain);
app.MapGet("/{container}", DataManager.GetContainerMenu);
app.MapGet("/{container}/{id}", DataManager.GetEnemy);

app.Urls.Add("http://*:7084");

app.Run();