using Core.Models;
using Core.Utilities;
using YamlDotNet.Serialization;

namespace Core.Configuration
{
    public class YamlConfigurationReader : IConfigurationReader
    {
        private readonly IDeserializer _deserializer;
        public YamlConfigurationReader()
        {
            _deserializer = new Deserializer();
        }

        public ConfigurationModel ReadConfiguration(string configurationFile)
        {
            Check.NotNull(configurationFile, nameof(configurationFile));
            return _deserializer.Deserialize<ConfigurationModel>(configurationFile);
        }
    }
}