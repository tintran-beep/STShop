using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace STShop.Configuration.Application
{
    public static class MigrationExtension
    {
        public static IServiceProvider AutoMigration(this IServiceProvider service)
        {
            using (var scope = service.CreateScope())
            {
                var dataContext = scope.ServiceProvider.GetRequiredService<Database.Context.MainDb.MainDbContext>();
                dataContext.Database.Migrate();
            }
            return service;
        }
    }
}
