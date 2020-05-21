using Core.Models;
using Core.Utilities;
using YamlDotNet.Serialization;

namespace Core.Configuration
{
    public class YamlConfigurationWriter : IConfigurationWriter
    {
        private readonly ISerializer _serializer;

        public YamlConfigurationWriter(ISerializer serializer)
        {
            _serializer = serializer;
        }

        public string WriteConfiguration(ConfigurationModel configurationModel)
        {
            Check.NotNull(configurationModel, nameof(configurationModel));
            
            var yaml = _serializer.Serialize(configurationModel);

            return yaml;
        }
    }
}