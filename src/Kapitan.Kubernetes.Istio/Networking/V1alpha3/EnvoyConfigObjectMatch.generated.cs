using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class EnvoyConfigObjectMatch
    {
        /** <summary>PatchContext selects a class of configurations based on the traffic flow direction and workload type.</summary> */
        public PatchContext context { get; set; }
        /** <summary>One or more properties of the proxy to match on.</summary> */
        public ProxyMatch proxy { get; set; }
    }
}