using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class HTTPMatchRequest
    {
        /** <summary>The name assigned to a match. The match's name will be concatenated with the parent route's name and will be logged in the access logs for requests matching this route.</summary> */
        public string name { get; set; }
        /** <summary>Describes how to match a given string in HTTP headers. Match is case-sensitive.</summary> */
        public Networking.V1beta1.StringMatch method { get; set; }
        /** <summary>Specifies the ports on the host that is being addressed. Many services only expose a single port or label ports with the protocols they support, in these cases it is not required to explicitly select the port.</summary> */
        public int port { get; set; }
        /** <summary>Names of gateways where the rule should be applied. Gateway names in the top-level `gateways` field of the VirtualService (if any) are overridden. The gateway match is independent of sourceLabels.</summary> */
        public IEnumerable<string> gateways { get; set; }
        /** <summary>The header keys must be lowercase and use hyphen as the separator, e.g. _x-request-id_.</summary> */
        public object headers { get; set; }
        /** <summary>Describes how to match a given string in HTTP headers. Match is case-sensitive.</summary> */
        public Networking.V1beta1.StringMatch uri { get; set; }
        /** <summary>Describes how to match a given string in HTTP headers. Match is case-sensitive.</summary> */
        public Networking.V1beta1.StringMatch scheme { get; set; }
        /** <summary>Describes how to match a given string in HTTP headers. Match is case-sensitive.</summary> */
        public Networking.V1beta1.StringMatch authority { get; set; }
        /** <summary>One or more labels that constrain the applicability of a rule to workloads with the given labels. If the VirtualService has a list of gateways specified in the top-level `gateways` field, it must include the reserved gateway `mesh` for this field to be applicable.</summary> */
        public object sourceLabels { get; set; }
        /** <summary>Query parameters for matching.</summary> */
        public object queryParams { get; set; }
        /** <summary>Flag to specify whether the URI matching should be case-insensitive.</summary> */
        public bool ignoreUriCase { get; set; }
        /** <summary>withoutHeader has the same syntax with the header, but has opposite meaning. If a header is matched with a matching rule among withoutHeader, the traffic becomes not matched one.</summary> */
        public object withoutHeaders { get; set; }
        /** <summary>Source namespace constraining the applicability of a rule to workloads in that namespace. If the VirtualService has a list of gateways specified in the top-level `gateways` field, it must include the reserved gateway `mesh` for this field to be applicable.</summary> */
        public string sourceNamespace { get; set; }
    }
}