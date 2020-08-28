using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class Server
    {
        /** <summary>An optional name of the server, when set must be unique across all servers. This will be used for variety of purposes like prefixing stats generated with this name etc.</summary> */
        public string name { get; set; }
        /** <summary></summary> */
        public Networking.V1alpha3.ServerTLSSettings tls { get; set; }
        /** <summary>Port describes the properties of a specific port of a service.</summary> */
        public Networking.V1alpha3.Port port { get; set; }
        /** <summary>The ip or the Unix domain socket to which the listener should be bound to. Format: `x.x.x.x` or `unix:///path/to/uds` or `unix://@foobar` (Linux abstract namespace). When using Unix domain sockets, the port number should be 0.</summary> */
        public string bind { get; set; }
        /** <summary>One or more hosts exposed by this gateway. While typically applicable to HTTP services, it can also be used for TCP services using TLS with SNI. A host is specified as a `dnsName` with an optional `namespace/` prefix. The `dnsName` should be specified using FQDN format, optionally including a wildcard character in the left-most component (e.g., `prod/&#42;.example.com`). Set the `dnsName` to `&#42;` to select all `VirtualService` hosts from the specified namespace (e.g.,`prod/&#42;`).</summary> */
        public IEnumerable<string> hosts { get; set; }
        /** <summary>The loopback IP endpoint or Unix domain socket to which traffic should be forwarded to by default. Format should be `127.0.0.1:PORT` or `unix:///path/to/socket` or `unix://@foobar` (Linux abstract namespace). NOT IMPLEMENTED. $hide_from_docs</summary> */
        public string defaultEndpoint { get; set; }
    }
}