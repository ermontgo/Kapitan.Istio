using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class FilterChainMatch
    {
        /** <summary>The name assigned to the filter chain.</summary> */
        public string name { get; set; }
        /** <summary>The SNI value used by a filter chain's match condition. This condition will evaluate to false if the filter chain has no sni match.</summary> */
        public string sni { get; set; }
        /** <summary>Applies only to SIDECAR_INBOUND context. If non-empty, a transport protocol to consider when determining a filter chain match. This value will be compared against the transport protocol of a new connection, when it's detected by the tls_inspector listener filter.</summary> */
        public string transportProtocol { get; set; }
        /** <summary>Applies only to sidecars. If non-empty, a comma separated set of application protocols to consider when determining a filter chain match. This value will be compared against the application protocols of a new connection, when it's detected by one of the listener filters such as the http_inspector.</summary> */
        public string applicationProtocols { get; set; }
        /** <summary>Conditions to match a specific filter within a filter chain.</summary> */
        public FilterMatch filter { get; set; }
    }
}