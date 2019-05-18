using System.Collections.Generic;
using featureprovider.core.Models;
using featureprovider.core.Utils;
using Microsoft.Extensions.Configuration;

namespace featureprovider.core.FeatureEvaluators
{
    public class ConfigurationEvaluator : IFeatureEvaluator
    {
        public bool CanHandle(string source)
        {
            return Constants.FeatureSourceConfiguration == source;
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