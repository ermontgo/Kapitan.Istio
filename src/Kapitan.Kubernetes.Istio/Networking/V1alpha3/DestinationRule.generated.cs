using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class DestinationRule : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.istio.io/v1alpha3";
        [JsonProperty("kind")]
        public string Kind => "DestinationRule";

        /** <summary>The name of a service from the service registry. Service names are looked up from the platform's service registry (e.g., Kubernetes services, Consul services, etc.) and from the hosts declared by [ServiceEntries](https://istio.io/docs/reference/config/networking/service-entry/#ServiceEntry). Rules defined for services that do not exist in the service registry will be ignored.</summary> */
        public string host { get; set; }
        /** <summary>Traffic policies to apply for a specific destination, across all destination ports. See DestinationRule for examples.</summary> */
        public Networking.V1alpha3.TrafficPolicy trafficPolicy { get; set; }
        /** <summary>One or more named sets that represent individual versions of a service. Traffic policies can be overridden at subset level.</summary> */
        public IEnumerable<Networking.V1alpha3.Subset> subsets { get; set; }
        /** <summary>A list of namespaces to which this destination rule is exported. The resolution of a destination rule to apply to a service occurs in the context of a hierarchy of namespaces. Exporting a destination rule allows it to be included in the resolution hierarchy for services in other namespaces. This feature provides a mechanism for service owners and mesh administrators to control the visibility of destination rules across namespace boundaries.</summary> */
        public IEnumerable<string> exportTo { get; set; }
    }
}