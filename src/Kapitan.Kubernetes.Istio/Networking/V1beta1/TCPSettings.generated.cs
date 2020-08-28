using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class TCPSettings
    {
        /** <summary>Maximum number of HTTP1 /TCP connections to a destination host. Default 2^32-1.</summary> */
        public int maxConnections { get; set; }
        /** <summary>TCP connection timeout.</summary> */
        public string connectTimeout { get; set; }
        /** <summary>TCP keepalive.</summary> */
        public TcpKeepalive tcpKeepalive { get; set; }
    }
}