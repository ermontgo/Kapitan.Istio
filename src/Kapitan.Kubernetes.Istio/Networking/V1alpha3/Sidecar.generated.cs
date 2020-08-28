using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class Sidecar : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.istio.io/v1alpha3";
        [JsonProperty("kind")]
        public string Kind => "Sidecar";

        /** <summary>`WorkloadSelector` specifies the criteria used to determine if the `Gateway`, `Sidecar`, or `EnvoyFilter` or `ServiceEntry` configuration can be applied to a proxy. The matching criteria includes the metadata associated with a proxy, workload instance info such as labels attached to the pod/VM, or any other info that the proxy provides to Istio during the initial handshake. If multiple conditions are specified, all conditions need to match in order for the workload instance to be selected. Currently, only label based selection mechanism is supported.</summary> */
        public Networking.V1alpha3.WorkloadSelector workloadSelector { get; set; }
        /** <summary>Ingress specifies the configuration of the sidecar for processing inbound traffic to the attached workload instance. If omitted, Istio will automatically configure the sidecar based on the information about the workload obtained from the orchestration platform (e.g., exposed ports, services, etc.). If specified, inbound ports are configured if and only if the workload instance is associated with a service.</summary> */
        public IEnumerable<Networking.V1alpha3.IstioIngressListener> ingress { get; set; }
        /** <summary>Egress specifies the configuration of the sidecar for processing outbound traffic from the attached workload instance to other services in the mesh. If not specified, inherits the system detected defaults from the namespace-wide or the global default Sidecar.</summary> */
        public IEnumerable<Networking.V1alpha3.IstioEgressListener> egress { get; set; }
        /** <summary>`OutboundTrafficPolicy` sets the default behavior of the sidecar for handling outbound traffic from the application. If your application uses one or more external services that are not known apriori, setting the policy to `ALLOW_ANY` will cause the sidecars to route any unknown traffic originating from the application to its requested destination. Users are strongly encouraged to use `ServiceEntry` configurations to explicitly declare any external dependencies, instead of using `ALLOW_ANY`, so that traffic to these services can be monitored.</summary> */
        public Networking.V1alpha3.OutboundTrafficPolicy outboundTrafficPolicy { get; set; }
    }
}