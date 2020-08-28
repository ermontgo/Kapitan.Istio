using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class Destination
    {
        /** <summary>The name of a service from the service registry. Service names are looked up from the platform's service registry (e.g., Kubernetes services, Consul services, etc.) and from the hosts declared by [ServiceEntry](https://istio.io/docs/reference/config/networking/service-entry/#ServiceEntry). Traffic forwarded to destinations that are not found in either of the two, will be dropped.</summary> */
        public string host { get; set; }
        /** <summary>PortSelector specifies the number of a port to be used for matching or selection for final routing.</summary> */
        public Networking.V1beta1.PortSelector port { get; set; }
        /** <summary>The name of a subset within the service. Applicable only to services within the mesh. The subset must be defined in a corresponding DestinationRule.</summary> */
        public string subset { get; set; }
    }
}