
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace featureprovider.core.Models
{
    public enum FeatureProviderEnum { Configuration, Redis };
    public interface IFeatureEvaluator
    {
        bool CanHandle(FeatureProviderEnum featureProvider);

        string GetFeature(string featureName);

    }
}
