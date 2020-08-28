using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class TrafficPolicy : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.istio.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "TrafficPolicy";

        /** <summary>Load balancing policies to apply for a specific destination. See Envoy's load balancing [documentation](https://www.envoyproxy.io/docs/envoy/latest/intro/arch_overview/upstream/load_balancing/load_balancing) for more details.</summary> */
        public Networking.V1beta1.LoadBalancerSettings loadBalancer { get; set; }
        /** <summary>Connection pool settings for an upstream host. The settings apply to each individual host in the upstream service. See Envoy's [circuit breaker](https://www.envoyproxy.io/docs/envoy/latest/intro/arch_overview/upstream/circuit_breaking) for more details. Connection pool settings can be applied at the TCP level as well as at HTTP level.</summary> */
        public Networking.V1beta1.ConnectionPoolSettings connectionPool { get; set; }
        /** <summary>A Circuit breaker implementation that tracks the status of each individual host in the upstream service. Applicable to both HTTP and TCP services. For HTTP services, hosts that continually return 5xx errors for API calls are ejected from the pool for a pre-defined period of time. For TCP services, connection timeouts or connection failures to a given host counts as an error when measuring the consecutive errors metric. See Envoy's [outlier detection](https://www.envoyproxy.io/docs/envoy/latest/intro/arch_overview/upstream/outlier) for more details.</summary> */
        public Networking.V1beta1.OutlierDetection outlierDetection { get; set; }
        /** <summary>SSL/TLS related settings for upstream connections. See Envoy's [TLS context](https://www.envoyproxy.io/docs/envoy/latest/api-v2/api/v2/auth/cert.proto.html) for more details. These settings are common to both HTTP and TCP upstreams.</summary> */
        public Networking.V1beta1.ClientTLSSettings tls { get; set; }
        /** <summary>Traffic policies specific to individual ports. Note that port level settings will override the destination-level settings. Traffic settings specified at the destination-level will not be inherited when overridden by port-level settings, i.e. default values will be applied to fields omitted in port-level traffic policies.</summary> */
        public IEnumerable<Networking.V1beta1.PortTrafficPolicy> portLevelSettings { get; set; }
    }
}