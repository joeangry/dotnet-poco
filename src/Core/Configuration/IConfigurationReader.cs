using Core.Models;

namespace Core.Configuration
{
    public interface IConfigurationReader
    {
        ConfigurationModel ReadConfiguration(string configurationFile);
    }
}