using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes
{
    public partial class RequestAuthentication
    {
        /** <summary>The selector determines the workloads to apply the RequestAuthentication on. If not set, the policy will be applied to all workloads in the same namespace as the policy.</summary> */
        public WorkloadSelector selector { get; set; }
        /** <summary>Define the list of JWTs that can be validated at the selected workloads' proxy. A valid token will be used to extract the authenticated identity. Each rule will be activated only when a token is presented at the location recorgnized by the rule. The token will be validated based on the JWT rule config. If validation fails, the request will be rejected. Note: if more than one token is presented (at different locations), the output principal is nondeterministic.</summary> */
        public IEnumerable<JWTRule> jwtRules { get; set; }
    }
}