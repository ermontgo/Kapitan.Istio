using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class IstioEgressListener
    {
        /** <summary>Port describes the properties of a specific port of a service.</summary> */
        public Networking.V1alpha3.Port port { get; set; }
        /** <summary>The IP or the Unix domain socket to which the listener should be bound to. Port MUST be specified if bind is not empty. Format: `x.x.x.x` or `unix:///path/to/uds` or `unix://@foobar` (Linux abstract namespace). If omitted, Istio will automatically configure the defaults based on imported services, the workload instances to which this configuration is applied to and the captureMode. If captureMode is `NONE`, bind will default to 127.0.0.1.</summary> */
        public string bind { get; set; }
        /** <summary>One or more service hosts exposed by the listener in `namespace/dnsName` format. Services in the specified namespace matching `dnsName` will be exposed. The corresponding service can be a service in the service registry (e.g., a Kubernetes or cloud foundry service) or a service specified using a `ServiceEntry` or `VirtualService` configuration. Any associated `DestinationRule` in the same namespace will also be used.</summary> */
        public IEnumerable<string> hosts { get; set; }
        /** <summary>`CaptureMode` describes how traffic to a listener is expected to be captured. Applicable only when the listener is bound to an IP.</summary> */
        public Networking.V1alpha3.CaptureMode captureMode { get; set; }
    }
}