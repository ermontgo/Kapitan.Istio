using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class PortSelector
    {
        /** <summary>Valid port number</summary> */
        public int number { get; set; }
    }
}