using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class L4MatchAttributes
    {
        /** <summary>Specifies the port on the host that is being addressed. Many services only expose a single port or label ports with the protocols they support, in these cases it is not required to explicitly select the port.</summary> */
        public int port { get; set; }
        /** <summary>Names of gateways where the rule should be applied. Gateway names in the top-level `gateways` field of the VirtualService (if any) are overridden. The gateway match is independent of sourceLabels.</summary> */
        public IEnumerable<string> gateways { get; set; }
        /** <summary>One or more labels that constrain the applicability of a rule to workloads with the given labels. If the VirtualService has a list of gateways specified in the top-level `gateways` field, it should include the reserved gateway `mesh` in order for this field to be applicable.</summary> */
        public object sourceLabels { get; set; }
        /** <summary>Source namespace constraining the applicability of a rule to workloads in that namespace. If the VirtualService has a list of gateways specified in the top-level `gateways` field, it must include the reserved gateway `mesh` for this field to be applicable.</summary> */
        public string sourceNamespace { get; set; }
        /** <summary>IPv4 or IPv6 ip addresses of destination with optional subnet. E.g., a.b.c.d/xx form or just a.b.c.d.</summary> */
        public IEnumerable<string> destinationSubnets { get; set; }
        /** <summary>IPv4 or IPv6 ip address of source with optional subnet. E.g., a.b.c.d/xx form or just a.b.c.d $hide_from_docs</summary> */
        public string sourceSubnet { get; set; }
    }
}