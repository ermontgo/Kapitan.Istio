using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class HTTPRewrite
    {
        /** <summary>rewrite the path (or the prefix) portion of the URI with this value. If the original URI was matched based on prefix, the value provided in this field will replace the corresponding matched prefix.</summary> */
        public string uri { get; set; }
        /** <summary>rewrite the Authority/Host header with this value.</summary> */
        public string authority { get; set; }
    }
}