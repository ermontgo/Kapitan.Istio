using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class EnvoyConfigObjectPatch
    {
        /** <summary>ApplyTo specifies where in the Envoy configuration, the given patch should be applied.</summary> */
        public ApplyTo applyTo { get; set; }
        /** <summary>One or more match conditions to be met before a patch is applied to the generated configuration for a given proxy.</summary> */
        public EnvoyConfigObjectMatch match { get; set; }
        /** <summary>Patch specifies how the selected object should be modified.</summary> */
        public Patch patch { get; set; }
    }
}