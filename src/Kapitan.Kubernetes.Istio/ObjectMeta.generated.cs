using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes
{
    public partial class ObjectMeta
    {
        /** <summary>Labels to attach</summary> */
        public object labels { get; set; }
        /** <summary>Annotations to attach</summary> */
        public object annotations { get; set; }
    }
}