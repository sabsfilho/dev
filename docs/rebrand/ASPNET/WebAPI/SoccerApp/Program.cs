using SoccerApp.PlayerController;
using SoccerApp.TeamController;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/teamsbycountry/{country}", (string country) => TeamController.GetTeamsByCountry(country) )
.WithName("GetTeamsByCountry")
.WithOpenApi();

app.MapGet("/playersbyteam/{country}/{teamId}", (string country, string teamId) => PlayerController.GetPlayersByTeam(country, teamId) )
.WithName("GetPlayersByTeam")
.WithOpenApi();

app.Run();