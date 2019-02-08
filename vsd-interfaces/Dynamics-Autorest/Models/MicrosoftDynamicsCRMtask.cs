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
    /// task
    /// </summary>
    public partial class MicrosoftDynamicsCRMtask
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtask class.
        /// </summary>
        public MicrosoftDynamicsCRMtask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtask class.
        /// </summary>
        public MicrosoftDynamicsCRMtask(int? importsequencenumber = default(int?), string subcategory = default(string), string category = default(string), string subscriptionid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? percentcomplete = default(int?), string crmtaskassigneduniqueid = default(string), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementTask = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateTask = default(MicrosoftDynamicsCRMentitlementtemplate), IList<MicrosoftDynamicsCRMpostregarding> taskPostRegardings = default(IList<MicrosoftDynamicsCRMpostregarding>), IList<MicrosoftDynamicsCRMpostfollow> taskPostFollows = default(IList<MicrosoftDynamicsCRMpostfollow>), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingTask = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderTask = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordTask = default(MicrosoftDynamicsCRMknowledgebaserecord), IList<MicrosoftDynamicsCRMconnection> taskConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsla slaTaskSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMduplicaterecord> taskDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceTask = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMlead regardingobjectidLeadTask = default(MicrosoftDynamicsCRMlead), IList<MicrosoftDynamicsCRMduplicaterecord> taskDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMcontact regardingobjectidContactTask = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMteam owningteamTask = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMquote regardingobjectidQuoteTask = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityTask = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMbusinessunit owningbusinessunitTask = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMconnection> taskConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsla slainvokedidTaskSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidTask = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMservice serviceidTask = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignTask = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMactivityparty> taskActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceTask = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMaccount regardingobjectidAccountTask = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMannotation> taskAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMsystemuser modifiedbyTask = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdbyTask = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMasyncoperation> taskAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleTask = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser createdonbehalfbyTask = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> taskSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityTask = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMcontract regardingobjectidContractTask = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderTask = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMsystemuser owninguserTask = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyTask = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMqueueitem> taskQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMactioncard> taskActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), MicrosoftDynamicsCRMincident regardingobjectidIncidentTask = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMbulkdeletefailure> taskBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMbcgovCustomaddress regardingobjectidBcgovCustomaddressTask = default(MicrosoftDynamicsCRMbcgovCustomaddress), MicrosoftDynamicsCRMbcgovCustomproduct regardingobjectidBcgovCustomproductTask = default(MicrosoftDynamicsCRMbcgovCustomproduct), MicrosoftDynamicsCRMbcgovLocation regardingobjectidBcgovLocationTask = default(MicrosoftDynamicsCRMbcgovLocation), MicrosoftDynamicsCRMbcgovEquipment regardingobjectidBcgovEquipmentTask = default(MicrosoftDynamicsCRMbcgovEquipment), MicrosoftDynamicsCRMbcgovEquipmentlocation regardingobjectidBcgovEquipmentlocationTask = default(MicrosoftDynamicsCRMbcgovEquipmentlocation), MicrosoftDynamicsCRMbcgovRiskassessment regardingobjectidBcgovRiskassessmentTask = default(MicrosoftDynamicsCRMbcgovRiskassessment))
        {
            Importsequencenumber = importsequencenumber;
            Subcategory = subcategory;
            Category = category;
            Subscriptionid = subscriptionid;
            Overriddencreatedon = overriddencreatedon;
            Percentcomplete = percentcomplete;
            Crmtaskassigneduniqueid = crmtaskassigneduniqueid;
            RegardingobjectidEntitlementTask = regardingobjectidEntitlementTask;
            RegardingobjectidEntitlementtemplateTask = regardingobjectidEntitlementtemplateTask;
            TaskPostRegardings = taskPostRegardings;
            TaskPostFollows = taskPostFollows;
            RegardingobjectidBookableresourcebookingTask = regardingobjectidBookableresourcebookingTask;
            RegardingobjectidBookableresourcebookingheaderTask = regardingobjectidBookableresourcebookingheaderTask;
            RegardingobjectidKnowledgebaserecordTask = regardingobjectidKnowledgebaserecordTask;
            TaskConnections2 = taskConnections2;
            SlaTaskSla = slaTaskSla;
            TaskDuplicateBaseRecord = taskDuplicateBaseRecord;
            SlakpiinstanceTask = slakpiinstanceTask;
            RegardingobjectidLeadTask = regardingobjectidLeadTask;
            TaskDuplicateMatchingRecord = taskDuplicateMatchingRecord;
            RegardingobjectidContactTask = regardingobjectidContactTask;
            OwningteamTask = owningteamTask;
            RegardingobjectidQuoteTask = regardingobjectidQuoteTask;
            RegardingobjectidOpportunityTask = regardingobjectidOpportunityTask;
            OwningbusinessunitTask = owningbusinessunitTask;
            TaskConnections1 = taskConnections1;
            SlainvokedidTaskSla = slainvokedidTaskSla;
            TransactioncurrencyidTask = transactioncurrencyidTask;
            StageidProcessstage = stageidProcessstage;
            ServiceidTask = serviceidTask;
            RegardingobjectidCampaignTask = regardingobjectidCampaignTask;
            TaskActivityParties = taskActivityParties;
            RegardingobjectidInvoiceTask = regardingobjectidInvoiceTask;
            RegardingobjectidAccountTask = regardingobjectidAccountTask;
            TaskAnnotation = taskAnnotation;
            ModifiedbyTask = modifiedbyTask;
            CreatedbyTask = createdbyTask;
            ActivityidActivitypointer = activityidActivitypointer;
            TaskAsyncOperations = taskAsyncOperations;
            RegardingobjectidKnowledgearticleTask = regardingobjectidKnowledgearticleTask;
            CreatedonbehalfbyTask = createdonbehalfbyTask;
            TaskSyncErrors = taskSyncErrors;
            RegardingobjectidCampaignactivityTask = regardingobjectidCampaignactivityTask;
            RegardingobjectidContractTask = regardingobjectidContractTask;
            RegardingobjectidSalesorderTask = regardingobjectidSalesorderTask;
            OwninguserTask = owninguserTask;
            ModifiedonbehalfbyTask = modifiedonbehalfbyTask;
            TaskQueueItem = taskQueueItem;
            TaskActioncard = taskActioncard;
            RegardingobjectidIncidentTask = regardingobjectidIncidentTask;
            TaskBulkDeleteFailures = taskBulkDeleteFailures;
            RegardingobjectidBcgovCustomaddressTask = regardingobjectidBcgovCustomaddressTask;
            RegardingobjectidBcgovCustomproductTask = regardingobjectidBcgovCustomproductTask;
            RegardingobjectidBcgovLocationTask = regardingobjectidBcgovLocationTask;
            RegardingobjectidBcgovEquipmentTask = regardingobjectidBcgovEquipmentTask;
            RegardingobjectidBcgovEquipmentlocationTask = regardingobjectidBcgovEquipmentlocationTask;
            RegardingobjectidBcgovRiskassessmentTask = regardingobjectidBcgovRiskassessmentTask;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "percentcomplete")]
        public int? Percentcomplete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crmtaskassigneduniqueid")]
        public string Crmtaskassigneduniqueid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_task")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_task")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "task_PostRegardings")]
        public IList<MicrosoftDynamicsCRMpostregarding> TaskPostRegardings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "task_PostFollows")]
        public IList<MicrosoftDynamicsCRMpostfollow> TaskPostFollows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_task")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_task")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_task")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "task_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> TaskConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_task_sla")]
        public MicrosoftDynamicsCRMsla SlaTaskSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Task_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> TaskDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_task")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_task")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Task_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> TaskDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_task")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_task")]
        public MicrosoftDynamicsCRMteam OwningteamTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_task")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_task")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_task")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "task_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> TaskConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_task_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidTaskSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_task")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_task")]
        public MicrosoftDynamicsCRMservice ServiceidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_task")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "task_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> TaskActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_task")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_task")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Task_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> TaskAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_task")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_task")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Task_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> TaskAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_task")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_task")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Task_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> TaskSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_task")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_task")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_task")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_task")]
        public MicrosoftDynamicsCRMsystemuser OwninguserTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_task")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Task_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> TaskQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "task_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> TaskActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_task")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Task_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> TaskBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_customaddress_task")]
        public MicrosoftDynamicsCRMbcgovCustomaddress RegardingobjectidBcgovCustomaddressTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_customproduct_task")]
        public MicrosoftDynamicsCRMbcgovCustomproduct RegardingobjectidBcgovCustomproductTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_location_task")]
        public MicrosoftDynamicsCRMbcgovLocation RegardingobjectidBcgovLocationTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_equipment_task")]
        public MicrosoftDynamicsCRMbcgovEquipment RegardingobjectidBcgovEquipmentTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_equipmentlocation_task")]
        public MicrosoftDynamicsCRMbcgovEquipmentlocation RegardingobjectidBcgovEquipmentlocationTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_riskassessment_task")]
        public MicrosoftDynamicsCRMbcgovRiskassessment RegardingobjectidBcgovRiskassessmentTask { get; set; }

    }
}
