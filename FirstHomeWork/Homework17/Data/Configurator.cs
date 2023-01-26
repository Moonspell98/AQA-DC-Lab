using Microsoft.Extensions.Configuration;

namespace Homework17.Data
{
    public class Configurator
    {
        public static string LocalAdnonetDbConnectionString { get; set; }

        public static IConfiguration DataBaseConfiguration { get; } = new ConfigurationBuilder().AddJsonFile("config.json").Build();

        static Configurator()
        {
            LocalAdnonetDbConnectionString = DataBaseConfiguration["connectionStrings:LocalAdnonetDb"];
        }

    }
}
