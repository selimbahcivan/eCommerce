using Microsoft.Extensions.Configuration;

namespace ECommerceProject.Persistence
{
    internal static class Configuration
    {
        public static string ConfigurationString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory()
                    /*"ECommerceProject/Presentation/ECommerceProject.API"*/));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
