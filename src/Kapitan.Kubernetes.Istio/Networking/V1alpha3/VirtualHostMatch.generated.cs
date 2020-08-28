using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class VirtualHostMatch
    {
        /** <summary>The VirtualHosts objects generated by Istio are named as host:port, where the host typically corresponds to the VirtualService's host field or the hostname of a service in the registry.</summary> */
        public string name { get; set; }
        /** <summary>Match a specific route inside a virtual host in a route configuration.</summary> */
        public RouteMatch route { get; set; }
    }
}