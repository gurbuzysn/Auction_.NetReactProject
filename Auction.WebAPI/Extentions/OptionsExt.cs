using Auction.Core.Common;

namespace Auction.WebAPI.Extentions
{
    public static class OptionsExt
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<StripeSettings>(options => configuration.GetSection("StripeSettings").Bind(options));
            return services;
        }

    }
}
