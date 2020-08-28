using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class HTTPRetry
    {
        /** <summary>Number of retries for a given request. The interval between retries will be determined automatically (25ms+). Actual number of retries attempted depends on the request `timeout` of the [HTTP route](https://istio.io/docs/reference/config/networking/virtual-service/#HTTPRoute).</summary> */
        public int attempts { get; set; }
        /** <summary>Timeout per retry attempt for a given request. format: 1h/1m/1s/1ms. MUST BE >=1ms.</summary> */
        public string perTryTimeout { get; set; }
        /** <summary>Specifies the conditions under which retry takes place. One or more policies can be specified using a ‘,’ delimited list. See the [retry policies](https://www.envoyproxy.io/docs/envoy/latest/configuration/http/http_filters/router_filter#x-envoy-retry-on) and [gRPC retry policies](https://www.envoyproxy.io/docs/envoy/latest/configuration/http/http_filters/router_filter#x-envoy-retry-grpc-on) for more details.</summary> */
        public string retryOn { get; set; }
        /** <summary>Flag to specify whether the retries should retry to other localities. See the [retry plugin configuration](https://www.envoyproxy.io/docs/envoy/latest/intro/arch_overview/http/http_connection_management#retry-plugin-configuration) for more details.</summary> */
        public bool retryRemoteLocalities { get; set; }
    }
}