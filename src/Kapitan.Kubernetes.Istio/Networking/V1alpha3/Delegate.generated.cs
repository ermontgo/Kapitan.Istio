using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class Delegate
    {
        /** <summary>Name specifies the name of the delegate VirtualService.</summary> */
        public string name { get; set; }
        /** <summary>Namespace specifies the namespace where the delegate VirtualService resides. By default, it is same to the root's.</summary> */
        public string @namespace { get; set; }
    }
}