using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class VirtualService : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.istio.io/v1alpha3";
        [JsonProperty("kind")]
        public string Kind => "VirtualService";

        /** <summary>A list of namespaces to which this virtual service is exported. Exporting a virtual service allows it to be used by sidecars and gateways defined in other namespaces. This feature provides a mechanism for service owners and mesh administrators to control the visibility of virtual services across namespace boundaries.</summary> */
        public IEnumerable<string> exportTo { get; set; }
        /** <summary>An ordered list of route rule for non-terminated TLS & HTTPS traffic. Routing is typically performed using the SNI value presented by the ClientHello message. TLS routes will be applied to platform service ports named 'https-&#42;', 'tls-&#42;', unterminated gateway ports using HTTPS/TLS protocols (i.e. with "passthrough" TLS mode) and service entry ports using HTTPS/TLS protocols. The first rule matching an incoming request is used. NOTE: Traffic 'https-&#42;' or 'tls-&#42;' ports without associated virtual service will be treated as opaque TCP traffic.</summary> */
        public IEnumerable<Networking.V1alpha3.TLSRoute> tls { get; set; }
        /** <summary>An ordered list of route rules for opaque TCP traffic. TCP routes will be applied to any port that is not a HTTP or TLS port. The first rule matching an incoming request is used.</summary> */
        public IEnumerable<Networking.V1alpha3.TCPRoute> tcp { get; set; }
        /** <summary>An ordered list of route rules for HTTP traffic. HTTP routes will be applied to platform service ports named 'http-&#42;'/'http2-&#42;'/'grpc-&#42;', gateway ports with protocol HTTP/HTTP2/GRPC/ TLS-terminated-HTTPS and service entry ports using HTTP/HTTP2/GRPC protocols. The first rule matching an incoming request is used.</summary> */
        public IEnumerable<Networking.V1alpha3.HTTPRoute> http { get; set; }
        /** <summary>The destination hosts to which traffic is being sent. Could be a DNS name with wildcard prefix or an IP address. Depending on the platform, short-names can also be used instead of a FQDN (i.e. has no dots in the name). In such a scenario, the FQDN of the host would be derived based on the underlying platform.</summary> */
        public IEnumerable<string> hosts { get; set; }
        /** <summary>The names of gateways and sidecars that should apply these routes. Gateways in other namespaces may be referred to by `<gateway namespace>/<gateway name>`; specifying a gateway with no namespace qualifier is the same as specifying the VirtualService's namespace. A single VirtualService is used for sidecars inside the mesh as well as for one or more gateways. The selection condition imposed by this field can be overridden using the source field in the match conditions of protocol-specific routes. The reserved word `mesh` is used to imply all the sidecars in the mesh. When this field is omitted, the default gateway (`mesh`) will be used, which would apply the rule to all sidecars in the mesh. If a list of gateway names is provided, the rules will apply only to the gateways. To apply the rules to both gateways and sidecars, specify `mesh` as one of the gateway names.</summary> */
        public IEnumerable<string> gateways { get; set; }
    }
}