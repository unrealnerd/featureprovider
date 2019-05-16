using System.Collections.Generic;
using System.Text;
using featureprovider.core.Models;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace featureprovider.core.FeatureEvaluators
{
    public class RedisEvaluator : IFeatureEvaluator
    {
        public bool CanHandle(FeatureProviderEnum featureProvider)
        {
            return FeatureProviderEnum.Redis == featureProvider;
        }

        private readonly IDatabase RedisDb;

        public RedisEvaluator(string redisServerAddress)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(redisServerAddress);
            RedisDb = redis.GetDatabase();
        }

        public string GetFeature(string featureName)
        {
            return RedisDb.StringGet(featureName);
        }
    }

}