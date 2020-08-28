using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class Patch
    {
        /** <summary>Operation denotes how the patch should be applied to the selected configuration.</summary> */
        public Operation operation { get; set; }
        /** <summary>The JSON config of the object being patched. This will be merged using proto merge semantics with the existing proto in the path.</summary> */
        public object value { get; set; }
        /** <summary>FilterClass determines the filter insertion point in the filter chain relative to the filters implicitly inserted by the control plane. It is used in conjuction with the ADD operation. This is the preferred insertion mechanism for adding filters over the INSERT_&#42; operations since those operations rely on potentially unstable filter names. Filter ordering is important if your filter depends on or affects the functioning of a another filter in the filter chain. Within a filter class, filters are inserted in the order of processing.</summary> */
        public FilterClass filterClass { get; set; }
    }
}