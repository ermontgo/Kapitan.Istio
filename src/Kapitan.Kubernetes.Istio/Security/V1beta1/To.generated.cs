using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Security.V1beta1
{
    public partial class To
    {
        /** <summary>Operation specifies the operations of a request. Fields in the operation are ANDed together.</summary> */
        public Security.V1beta1.Operation operation { get; set; }
    }
}