// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Configuration of Azure web site
    /// </summary>
    public partial class SiteConfig : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SiteConfig class.
        /// </summary>
        public SiteConfig() { }

        /// <summary>
        /// Initializes a new instance of the SiteConfig class.
        /// </summary>
        public SiteConfig(int? numberOfWorkers = default(int?), IList<string> defaultDocuments = default(IList<string>), string netFrameworkVersion = default(string), string phpVersion = default(string), string pythonVersion = default(string), bool? requestTracingEnabled = default(bool?), DateTime? requestTracingExpirationTime = default(DateTime?), bool? remoteDebuggingEnabled = default(bool?), string remoteDebuggingVersion = default(string), bool? httpLoggingEnabled = default(bool?), int? logsDirectorySizeLimit = default(int?), bool? detailedErrorLoggingEnabled = default(bool?), string publishingUsername = default(string), string publishingPassword = default(string), IList<NameValuePair> appSettings = default(IList<NameValuePair>), IList<NameValuePair> metadata = default(IList<NameValuePair>), IList<ConnStringInfo> connectionStrings = default(IList<ConnStringInfo>), IList<HandlerMapping> handlerMappings = default(IList<HandlerMapping>), string documentRoot = default(string), string scmType = default(string), bool? use32BitWorkerProcess = default(bool?), bool? webSocketsEnabled = default(bool?), bool? alwaysOn = default(bool?), string javaVersion = default(string), string javaContainer = default(string), string javaContainerVersion = default(string), ManagedPipelineMode? managedPipelineMode = default(ManagedPipelineMode?), IList<VirtualApplication> virtualApplications = default(IList<VirtualApplication>), SiteLoadBalancing? loadBalancing = default(SiteLoadBalancing?), Experiments experiments = default(Experiments), SiteLimits limits = default(SiteLimits), bool? autoHealEnabled = default(bool?), AutoHealRules autoHealRules = default(AutoHealRules), string tracingOptions = default(string), string vnetName = default(string), CorsSettings cors = default(CorsSettings), ApiDefinitionInfo apiDefinition = default(ApiDefinitionInfo), string autoSwapSlotName = default(string))
        {
            NumberOfWorkers = numberOfWorkers;
            DefaultDocuments = defaultDocuments;
            NetFrameworkVersion = netFrameworkVersion;
            PhpVersion = phpVersion;
            PythonVersion = pythonVersion;
            RequestTracingEnabled = requestTracingEnabled;
            RequestTracingExpirationTime = requestTracingExpirationTime;
            RemoteDebuggingEnabled = remoteDebuggingEnabled;
            RemoteDebuggingVersion = remoteDebuggingVersion;
            HttpLoggingEnabled = httpLoggingEnabled;
            LogsDirectorySizeLimit = logsDirectorySizeLimit;
            DetailedErrorLoggingEnabled = detailedErrorLoggingEnabled;
            PublishingUsername = publishingUsername;
            PublishingPassword = publishingPassword;
            AppSettings = appSettings;
            Metadata = metadata;
            ConnectionStrings = connectionStrings;
            HandlerMappings = handlerMappings;
            DocumentRoot = documentRoot;
            ScmType = scmType;
            Use32BitWorkerProcess = use32BitWorkerProcess;
            WebSocketsEnabled = webSocketsEnabled;
            AlwaysOn = alwaysOn;
            JavaVersion = javaVersion;
            JavaContainer = javaContainer;
            JavaContainerVersion = javaContainerVersion;
            ManagedPipelineMode = managedPipelineMode;
            VirtualApplications = virtualApplications;
            LoadBalancing = loadBalancing;
            Experiments = experiments;
            Limits = limits;
            AutoHealEnabled = autoHealEnabled;
            AutoHealRules = autoHealRules;
            TracingOptions = tracingOptions;
            VnetName = vnetName;
            Cors = cors;
            ApiDefinition = apiDefinition;
            AutoSwapSlotName = autoSwapSlotName;
        }

        /// <summary>
        /// Number of workers
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfWorkers")]
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Default documents
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultDocuments")]
        public IList<string> DefaultDocuments { get; set; }

        /// <summary>
        /// Net Framework Version
        /// </summary>
        [JsonProperty(PropertyName = "properties.netFrameworkVersion")]
        public string NetFrameworkVersion { get; set; }

        /// <summary>
        /// Version of PHP
        /// </summary>
        [JsonProperty(PropertyName = "properties.phpVersion")]
        public string PhpVersion { get; set; }

        /// <summary>
        /// Version of Python
        /// </summary>
        [JsonProperty(PropertyName = "properties.pythonVersion")]
        public string PythonVersion { get; set; }

        /// <summary>
        /// Enable request tracing
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestTracingEnabled")]
        public bool? RequestTracingEnabled { get; set; }

        /// <summary>
        /// Request tracing expiration time
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestTracingExpirationTime")]
        public DateTime? RequestTracingExpirationTime { get; set; }

        /// <summary>
        /// Remote Debugging Enabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.remoteDebuggingEnabled")]
        public bool? RemoteDebuggingEnabled { get; set; }

        /// <summary>
        /// Remote Debugging Version
        /// </summary>
        [JsonProperty(PropertyName = "properties.remoteDebuggingVersion")]
        public string RemoteDebuggingVersion { get; set; }

        /// <summary>
        /// HTTP logging Enabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpLoggingEnabled")]
        public bool? HttpLoggingEnabled { get; set; }

        /// <summary>
        /// HTTP Logs Directory size limit
        /// </summary>
        [JsonProperty(PropertyName = "properties.logsDirectorySizeLimit")]
        public int? LogsDirectorySizeLimit { get; set; }

        /// <summary>
        /// Detailed error logging enabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.detailedErrorLoggingEnabled")]
        public bool? DetailedErrorLoggingEnabled { get; set; }

        /// <summary>
        /// Publishing user name
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingUsername")]
        public string PublishingUsername { get; set; }

        /// <summary>
        /// Publishing password
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPassword")]
        public string PublishingPassword { get; set; }

        /// <summary>
        /// Application Settings
        /// </summary>
        [JsonProperty(PropertyName = "properties.appSettings")]
        public IList<NameValuePair> AppSettings { get; set; }

        /// <summary>
        /// Site Metadata
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public IList<NameValuePair> Metadata { get; set; }

        /// <summary>
        /// Connection strings
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionStrings")]
        public IList<ConnStringInfo> ConnectionStrings { get; set; }

        /// <summary>
        /// Handler mappings
        /// </summary>
        [JsonProperty(PropertyName = "properties.handlerMappings")]
        public IList<HandlerMapping> HandlerMappings { get; set; }

        /// <summary>
        /// Document root
        /// </summary>
        [JsonProperty(PropertyName = "properties.documentRoot")]
        public string DocumentRoot { get; set; }

        /// <summary>
        /// SCM type
        /// </summary>
        [JsonProperty(PropertyName = "properties.scmType")]
        public string ScmType { get; set; }

        /// <summary>
        /// Use 32 bit worker process
        /// </summary>
        [JsonProperty(PropertyName = "properties.use32BitWorkerProcess")]
        public bool? Use32BitWorkerProcess { get; set; }

        /// <summary>
        /// Web socket enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.webSocketsEnabled")]
        public bool? WebSocketsEnabled { get; set; }

        /// <summary>
        /// Always On
        /// </summary>
        [JsonProperty(PropertyName = "properties.alwaysOn")]
        public bool? AlwaysOn { get; set; }

        /// <summary>
        /// Java version
        /// </summary>
        [JsonProperty(PropertyName = "properties.javaVersion")]
        public string JavaVersion { get; set; }

        /// <summary>
        /// Java container
        /// </summary>
        [JsonProperty(PropertyName = "properties.javaContainer")]
        public string JavaContainer { get; set; }

        /// <summary>
        /// Java container version
        /// </summary>
        [JsonProperty(PropertyName = "properties.javaContainerVersion")]
        public string JavaContainerVersion { get; set; }

        /// <summary>
        /// Managed pipeline mode. Possible values for this property include:
        /// 'Integrated', 'Classic'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedPipelineMode")]
        public ManagedPipelineMode? ManagedPipelineMode { get; set; }

        /// <summary>
        /// Virtual applications
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualApplications")]
        public IList<VirtualApplication> VirtualApplications { get; set; }

        /// <summary>
        /// Site load balancing. Possible values for this property include:
        /// 'WeightedRoundRobin', 'LeastRequests', 'LeastResponseTime',
        /// 'WeightedTotalTraffic', 'RequestHash'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancing")]
        public SiteLoadBalancing? LoadBalancing { get; set; }

        /// <summary>
        /// This is work around for polymophic types
        /// </summary>
        [JsonProperty(PropertyName = "properties.experiments")]
        public Experiments Experiments { get; set; }

        /// <summary>
        /// Site limits
        /// </summary>
        [JsonProperty(PropertyName = "properties.limits")]
        public SiteLimits Limits { get; set; }

        /// <summary>
        /// Auto heal enabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoHealEnabled")]
        public bool? AutoHealEnabled { get; set; }

        /// <summary>
        /// Auto heal rules
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoHealRules")]
        public AutoHealRules AutoHealRules { get; set; }

        /// <summary>
        /// Tracing options
        /// </summary>
        [JsonProperty(PropertyName = "properties.tracingOptions")]
        public string TracingOptions { get; set; }

        /// <summary>
        /// Vnet name
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// Cross-Origin Resource Sharing (CORS) settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cors")]
        public CorsSettings Cors { get; set; }

        /// <summary>
        /// Information about the formal API definition for the web app.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiDefinition")]
        public ApiDefinitionInfo ApiDefinition { get; set; }

        /// <summary>
        /// Auto swap slot name
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoSwapSlotName")]
        public string AutoSwapSlotName { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.ConnectionStrings != null)
            {
                foreach (var element in this.ConnectionStrings)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.AutoHealRules != null)
            {
                this.AutoHealRules.Validate();
            }
        }
    }
}