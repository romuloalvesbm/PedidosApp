using PedidosApp.Infra.Data.Extensions;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

//Mapeamento para que os endpoints sejam exibidos em caixa-baixa
builder.Services.AddRouting(map => map.LowercaseUrls = true);

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Adicionando os métodos de extensão para injeção de dependência
builder.Services.AddEntityFrameworkExtension(builder.Configuration);

var app = builder.Build();

app.MapOpenApi();

//Swagger
app.UseSwagger();
app.UseSwaggerUI();

//Scalar
app.MapScalarApiReference(options =>
{
    options.WithTheme(ScalarTheme.BluePlanet);
});

app.UseAuthorization();
app.MapControllers();
app.Run();

public partial class Program { }


