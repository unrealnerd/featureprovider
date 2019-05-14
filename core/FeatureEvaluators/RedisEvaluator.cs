using System.Collections.Generic;
using System.Text;
using featureprovider.core.Models;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;

namespace featureprovider.core.FeatureEvaluators
{
    public class RedisEvaluator : IFeatureEvaluator
    {
        public bool CanHandle(FeatureProviderEnum featureProvider)
        {
            return FeatureProviderEnum.Redis == featureProvider;
        }

        private readonly IDistributedCache DistributedCache;

        public RedisEvaluator(IDistributedCache distributedCache)
        {
            DistributedCache = distributedCache;
        }

        public string GetFeature(string featureName)
        {
            return DistributedCache.GetString(featureName);
        }
    }

}