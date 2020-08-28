using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class ClusterMatch
    {
        /** <summary>The exact name of the cluster to match. To match a specific cluster by name, such as the internally generated "Passthrough" cluster, leave all fields in clusterMatch empty, except the name.</summary> */
        public string name { get; set; }
        /** <summary>The service port for which this cluster was generated. If omitted, applies to clusters for any port.</summary> */
        public int portNumber { get; set; }
        /** <summary>The fully qualified service name for this cluster. If omitted, applies to clusters for any service. For services defined through service entries, the service name is same as the hosts defined in the service entry.</summary> */
        public string service { get; set; }
        /** <summary>The subset associated with the service. If omitted, applies to clusters for any subset of a service.</summary> */
        public string subset { get; set; }
    }
}