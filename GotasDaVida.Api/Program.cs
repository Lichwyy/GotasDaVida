using GotasDaVida.Application.UseCases.CreateCadastro;
using GotasDaVida.Domain.Cadastros.Repositories;
using GotasDaVida.Domain.Common;
using GotasDaVida.Application.Services;
using GotasDaVida.Infrastructure.Persistence.Context;
using GotasDaVida.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// OpenAPI
builder.Services.AddOpenApi();



// Repositories
builder.Services.AddScoped<ICadastroRepository, CadastroRepository>();
builder.Services.AddScoped<CreateCadastroUseCase>();
builder.Services.AddScoped<IFoundryService, FoundryService>();
// DbContext
builder.Services.AddDbContext<GotasDaVidaDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Gera o OpenAPI
    app.MapOpenApi();

    // Interface do Scalar
    app.MapScalarApiReference(options =>
    {
        options.Title = "GotasDaVida API";
        options.Theme = ScalarTheme.BluePlanet;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();