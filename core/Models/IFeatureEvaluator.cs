
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace featureprovider.core.Models
{
    public interface IFeatureEvaluator
    {
        bool CanHandle(string source);

        string GetFeature(string featureName);

    }
}
