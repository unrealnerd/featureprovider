using System.Collections.Generic;
using featureprovider.core.Models;
using Microsoft.Extensions.Configuration;

namespace featureprovider.core.FeatureEvaluators
{
    public class ConfigurationEvaluator : IFeatureEvaluator
    {
        public bool CanHandle(FeatureProviderEnum featureProvider)
        {
            return FeatureProviderEnum.Configuration == featureProvider;
        }

        private readonly IConfiguration Configuration;

        public ConfigurationEvaluator(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string GetFeature(string featureName)
        {
            return Configuration[featureName];
        }
    }

}