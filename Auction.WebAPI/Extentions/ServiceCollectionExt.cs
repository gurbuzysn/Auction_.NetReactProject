using Auction.Business.Abstraction;
using Auction.Business.Concrete;
using Auction.Core.Models;

namespace Auction.WebAPI.Extentions
{
    public static class ServiceCollectionExt
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            #region Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped(typeof(ApiResponse));
            #endregion

            return services;
        }
    }
}
