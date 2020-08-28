using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class FilterMatch
    {
        /** <summary>The filter name to match on. For standard Envoy filters, canonical filter names should be used. Refer to https://www.envoyproxy.io/docs/envoy/latest/version_history/v1.14.0#deprecated for canonical names.</summary> */
        public string name { get; set; }
        /** <summary>Conditions to match a specific filter within another filter. This field is typically useful to match a HTTP filter inside the envoy.filters.network.http_connection_manager network filter. This could also be applicable for thrift filters.</summary> */
        public SubFilterMatch subFilter { get; set; }
    }
}