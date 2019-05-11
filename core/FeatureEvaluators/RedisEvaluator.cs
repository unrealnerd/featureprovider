using System.Collections.Generic;
using featureprovider.core.Models;
using Microsoft.Extensions.Configuration;

namespace featureprovider.core.FeatureProviders
{
    public class RedisEvaluator : IFeatureEvaluator
    {
        public bool CanHandle(FeatureProviderEnum featureProvider)
        {
            return FeatureProviderEnum.Redis == featureProvider;
        }

        private readonly IConfiguration Configuration;

        public RedisEvaluator(IConfiguration configuration)
        {

        }

        public string GetFeature(string featureName)
        {
            return Configuration[featureName];
        }
    }

}