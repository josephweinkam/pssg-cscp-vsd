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
    /// QueryExpressionToFetchXmlResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMQueryExpressionToFetchXmlResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMQueryExpressionToFetchXmlResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMQueryExpressionToFetchXmlResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMQueryExpressionToFetchXmlResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMQueryExpressionToFetchXmlResponse(string fetchXml = default(string))
        {
            FetchXml = fetchXml;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FetchXml")]
        public string FetchXml { get; set; }

    }
}
