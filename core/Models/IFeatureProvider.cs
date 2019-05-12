namespace featureprovider.core.Models
{
    public interface IFeatureProvider
    {
        string Evaluate(string featureName, FeatureProviderEnum featureEvaluator = FeatureProviderEnum.Configuration);
    }
}