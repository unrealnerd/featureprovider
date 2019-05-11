using System;
using System.Collections.Generic;
using System.Linq;
using featureprovider.core.Models;
using Microsoft.Extensions.Configuration;

public class FeatureEvaluator
{
    private readonly IEnumerable<IFeatureEvaluator> FeatureEvaluators;
    public FeatureEvaluator(IEnumerable<IFeatureEvaluator> featureEvaluators) 
    {
        FeatureEvaluators = featureEvaluators;
    }
    public string Evaluate(string featureName, FeatureProviderEnum featureEvaluator = FeatureProviderEnum.Configuration)
    {        
        return FeatureEvaluators.Where(fe => fe.CanHandle(featureEvaluator)).FirstOrDefault()?.GetFeature(featureName);        
    }
}