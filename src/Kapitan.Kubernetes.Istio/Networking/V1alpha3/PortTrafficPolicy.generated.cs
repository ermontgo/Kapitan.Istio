using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class PortTrafficPolicy : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.istio.io/v1alpha3";
        [JsonProperty("kind")]
        public string Kind => "PortTrafficPolicy";

        /** <summary>Load balancing policies to apply for a specific destination. See Envoy's load balancing [documentation](https://www.envoyproxy.io/docs/envoy/latest/intro/arch_overview/upstream/load_balancing/load_balancing) for more details.</summary> */
        public Networking.V1alpha3.LoadBalancerSettings loadBalancer { get; set; }
        /** <summary>Connection pool settings for an upstream host. The settings apply to each individual host in the upstream service. See Envoy's [circuit breaker](https://www.envoyproxy.io/docs/envoy/latest/intro/arch_overview/upstream/circuit_breaking) for more details. Connection pool settings can be applied at the TCP level as well as at HTTP level.</summary> */
        public Networking.V1alpha3.ConnectionPoolSettings connectionPool { get; set; }
        /** <summary>A Circuit breaker implementation that tracks the status of each individual host in the upstream service. Applicable to both HTTP and TCP services. For HTTP services, hosts that continually return 5xx errors for API calls are ejected from the pool for a pre-defined period of time. For TCP services, connection timeouts or connection failures to a given host counts as an error when measuring the consecutive errors metric. See Envoy's [outlier detection](https://www.envoyproxy.io/docs/envoy/latest/intro/arch_overview/upstream/outlier) for more details.</summary> */
        public Networking.V1alpha3.OutlierDetection outlierDetection { get; set; }
        /** <summary>SSL/TLS related settings for upstream connections. See Envoy's [TLS context](https://www.envoyproxy.io/docs/envoy/latest/api-v2/api/v2/auth/cert.proto.html) for more details. These settings are common to both HTTP and TCP upstreams.</summary> */
        public Networking.V1alpha3.ClientTLSSettings tls { get; set; }
        /** <summary>PortSelector specifies the number of a port to be used for matching or selection for final routing.</summary> */
        public Networking.V1alpha3.PortSelector port { get; set; }
    }
}