using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Security.V1beta1
{
    public partial class Condition
    {
        /** <summary>The name of an Istio attribute. See the [full list of supported attributes](https://istio.io/docs/reference/config/security/conditions/).</summary> */
        public string key { get; set; }
        /** <summary>Optional. A list of allowed values for the attribute. Note: at least one of values or not_values must be set.</summary> */
        public IEnumerable<string> values { get; set; }
        /** <summary>Optional. A list of negative match of values for the attribute. Note: at least one of values or not_values must be set.</summary> */
        public IEnumerable<string> notValues { get; set; }
    }
}