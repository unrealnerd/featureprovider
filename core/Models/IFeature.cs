namespace featureprovider.core.Models
{
    public interface IFeature
    {
        bool IsFeatureEnabled(string feature);
    }
}