using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes
{
    public partial class WorkloadGroup
    {
        /** <summary>`ObjectMeta` describes metadata that will be attached to a `WorkloadEntry`. It is a subset of the supported Kubernetes metadata.</summary> */
        public ObjectMeta metadata { get; set; }
        /** <summary>WorkloadEntry enables specifying the properties of a single non-Kubernetes workload such a VM or a bare metal services that can be referred to by service entries.</summary> */
        public WorkloadEntry template { get; set; }
    }
}