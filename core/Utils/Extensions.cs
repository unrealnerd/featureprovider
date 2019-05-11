namespace featureprovider.core.Utils
{
    public static class Extensions
    {
        public static bool ToBool(this string str)
        {
            return bool.Parse(str);
        }
    }
    
}