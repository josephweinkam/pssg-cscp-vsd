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
    /// opportunityclose
    /// </summary>
    public partial class MicrosoftDynamicsCRMopportunityclose
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunityclose class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunityclose()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunityclose class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunityclose(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _opportunityidValue = default(string), string subcategory = default(string), int? importsequencenumber = default(int?), string category = default(string), object actualrevenueBase = default(object), string _competitoridValue = default(string), object actualrevenue = default(object), MicrosoftDynamicsCRMservice serviceidOpportunityclose = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMasyncoperation> opportunityCloseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMsyncerror> opportunityCloseSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser owninguserOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidOpportunityclose = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMbulkdeletefailure> opportunityCloseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcompetitor competitorid = default(MicrosoftDynamicsCRMcompetitor), IList<MicrosoftDynamicsCRMactivityparty> opportunitycloseActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMsystemuser modifiedbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMannotation> opportunityCloseAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMteam owningteamOpportunityclose = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMbusinessunit owningbusinessunitOpportunityclose = default(MicrosoftDynamicsCRMbusinessunit))
        {
            Overriddencreatedon = overriddencreatedon;
            this._opportunityidValue = _opportunityidValue;
            Subcategory = subcategory;
            Importsequencenumber = importsequencenumber;
            Category = category;
            ActualrevenueBase = actualrevenueBase;
            this._competitoridValue = _competitoridValue;
            Actualrevenue = actualrevenue;
            ServiceidOpportunityclose = serviceidOpportunityclose;
            OpportunityCloseAsyncOperations = opportunityCloseAsyncOperations;
            OpportunityCloseSyncErrors = opportunityCloseSyncErrors;
            OwninguserOpportunityclose = owninguserOpportunityclose;
            TransactioncurrencyidOpportunityclose = transactioncurrencyidOpportunityclose;
            ModifiedonbehalfbyOpportunityclose = modifiedonbehalfbyOpportunityclose;
            ActivityidActivitypointer = activityidActivitypointer;
            Opportunityid = opportunityid;
            OpportunityCloseBulkDeleteFailures = opportunityCloseBulkDeleteFailures;
            CreatedbyOpportunityclose = createdbyOpportunityclose;
            Competitorid = competitorid;
            OpportunitycloseActivityParties = opportunitycloseActivityParties;
            ModifiedbyOpportunityclose = modifiedbyOpportunityclose;
            CreatedonbehalfbyOpportunityclose = createdonbehalfbyOpportunityclose;
            OpportunityCloseAnnotation = opportunityCloseAnnotation;
            OwningteamOpportunityclose = owningteamOpportunityclose;
            OwningbusinessunitOpportunityclose = owningbusinessunitOpportunityclose;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

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
        [JsonProperty(PropertyName = "actualrevenue_base")]
        public object ActualrevenueBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_competitorid_value")]
        public string _competitoridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualrevenue")]
        public object Actualrevenue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_opportunityclose")]
        public MicrosoftDynamicsCRMservice ServiceidOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> OpportunityCloseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> OpportunityCloseSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser OwninguserOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_opportunityclose")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> OpportunityCloseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorid")]
        public MicrosoftDynamicsCRMcompetitor Competitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityclose_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> OpportunitycloseActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> OpportunityCloseAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_opportunityclose")]
        public MicrosoftDynamicsCRMteam OwningteamOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_opportunityclose")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitOpportunityclose { get; set; }

    }
}
