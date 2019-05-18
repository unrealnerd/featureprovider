using System.Collections.Generic;
using System.Text;
using featureprovider.core.Models;
using featureprovider.core.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using StackExchange.Redis;

namespace featureprovider.core.FeatureEvaluators
{
    public class RedisEvaluator : IFeatureEvaluator
    {
        public bool CanHandle(string source)
        {
            return Constants.FeatureSourceRedis == source;
        }

        private readonly IDatabase RedisDb;

        public RedisEvaluator(IOptions<FeatureProviderOptions> options)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(options.Value.RedisServer);
            RedisDb = redis.GetDatabase();
        }

        public string GetFeature(string featureName)
        {
            return RedisDb.StringGet(featureName);
        }
    }

}