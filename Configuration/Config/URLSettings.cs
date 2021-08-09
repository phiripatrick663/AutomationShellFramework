namespace Configuration.Config
{
    public class URLSettings
    {
        public static string DemoURL
        {
            get
            {
                return ConfigurationManager.GetJsonConfig.DemoURL;
            }
        }

        public static string DemoProjectURL
        {
            get
            {
                return ConfigurationManager.GetJsonConfig.DemoProjectURL;
            }
        }
    }
}
