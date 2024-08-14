using Application.Repository;
using Application.UseCases;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application;

public static class ApplicationBootstrapper
{
    public static void Register(IServiceCollection services)
    {
        services.AddTransient<IAuthenticationUseCase, AuthenticationUseCase>();
    }
}
