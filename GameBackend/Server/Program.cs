using RandomMemories.Contracts;
using RandomMemories.Domain;
using RandomMemories.FactoryImplementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IRandomMemoriesDataStorage>(_ => new RandomMemoriesDataStorageFactory().CreateRandomMemoriesDataStorage(String.Empty));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Any code to run if its dev
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


void AddSwagger()
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

void AppEnableSwagger()
{
    app.UseSwagger();
    app.UseSwaggerUI();
}