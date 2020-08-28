using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class TLSRoute
    {
        /** <summary>Match conditions to be satisfied for the rule to be activated. All conditions inside a single match block have AND semantics, while the list of match blocks have OR semantics. The rule is matched if any one of the match blocks succeed.</summary> */
        public IEnumerable<Networking.V1beta1.TLSMatchAttributes> match { get; set; }
        /** <summary>The destination to which the connection should be forwarded to.</summary> */
        public IEnumerable<Networking.V1beta1.RouteDestination> route { get; set; }
    }
}