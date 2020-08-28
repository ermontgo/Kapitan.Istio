using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class RouteConfigurationMatch
    {
        /** <summary>Route configuration name to match on. Can be used to match a specific route configuration by name, such as the internally generated "http_proxy" route configuration for all sidecars.</summary> */
        public string name { get; set; }
        /** <summary>The service port number or gateway server port number for which this route configuration was generated. If omitted, applies to route configurations for all ports.</summary> */
        public int portNumber { get; set; }
        /** <summary>Applicable only for GATEWAY context. The gateway server port name for which this route configuration was generated.</summary> */
        public string portName { get; set; }
        /** <summary>The Istio gateway config's namespace/name for which this route configuration was generated. Applies only if the context is GATEWAY. Should be in the namespace/name format. Use this field in conjunction with the portNumber and portName to accurately select the Envoy route configuration for a specific HTTPS server within a gateway config object.</summary> */
        public string gateway { get; set; }
        /** <summary>Match a specific virtual host inside a route configuration.</summary> */
        public VirtualHostMatch vhost { get; set; }
    }
}