// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.VictimServices.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// quoteclose
    /// </summary>
    public partial class MicrosoftDynamicsCRMquoteclose
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquoteclose
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMquoteclose()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMquoteclose
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMquoteclose(string quotenumber = default(string), int? importsequencenumber = default(int?), string category = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string subcategory = default(string), int? revision = default(int?), string _quoteidValue = default(string), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMservice serviceidQuoteclose = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMquote quoteid = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMsystemuser createdonbehalfbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> quoteCloseSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> quoteCloseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMannotation> quoteCloseAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMactivityparty> quotecloseActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMbulkdeletefailure> quoteCloseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMbusinessunit owningbusinessunitQuoteclose = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser owninguserQuoteclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamQuoteclose = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser createdbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyQuoteclose = default(MicrosoftDynamicsCRMsystemuser))
        {
            Quotenumber = quotenumber;
            Importsequencenumber = importsequencenumber;
            Category = category;
            Overriddencreatedon = overriddencreatedon;
            Subcategory = subcategory;
            Revision = revision;
            this._quoteidValue = _quoteidValue;
            ModifiedonbehalfbyQuoteclose = modifiedonbehalfbyQuoteclose;
            ServiceidQuoteclose = serviceidQuoteclose;
            Quoteid = quoteid;
            ActivityidActivitypointer = activityidActivitypointer;
            CreatedonbehalfbyQuoteclose = createdonbehalfbyQuoteclose;
            QuoteCloseSyncErrors = quoteCloseSyncErrors;
            QuoteCloseAsyncOperations = quoteCloseAsyncOperations;
            QuoteCloseAnnotation = quoteCloseAnnotation;
            QuotecloseActivityParties = quotecloseActivityParties;
            QuoteCloseBulkDeleteFailures = quoteCloseBulkDeleteFailures;
            OwningbusinessunitQuoteclose = owningbusinessunitQuoteclose;
            OwninguserQuoteclose = owninguserQuoteclose;
            OwningteamQuoteclose = owningteamQuoteclose;
            CreatedbyQuoteclose = createdbyQuoteclose;
            ModifiedbyQuoteclose = modifiedbyQuoteclose;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quotenumber")]
        public string Quotenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_quoteid_value")]
        public string _quoteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_quoteclose")]
        public MicrosoftDynamicsCRMservice ServiceidQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteid")]
        public MicrosoftDynamicsCRMquote Quoteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> QuoteCloseSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QuoteCloseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> QuoteCloseAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> QuotecloseActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuoteClose_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QuoteCloseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_quoteclose")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser OwninguserQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_quoteclose")]
        public MicrosoftDynamicsCRMteam OwningteamQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyQuoteclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_quoteclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyQuoteclose { get; set; }

    }
}
