using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes
{
    public partial class PeerAuthentication
    {
        /** <summary>The selector determines the workloads to apply the RequestAuthentication on. If not set, the policy will be applied to all workloads in the same namespace as the policy.</summary> */
        public WorkloadSelector selector { get; set; }
        /** <summary>Mutual TLS settings.</summary> */
        public MutualTLS mtls { get; set; }
        /** <summary>Port specific mutual TLS settings.</summary> */
        public object portLevelMtls { get; set; }
    }
}