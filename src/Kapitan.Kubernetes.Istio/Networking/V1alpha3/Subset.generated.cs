using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class Subset
    {
        /** <summary>Name of the subset. The service name and the subset name can be used for traffic splitting in a route rule.</summary> */
        public string name { get; set; }
        /** <summary>Traffic policies to apply for a specific destination, across all destination ports. See DestinationRule for examples.</summary> */
        public Networking.V1alpha3.TrafficPolicy trafficPolicy { get; set; }
        /** <summary>Labels apply a filter over the endpoints of a service in the service registry. See route rules for examples of usage.</summary> */
        public object labels { get; set; }
    }
}