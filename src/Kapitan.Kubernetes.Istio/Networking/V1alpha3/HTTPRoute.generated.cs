using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class HTTPRoute
    {
        /** <summary>The name assigned to the route for debugging purposes. The route's name will be concatenated with the match's name and will be logged in the access logs for requests matching this route/match.</summary> */
        public string name { get; set; }
        /** <summary>A HTTP rule can either redirect or forward (default) traffic. The forwarding target can be one of several versions of a service (see glossary in beginning of document). Weights associated with the service version determine the proportion of traffic it receives.</summary> */
        public IEnumerable<Networking.V1alpha3.HTTPRouteDestination> route { get; set; }
        /** <summary>Match conditions to be satisfied for the rule to be activated. All conditions inside a single match block have AND semantics, while the list of match blocks have OR semantics. The rule is matched if any one of the match blocks succeed.</summary> */
        public IEnumerable<Networking.V1alpha3.HTTPMatchRequest> match { get; set; }
        /** <summary>HTTPRedirect can be used to send a 301 redirect response to the caller, where the Authority/Host and the URI in the response can be swapped with the specified values. For example, the following rule redirects requests for /v1/getProductRatings API on the ratings service to /v1/bookRatings provided by the bookratings service.</summary> */
        public Networking.V1alpha3.HTTPRedirect redirect { get; set; }
        /** <summary>Describes the delegate VirtualService. The following routing rules forward the traffic to `/productpage` by a delegate VirtualService named `productpage`, forward the traffic to `/reviews` by a delegate VirtualService named `reviews`.</summary> */
        public Networking.V1alpha3.Delegate @delegate { get; set; }
        /** <summary>HTTPRewrite can be used to rewrite specific parts of a HTTP request before forwarding the request to the destination. Rewrite primitive can be used only with HTTPRouteDestination. The following example demonstrates how to rewrite the URL prefix for api call (/ratings) to ratings service before making the actual API call.</summary> */
        public Networking.V1alpha3.HTTPRewrite rewrite { get; set; }
        /** <summary>Timeout for HTTP requests, default is disabled.</summary> */
        public string timeout { get; set; }
        /** <summary>Describes the retry policy to use when a HTTP request fails. For example, the following rule sets the maximum number of retries to 3 when calling ratings:v1 service, with a 2s timeout per retry attempt.</summary> */
        public Networking.V1alpha3.HTTPRetry retries { get; set; }
        /** <summary>HTTPFaultInjection can be used to specify one or more faults to inject while forwarding HTTP requests to the destination specified in a route. Fault specification is part of a VirtualService rule. Faults include aborting the Http request from downstream service, and/or delaying proxying of requests. A fault rule MUST HAVE delay or abort or both.</summary> */
        public Networking.V1alpha3.HTTPFaultInjection fault { get; set; }
        /** <summary>Destination indicates the network addressable service to which the request/connection will be sent after processing a routing rule. The destination.host should unambiguously refer to a service in the service registry. Istio's service registry is composed of all the services found in the platform's service registry (e.g., Kubernetes services, Consul services), as well as services declared through the [ServiceEntry](https://istio.io/docs/reference/config/networking/service-entry/#ServiceEntry) resource.</summary> */
        public Networking.V1alpha3.Destination mirror { get; set; }
        /** <summary>Percentage of the traffic to be mirrored by the `mirror` field. Use of integer `mirror_percent` value is deprecated. Use the double `mirror_percentage` field instead</summary> */
        public int mirrorPercent { get; set; }
        /** <summary>Percent specifies a percentage in the range of [0.0, 100.0].</summary> */
        public Networking.V1alpha3.Percent mirrorPercentage { get; set; }
        /** <summary>Describes the Cross-Origin Resource Sharing (CORS) policy, for a given service. Refer to [CORS](https://developer.mozilla.org/en-US/docs/Web/HTTP/Access_control_CORS) for further details about cross origin resource sharing. For example, the following rule restricts cross origin requests to those originating from example.com domain using HTTP POST/GET, and sets the `Access-Control-Allow-Credentials` header to false. In addition, it only exposes `X-Foo-bar` header and sets an expiry period of 1 day.</summary> */
        public Networking.V1alpha3.CorsPolicy corsPolicy { get; set; }
        /** <summary>Message headers can be manipulated when Envoy forwards requests to, or responses from, a destination service. Header manipulation rules can be specified for a specific route destination or for all destinations. The following VirtualService adds a `test` header with the value `true` to requests that are routed to any `reviews` service destination. It also romoves the `foo` response header, but only from responses coming from the `v1` subset (version) of the `reviews` service.</summary> */
        public Networking.V1alpha3.Headers headers { get; set; }
    }
}