using Client.Interfaces;
using Client.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Client
{
    public static class DepInj
    {
        public static void RegisterGoogleMapsClient(
            this IServiceCollection services, Action<GoogleMapsOptions> config)
        {
            services.ConfigureServiceOptions<GoogleMapsOptions>((_, opt) => config(opt));
            services.AddTransient<IGoogleMapsClient, GoogleMapsClient>();
        }
        
        private static void ConfigureServiceOptions<TOptions>(
            this IServiceCollection services,
            Action<IServiceProvider, TOptions> configure)
            where TOptions : class
        {
            services
                .AddOptions<TOptions>()
                .Configure<IServiceProvider>((options, resolver) => configure(resolver, options));
        }
    }
}