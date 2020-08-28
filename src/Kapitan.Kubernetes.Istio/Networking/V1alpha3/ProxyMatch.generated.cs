using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class ProxyMatch
    {
        /** <summary>A regular expression in golang regex format (RE2) that can be used to select proxies using a specific version of istio proxy. The Istio version for a given proxy is obtained from the node metadata field ISTIO_VERSION supplied by the proxy when connecting to Pilot. This value is embedded as an environment variable (ISTIO_META_ISTIO_VERSION) in the Istio proxy docker image. Custom proxy implementations should provide this metadata variable to take advantage of the Istio version check option.</summary> */
        public string proxyVersion { get; set; }
        /** <summary>Match on the node metadata supplied by a proxy when connecting to Istio Pilot. Note that while Envoy's node metadata is of type Struct, only string key-value pairs are processed by Pilot. All keys specified in the metadata must match with exact values. The match will fail if any of the specified keys are absent or the values fail to match.</summary> */
        public object metadata { get; set; }
    }
}