namespace WindowsFormsApplication1.Modification.Models.Helper
{
    public interface IAppSettings
    {
        void DefaultConnectionString(string key);
        string GetConnectionString(string key);
        void SaveConnectionString(string key, string value);
    }
}