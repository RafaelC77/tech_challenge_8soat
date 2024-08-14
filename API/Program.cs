using Application;
using Application.Repository;
using Application.UseCases;
using Infra;
using Infra.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region[Healthcheck]
#endregion

#region [DI]
ApplicationBootstrapper.Register(builder.Services);
InfraBootstrapper.Register(builder.Services);

builder.Services.AddScoped<IPedidoUseCase, PedidoUseCase>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();

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
