using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class Failover
    {
        /** <summary>Originating region.</summary> */
        public string from { get; set; }
        /** <summary>Destination region the traffic will fail over to when endpoints in the 'from' region becomes unhealthy.</summary> */
        public string to { get; set; }
    }
}