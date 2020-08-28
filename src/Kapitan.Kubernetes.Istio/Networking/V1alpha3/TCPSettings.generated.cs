using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class TCPSettings
    {
        /** <summary>Maximum number of HTTP1 /TCP connections to a destination host. Default 2^32-1.</summary> */
        public int maxConnections { get; set; }
        /** <summary>TCP connection timeout. format: 1h/1m/1s/1ms. MUST BE >=1ms. Default is 10s.</summary> */
        public string connectTimeout { get; set; }
        /** <summary>TCP keepalive.</summary> */
        public TcpKeepalive tcpKeepalive { get; set; }
    }
}