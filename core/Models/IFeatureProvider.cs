using featureprovider.core.Utils;

namespace featureprovider.core.Models
{
    public interface IFeatureProvider
    {
        string Evaluate(string featureName);
        string Evaluate(string featureName, string featureSource);
    }
}