using featureprovider.core.FeatureEvaluators;
using featureprovider.core.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace featureprovider.core.Registry
{
    public static class ServiceRegistry
    {
        public static IServiceCollection AddFeatureProvider(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<FeatureProviderOptions>(config.GetSection("FeatureProvider"));
            services.AddSingleton<IFeatureEvaluator, ConfigurationEvaluator>();
            services.AddSingleton<IFeatureEvaluator, RedisEvaluator>();
            services.AddSingleton<IFeatureProvider, FeatureProvider>();
            
            return services;
        }

    }
}