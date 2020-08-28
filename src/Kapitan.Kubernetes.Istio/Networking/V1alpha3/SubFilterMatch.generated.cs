using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class SubFilterMatch
    {
        /** <summary>The filter name to match on.</summary> */
        public string name { get; set; }
    }
}