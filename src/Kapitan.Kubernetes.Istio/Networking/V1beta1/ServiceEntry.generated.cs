using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class ServiceEntry : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.istio.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "ServiceEntry";

        /** <summary>A list of namespaces to which this service is exported. Exporting a service allows it to be used by sidecars, gateways and virtual services defined in other namespaces. This feature provides a mechanism for service owners and mesh administrators to control the visibility of services across namespace boundaries.</summary> */
        public IEnumerable<string> exportTo { get; set; }
        /** <summary>If specified, the proxy will verify that the server certificate's subject alternate name matches one of the specified values.</summary> */
        public IEnumerable<string> subjectAltNames { get; set; }
        /** <summary>The hosts associated with the ServiceEntry. Could be a DNS name with wildcard prefix.</summary> */
        public IEnumerable<string> hosts { get; set; }
        /** <summary>The virtual IP addresses associated with the service. Could be CIDR prefix. For HTTP traffic, generated route configurations will include http route domains for both the `addresses` and `hosts` field values and the destination will be identified based on the HTTP Host/Authority header. If one or more IP addresses are specified, the incoming traffic will be identified as belonging to this service if the destination IP matches the IP/CIDRs specified in the addresses field. If the Addresses field is empty, traffic will be identified solely based on the destination port. In such scenarios, the port on which the service is being accessed must not be shared by any other service in the mesh. In other words, the sidecar will behave as a simple TCP proxy, forwarding incoming traffic on a specified port to the specified destination endpoint IP/host. Unix domain socket addresses are not supported in this field.</summary> */
        public IEnumerable<string> addresses { get; set; }
        /** <summary>The ports associated with the external service. If the Endpoints are Unix domain socket addresses, there must be exactly one port.</summary> */
        public IEnumerable<Networking.V1beta1.Port> ports { get; set; }
        /** <summary>Location specifies whether the service is part of Istio mesh or outside the mesh. Location determines the behavior of several features, such as service-to-service mTLS authentication, policy enforcement, etc. When communicating with services outside the mesh, Istio's mTLS authentication is disabled, and policy enforcement is performed on the client-side as opposed to server-side.</summary> */
        public Location location { get; set; }
        /** <summary>Resolution determines how the proxy will resolve the IP addresses of the network endpoints associated with the service, so that it can route to one of them. The resolution mode specified here has no impact on how the application resolves the IP address associated with the service. The application may still have to use DNS to resolve the service to an IP so that the outbound traffic can be captured by the Proxy. Alternatively, for HTTP services, the application could directly communicate with the proxy (e.g., by setting HTTP_PROXY) to talk to these services.</summary> */
        public Resolution resolution { get; set; }
        /** <summary>One or more endpoints associated with the service. Only one of `endpoints` or `workloadSelector` can be specified.</summary> */
        public IEnumerable<Networking.V1beta1.WorkloadEntry> endpoints { get; set; }
        /** <summary>`WorkloadSelector` specifies the criteria used to determine if the `Gateway`, `Sidecar`, or `EnvoyFilter` configuration can be applied to a proxy. The matching criteria includes the metadata associated with a proxy, workload instance info such as labels attached to the pod/VM, or any other info that the proxy provides to Istio during the initial handshake. If multiple conditions are specified, all conditions need to match in order for the workload instance to be selected. Currently, only label based selection mechanism is supported.</summary> */
        public Networking.V1beta1.WorkloadSelector workloadSelector { get; set; }
    }
}