using featureprovider.core.FeatureEvaluators;
using featureprovider.core.Models;
using Microsoft.Extensions.DependencyInjection;

namespace featureprovider.core.Registry
{
    public static class ServiceRegistry
    {
        public static IServiceCollection AddFeatureProvider(this IServiceCollection services, string serverAddress)
        {
            services.AddSingleton<IFeatureProvider, FeatureProvider>();
            services.AddSingleton<IFeatureEvaluator, ConfigurationEvaluator>();
            services.AddSingleton<IFeatureEvaluator>(new RedisEvaluator(serverAddress));          

            return services;
        }
        
    }
}