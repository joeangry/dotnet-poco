using Core.Models;

namespace Core.Configuration
{
    public interface IConfigurationWriter
    {
        string WriteConfiguration(ConfigurationModel configurationModel);
    }
}