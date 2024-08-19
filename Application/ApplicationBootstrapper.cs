using Application.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ApplicationBootstrapper
{
    public static void Register(IServiceCollection services)
    {
        services.AddTransient<IAuthenticationUseCase, AuthenticationUseCase>();
        services.AddScoped<IClienteUseCase, ClienteUseCase>();
        services.AddScoped<IPedidoUseCase, PedidoUseCase>();
    }
}
