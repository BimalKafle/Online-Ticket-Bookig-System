using Ticketing.Core.Repository;
using Ticketing.Core.Services;
using Ticketing.Core.Services.ServiceInterface;
using Ticketing.Data.Repository;

namespace Ticketing.DiConfig
{
    public static class DiConfiguration
    {
        public static void UseDIConfiguration(this IServiceCollection services)
        {
            UseRepository(services);
            UserService(services);
        }

        private static void UseRepository(this IServiceCollection services)
        {
            services.AddScoped<CityRepositoryInterface, CityRepository>();
            services.AddScoped<VehicleCategoryRepositoryInterface, VehicleCategoryRepository>();
           

        }
        private static void UserService(this IServiceCollection services)
        {
            services.AddScoped<CityServiceInterface, CityService>();
            services.AddScoped<VehicleCategoryServiceInterface, VehicleCategoryService>();
           
        }
    }
}
