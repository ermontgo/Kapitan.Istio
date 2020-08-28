using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class Gateway : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.istio.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "Gateway";

        /** <summary>A list of server specifications.</summary> */
        public IEnumerable<Networking.V1beta1.Server> servers { get; set; }
        /** <summary>One or more labels that indicate a specific set of pods/VMs on which this gateway configuration should be applied. By default workloads are searched across all namespaces based on label selectors. This implies that a gateway resource in the namespace "foo" can select pods in the namespace "bar" based on labels. This behavior can be controlled via the PILOT_SCOPE_GATEWAY_TO_NAMESPACE environment variable in istiod. If this variable is set to true, the scope of label search is restricted to the configuration namespace in which the the resource is present. In other words, the Gateway resource must reside in the same namespace as the gateway workload instance. If selector is nil, the Gateway will be applied to all workloads.</summary> */
        public object selector { get; set; }
    }
}