using System.Collections.Generic;

namespace Core.Models
{
    public class ConfigurationModel
    {
        public string ConnectionString { get; set; }

        public string Namespace { get; set; }
        public string DbContextName { get; set; }
        public string DbContextOutputPath { get; set; }
        public string DbContextBaseClass { get; set; }

        public List<string> AdditionalUsings { get; set; }

        public bool WriteSeparateFiles { get; set; }
        public bool FolderForSchemaName { get; set; }
        public string PocoOutputPath { get; set; }

        // TODO These are not implemented yet
        public List<string> InterfacesOnContext { get; set; }
        public List<string> InterfacesOnModels { get; set; }
        public bool UseDataAnnotations { get; set; }
        
        public IList<string> IgnoredTables { get; set; } = new List<string>();
        public Dictionary<string, string> IgnoredColumns { get; set; } = new Dictionary<string, string>();
    }
}