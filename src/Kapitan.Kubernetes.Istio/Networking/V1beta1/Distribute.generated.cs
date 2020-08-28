using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class Distribute
    {
        /** <summary>Originating locality, '/' separated, e.g. 'region/zone/sub_zone'.</summary> */
        public string from { get; set; }
        /** <summary>Map of upstream localities to traffic distribution weights. The sum of all weights should be == 100. Any locality not assigned a weight will receive no traffic.</summary> */
        public object to { get; set; }
    }
}