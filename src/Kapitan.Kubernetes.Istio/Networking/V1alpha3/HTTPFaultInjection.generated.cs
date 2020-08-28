using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class HTTPFaultInjection
    {
        /** <summary>Delay specification is used to inject latency into the request forwarding path. The following example will introduce a 5 second delay in 1 out of every 1000 requests to the "v1" version of the "reviews" service from all pods with label env: prod</summary> */
        public Delay delay { get; set; }
        /** <summary>Abort specification is used to prematurely abort a request with a pre-specified error code. The following example will return an HTTP 400 error code for 1 out of every 1000 requests to the "ratings" service "v1".</summary> */
        public Abort abort { get; set; }
    }
}