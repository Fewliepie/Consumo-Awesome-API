using ConsumoAPI_Dolar.Interfaces;
using ConsumoAPI_Dolar.Mappings;
using ConsumoAPI_Dolar.Rest;
using ConsumoAPI_Dolar.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IMoedasService, MoedasService>();
builder.Services.AddSingleton<IAwesomeApi, AwesomeApiRest>();

builder.Services.AddAutoMapper(typeof(MoedasMapping));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
