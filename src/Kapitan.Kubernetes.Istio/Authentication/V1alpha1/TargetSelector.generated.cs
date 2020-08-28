using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authentication.V1alpha1
{
    public partial class TargetSelector
    {
        /** <summary>The name must be a short name from the service registry. The fully qualified domain name will be resolved in a platform specific manner.</summary> */
        public string name { get; set; }
        /** <summary>Specifies the ports. Note that this is the port(s) exposed by the service, not workload instance ports. For example, if a service is defined as below, then `8000` should be used, not `9000`. ```yaml kind: Service metadata: ... spec: ports: - name: http port: 8000 targetPort: 9000 selector: app: backend ``` Leave empty to match all ports that are exposed.</summary> */
        public IEnumerable<Authentication.V1alpha1.PortSelector> ports { get; set; }
    }
}