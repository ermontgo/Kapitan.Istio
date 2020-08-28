using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class EnvoyFilter : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.istio.io/v1alpha3";
        [JsonProperty("kind")]
        public string Kind => "EnvoyFilter";

        /** <summary>`WorkloadSelector` specifies the criteria used to determine if the `Gateway`, `Sidecar`, or `EnvoyFilter` or `ServiceEntry` configuration can be applied to a proxy. The matching criteria includes the metadata associated with a proxy, workload instance info such as labels attached to the pod/VM, or any other info that the proxy provides to Istio during the initial handshake. If multiple conditions are specified, all conditions need to match in order for the workload instance to be selected. Currently, only label based selection mechanism is supported.</summary> */
        public Networking.V1alpha3.WorkloadSelector workloadSelector { get; set; }
        /** <summary>One or more patches with match conditions.</summary> */
        public IEnumerable<EnvoyConfigObjectPatch> configPatches { get; set; }
    }
}