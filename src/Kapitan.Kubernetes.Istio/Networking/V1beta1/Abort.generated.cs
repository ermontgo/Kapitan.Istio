using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class Abort
    {
        /** <summary>Percent specifies a percentage in the range of [0.0, 100.0].</summary> */
        public Networking.V1beta1.Percent percentage { get; set; }
    }
}