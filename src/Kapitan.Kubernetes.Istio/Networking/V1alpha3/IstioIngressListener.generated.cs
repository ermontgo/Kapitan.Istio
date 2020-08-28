using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class IstioIngressListener
    {
        /** <summary>Port describes the properties of a specific port of a service.</summary> */
        public Networking.V1alpha3.Port port { get; set; }
        /** <summary>The IP to which the listener should be bound. Must be in the format `x.x.x.x`. Unix domain socket addresses are not allowed in the bind field for ingress listeners. If omitted, Istio will automatically configure the defaults based on imported services and the workload instances to which this configuration is applied to.</summary> */
        public string bind { get; set; }
        /** <summary>The loopback IP endpoint or Unix domain socket to which traffic should be forwarded to. This configuration can be used to redirect traffic arriving at the bind `IP:Port` on the sidecar to a `localhost:port` or Unix domain socket where the application workload instance is listening for connections. Format should be `127.0.0.1:PORT` or `unix:///path/to/socket`</summary> */
        public string defaultEndpoint { get; set; }
        /** <summary>`CaptureMode` describes how traffic to a listener is expected to be captured. Applicable only when the listener is bound to an IP.</summary> */
        public Networking.V1alpha3.CaptureMode captureMode { get; set; }
    }
}