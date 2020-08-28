using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class HeaderOperations
    {
        /** <summary>Overwrite the headers specified by key with the given values</summary> */
        public object set { get; set; }
        /** <summary>Append the given values to the headers specified by keys (will create a comma-separated list of values)</summary> */
        public object add { get; set; }
        /** <summary>Remove a the specified headers</summary> */
        public IEnumerable<string> remove { get; set; }
    }
}