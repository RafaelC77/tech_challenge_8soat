using Microsoft.EntityFrameworkCore;
using Infra.Context;

namespace API.Extensions;

public static class MigrationExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        using FastFoodDbContext dbContext = scope.ServiceProvider.GetRequiredService<FastFoodDbContext>();

        dbContext.Database.Migrate();
    }
}