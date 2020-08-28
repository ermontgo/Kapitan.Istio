using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class Headers
    {
        /** <summary>HeaderOperations Describes the header manipulations to apply</summary> */
        public HeaderOperations response { get; set; }
        /** <summary>HeaderOperations Describes the header manipulations to apply</summary> */
        public HeaderOperations request { get; set; }
    }
}