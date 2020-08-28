using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Security.V1beta1
{
    public partial class Rule
    {
        /** <summary>Optional. from specifies the source of a request.</summary> */
        public IEnumerable<From> from { get; set; }
        /** <summary>Optional. to specifies the operation of a request.</summary> */
        public IEnumerable<To> to { get; set; }
        /** <summary>Optional. when specifies a list of additional conditions of a request.</summary> */
        public IEnumerable<Security.V1beta1.Condition> when { get; set; }
    }
}