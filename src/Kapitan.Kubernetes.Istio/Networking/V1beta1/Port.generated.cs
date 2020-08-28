using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class Port
    {
        /** <summary>A valid non-negative integer port number.</summary> */
        public int number { get; set; }
        /** <summary>Label assigned to the port.</summary> */
        public string name { get; set; }
        /** <summary>The protocol exposed on the port. MUST BE one of HTTP|HTTPS|GRPC|HTTP2|MONGO|TCP|TLS. TLS implies the connection will be routed based on the SNI header to the destination without terminating the TLS connection.</summary> */
        public string protocol { get; set; }
        /** <summary>The port number on the endpoint where the traffic will be received. Applicable only when used with ServiceEntries.</summary> */
        public int targetPort { get; set; }
    }
}