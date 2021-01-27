namespace Configuration.Config
{
    public class URLSettings
    {
        public static string DemoMedeURL
        {
            get
            {
                return ConfigurationManager.GetJsonConfig.DemoURL;
            }
        }
    }
}
