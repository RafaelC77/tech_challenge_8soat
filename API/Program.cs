using Application;
using Application.Repository;
using Application.UseCases;
using Infra;
using Infra.Context;
using Infra.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<FastFoodDbContext>(
    options => options.UseNpgsql("Host=app_db;Port=5432;Database=SampleDbDriver;Username=postgres;Password=postgres"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region[Healthcheck]
#endregion

#region [DI]
ApplicationBootstrapper.Register(builder.Services);
InfraBootstrapper.Register(builder.Services);

builder.Services.AddScoped<IClienteUseCase, ClienteUseCase>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IPedidoUseCase, PedidoUseCase>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IProdutoUseCase, ProdutoUseCase>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

#endregion
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
