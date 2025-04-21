using System.Text.Json.Serialization;
using ScreenSound.API.Endpoints;
using ScreenSound.Banco;
using ScreenSound.Modelos;
using ScreenSound.Shared.Modelos.Modelos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ScreenSoundContext>();
builder.Services.AddTransient<DAL<Artista>>();
builder.Services.AddTransient<DAL<Musica>>();
builder.Services.AddTransient<DAL<Genero>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Adicione o serviço de CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:5099") // A URL do seu Blazor
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Habilite o CORS
app.UseCors();

app.UseStaticFiles();

app.AddEndpointsMusicas();
app.AddEndpointsArtistas();
app.addEndPointsGeneros();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();