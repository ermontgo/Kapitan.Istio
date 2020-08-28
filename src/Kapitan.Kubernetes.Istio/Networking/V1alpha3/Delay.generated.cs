using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class Delay
    {
        /** <summary>Percentage of requests on which the delay will be injected (0-100). Use of integer `percent` value is deprecated. Use the double `percentage` field instead.</summary> */
        public int percent { get; set; }
        /** <summary>Percent specifies a percentage in the range of [0.0, 100.0].</summary> */
        public Networking.V1alpha3.Percent percentage { get; set; }
    }
}