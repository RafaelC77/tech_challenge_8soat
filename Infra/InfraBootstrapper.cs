using Application.Repository;
using Infra.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra;

public static class InfraBootstrapper
{
    public static void Register(IServiceCollection services)
    {
        services.AddTransient<IAuthenticationRepository, AuthenticationRepository>();
        services.AddScoped<IPedidoRepository, PedidoRepository>();
        services.AddScoped<IClienteRepository, ClienteRepository>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
    }
}
