using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class HTTPCookie
    {
        /** <summary>Path to set for the cookie.</summary> */
        public string path { get; set; }
        /** <summary>Name of the cookie.</summary> */
        public string name { get; set; }
        /** <summary>Lifetime of the cookie.</summary> */
        public string ttl { get; set; }
    }
}