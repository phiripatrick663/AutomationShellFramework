namespace Configuration.Config
{
    public class LoginSettings
    {
        public static string[] User
        {

            get
            {
                string[] logininfo = new string[2];
                logininfo[0] = ConfigurationManager.GetJsonConfig.UserName;
                logininfo[1] = ConfigurationManager.GetJsonConfig.Password;
                return logininfo;
            }
        }
    }
}
