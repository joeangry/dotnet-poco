using System.Text.Json;
using Core.Models;
using Core.Utilities;

namespace Core.Configuration
{
    public class JsonConfigurationWriter : IConfigurationWriter
    {
        public string WriteConfiguration(ConfigurationModel configurationModel)
        {
            Check.NotNull(configurationModel, nameof(configurationModel));
            return JsonSerializer.Serialize(configurationModel);
        }
    }
}