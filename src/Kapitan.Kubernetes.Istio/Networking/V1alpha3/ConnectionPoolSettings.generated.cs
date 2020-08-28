using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class ConnectionPoolSettings
    {
        /** <summary>Settings common to both HTTP and TCP upstream connections.</summary> */
        public TCPSettings tcp { get; set; }
        /** <summary>Settings applicable to HTTP1.1/HTTP2/GRPC connections.</summary> */
        public HTTPSettings http { get; set; }
    }
}