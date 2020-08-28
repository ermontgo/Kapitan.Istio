using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class HTTPRouteDestination
    {
        /** <summary>Message headers can be manipulated when Envoy forwards requests to, or responses from, a destination service. Header manipulation rules can be specified for a specific route destination or for all destinations. The following VirtualService adds a `test` header with the value `true` to requests that are routed to any `reviews` service destination. It also romoves the `foo` response header, but only from responses coming from the `v1` subset (version) of the `reviews` service.</summary> */
        public Networking.V1alpha3.Headers headers { get; set; }
        /** <summary>Destination indicates the network addressable service to which the request/connection will be sent after processing a routing rule. The destination.host should unambiguously refer to a service in the service registry. Istio's service registry is composed of all the services found in the platform's service registry (e.g., Kubernetes services, Consul services), as well as services declared through the [ServiceEntry](https://istio.io/docs/reference/config/networking/service-entry/#ServiceEntry) resource.</summary> */
        public Networking.V1alpha3.Destination destination { get; set; }
        /** <summary>The proportion of traffic to be forwarded to the service version. (0-100). Sum of weights across destinations SHOULD BE == 100. If there is only one destination in a rule, the weight value is assumed to be 100.</summary> */
        public int weight { get; set; }
    }
}