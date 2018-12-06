using System.Collections.Generic;
using System.Configuration;
using System.Linq;


namespace RedisViewer.Services
{
    public static class Settings
    {
        public static Dictionary<string, string> GetConnections()
        {
            return ConfigurationManager.ConnectionStrings.Cast<ConnectionStringSettings>().ToDictionary(v => v.Name, v => v.ConnectionString);
        }
    }
}