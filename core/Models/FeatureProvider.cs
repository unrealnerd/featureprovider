namespace featureprovider.core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using featureprovider.core.Models;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Options;

    public class FeatureProvider : IFeatureProvider
    {
        private readonly IEnumerable<IFeatureEvaluator> FeatureEvaluators;
        private readonly string DefaultFeatureSource;
        public FeatureProvider(IEnumerable<IFeatureEvaluator> featureEvaluators,  IOptions<FeatureProviderOptions> options)
        {
            FeatureEvaluators = featureEvaluators;
            DefaultFeatureSource = options.Value.DefaultFeatureSource;
        }

        public string Evaluate(string featureName)
        {
            return FeatureEvaluators.Where(fe => fe.CanHandle(DefaultFeatureSource)).FirstOrDefault()?.GetFeature(featureName);
        }
        
        public string Evaluate(string featureName, string featureSource)
        {
            return FeatureEvaluators.Where(fe => fe.CanHandle(featureSource)).FirstOrDefault()?.GetFeature(featureName);
        }
    }
}