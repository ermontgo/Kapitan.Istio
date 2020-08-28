using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authentication.V1alpha1
{
    public partial class TriggerRule
    {
        /** <summary>List of paths to be excluded from the request. The rule is satisfied if request path does not match to any of the path in this list.</summary> */
        public IEnumerable<Authentication.V1alpha1.StringMatch> excludedPaths { get; set; }
        /** <summary>List of paths that the request must include. If the list is not empty, the rule is satisfied if request path matches at least one of the path in the list. If the list is empty, the rule is ignored, in other words the rule is always satisfied.</summary> */
        public IEnumerable<Authentication.V1alpha1.StringMatch> includedPaths { get; set; }
    }
}