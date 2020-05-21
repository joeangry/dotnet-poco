using System.Text.Json;
using Core.Models;
using Core.Utilities;

namespace Core.Configuration
{
    public class JsonConfigurationReader : IConfigurationReader
    {
        public ConfigurationModel ReadConfiguration(string configurationFile)
        {
            Check.NotNull(configurationFile, nameof(configurationFile));
            return JsonSerializer.Deserialize<ConfigurationModel>(configurationFile);
        }
    }
}