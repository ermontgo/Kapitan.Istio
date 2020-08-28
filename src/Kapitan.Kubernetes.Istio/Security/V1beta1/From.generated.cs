using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Security.V1beta1
{
    public partial class From
    {
        /** <summary>Source specifies the source identities of a request. Fields in the source are ANDed together.</summary> */
        public Security.V1beta1.Source source { get; set; }
    }
}