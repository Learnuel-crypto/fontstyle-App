using EncryptString;
using System.Configuration;

namespace WindowsFormsApplication1.Modification.Models.Helper
{
    public class AppSettings :   IAppSettings
    {
        private Configuration config;

        private string defaultConnString =
            "yqV+V9oz+FWy0NBj20nKMOGU840L4tKDlrrbXMSvjW8MZF4lAYFREqYRahKX+q9MxaidASd1RuDyOv84t+Dnh1+X3Mnuuh9xpxQVm3tyOZmvHM3isANSiSpvtcBzmfVNyqV+V9oz+FWy0NBj20nKMOGU840L4tKDlrrbXMSvjW8MZF4lAYFREqYRahKX+q9MxaidASd1RuDyOv84t+Dnh1+X3Mnuuh9xpxQVm3tyOZmvHM3isANSiSpvtcBzmfVN";
        public AppSettings()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }


        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void SaveConnectionString(string key, string value)
        {
            StringEncryptor StrCrypt = new StringEncryptor();
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = StrCrypt.Encrypt(value);
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Date.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }

        public void DefaultConnectionString(string key)
        {
            StringEncryptor StrCrypt = new StringEncryptor();
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = defaultConnString;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Date.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
