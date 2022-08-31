using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using STShop.Database.Context.MainDb;
using STShop.Database.Infrastructure;

namespace STShop.Configuration.Service
{
    public static class DataLayerRegistration 
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUnitOfWork<MainDbContext>, UnitOfWork<MainDbContext>>();
            services.AddDbContext<MainDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("MainDbConnection")));
            return services;
        }
    }
}
