using Microsoft.Extensions.DependencyInjection;

namespace STShop.Configuration.Service
{
    public static class MapperRegistration
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); 
            return services;
        }
    }
}
