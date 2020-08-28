using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class HTTPSettings
    {
        /** <summary>Maximum number of pending HTTP requests to a destination. Default 2^32-1.</summary> */
        public int http1MaxPendingRequests { get; set; }
        /** <summary>Maximum number of requests to a backend. Default 2^32-1.</summary> */
        public int http2MaxRequests { get; set; }
        /** <summary>Maximum number of requests per connection to a backend. Setting this parameter to 1 disables keep alive. Default 0, meaning "unlimited", up to 2^29.</summary> */
        public int maxRequestsPerConnection { get; set; }
        /** <summary>Maximum number of retries that can be outstanding to all hosts in a cluster at a given time. Defaults to 2^32-1.</summary> */
        public int maxRetries { get; set; }
        /** <summary>The idle timeout for upstream connection pool connections. The idle timeout is defined as the period in which there are no active requests. If not set, the default is 1 hour. When the idle timeout is reached the connection will be closed. Note that request based timeouts mean that HTTP/2 PINGs will not keep the connection alive. Applies to both HTTP1.1 and HTTP2 connections.</summary> */
        public string idleTimeout { get; set; }
        /** <summary>Policy for upgrading http1.1 connections to http2.</summary> */
        public Networking.V1beta1.H2UpgradePolicy h2UpgradePolicy { get; set; }
    }
}