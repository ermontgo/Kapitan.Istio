using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Security.V1beta1
{
    public partial class AuthorizationPolicy : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "security.istio.io/v1beta1";
        [JsonProperty("kind")]
        public string Kind => "AuthorizationPolicy";

        /** <summary>The selector determines the workloads to apply the RequestAuthentication on. If not set, the policy will be applied to all workloads in the same namespace as the policy.</summary> */
        public WorkloadSelector selector { get; set; }
        /** <summary>Optional. A list of rules to match the request. A match occurs when at least one rule matches the request.</summary> */
        public IEnumerable<Security.V1beta1.Rule> rules { get; set; }
        /** <summary>Action specifies the operation to take.</summary> */
        public Action action { get; set; }
    }
}