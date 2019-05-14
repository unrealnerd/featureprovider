namespace featureprovider.core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using featureprovider.core.Models;
    using Microsoft.Extensions.Configuration;

    public class FeatureProvider : IFeatureProvider
    {
        private readonly IEnumerable<IFeatureEvaluator> FeatureEvaluators;
        private readonly FeatureProviderEnum DefaultFeatureProviderEnum;
        public FeatureProvider(IEnumerable<IFeatureEvaluator> featureEvaluators, FeatureProviderEnum defaultFeatureProviderEnum)
        {
            FeatureEvaluators = featureEvaluators;
            DefaultFeatureProviderEnum = defaultFeatureProviderEnum;
        }

        public string Evaluate(string featureName)
        {
            return FeatureEvaluators.Where(fe => fe.CanHandle(DefaultFeatureProviderEnum)).FirstOrDefault()?.GetFeature(featureName);
        }
        
        public string Evaluate(string featureName, FeatureProviderEnum featureEvaluator)
        {
            return FeatureEvaluators.Where(fe => fe.CanHandle(featureEvaluator)).FirstOrDefault()?.GetFeature(featureName);
        }
    }
}