using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;
using ScreenSound.API.Endpoints;
using ScreenSound.Banco;
using ScreenSound.Modelos;
using ScreenSound.Shared.Modelos.Modelos;

var builder = WebApplication.CreateBuilder(args);

// 1. Adiciona os serviços de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", // Você pode dar o nome que quiser para a política
        builder => builder.WithOrigins("http://localhost:5099") // Substitua pelas portas onde seu Blazor pode rodar. Se não souber, use AllowAnyOrigin para desenvolvimento.
                         .AllowAnyMethod() // Permite todos os métodos (GET, POST, PUT, DELETE, etc.)
                         .AllowAnyHeader()); // Permite todos os cabeçalhos
});

builder.Services.AddDbContext<ScreenSoundContext>();
builder.Services.AddTransient<DAL<Artista>>();
builder.Services.AddTransient<DAL<Musica>>();
builder.Services.AddTransient<DAL<Genero>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();
// Configure the HTTP request pipeline.
// 2. Adiciona o middleware de CORS - Coloque ANTES do UseSwagger e MapEndpoints!
app.UseCors("AllowSpecificOrigin"); // Usa a política de CORS que definimos

// Configure Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.AddEndpointsMusicas();
app.AddEndpointsArtistas();
app.addEndPointsGeneros();

app.Run();