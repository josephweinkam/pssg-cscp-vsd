// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.VictimServices.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ComponentDetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMComponentDetail
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComponentDetail class.
        /// </summary>
        public MicrosoftDynamicsCRMComponentDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComponentDetail class.
        /// </summary>
        public MicrosoftDynamicsCRMComponentDetail(int? type = default(int?), string schemaName = default(string), string displayName = default(string), string id = default(string), string parentSchemaName = default(string), string parentDisplayName = default(string), string parentId = default(string), string solution = default(string))
        {
            Type = type;
            SchemaName = schemaName;
            DisplayName = displayName;
            Id = id;
            ParentSchemaName = parentSchemaName;
            ParentDisplayName = parentDisplayName;
            ParentId = parentId;
            Solution = solution;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentSchemaName")]
        public string ParentSchemaName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentDisplayName")]
        public string ParentDisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentId")]
        public string ParentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Solution")]
        public string Solution { get; set; }

    }
}
