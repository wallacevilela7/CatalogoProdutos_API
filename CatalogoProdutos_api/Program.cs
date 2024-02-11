using CatalogoProdutos_api.Models.Context;
using CatalogoProdutos_api.Services.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connection = builder.Configuration["ConnectionStrings:SqlServerConnectionString"];
builder.Services.AddDbContext<SqlServerContext>(options => options.UseSqlServer(connection));

builder.Services.AddScoped<IProdutoService, ProdutoServiceImplementation>();

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
