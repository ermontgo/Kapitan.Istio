using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class WorkloadSelector
    {
        /** <summary>One or more labels that indicate a specific set of pods/VMs on which the configuration should be applied. The scope of label search is restricted to the configuration namespace in which the the resource is present.</summary> */
        public object labels { get; set; }
    }
}