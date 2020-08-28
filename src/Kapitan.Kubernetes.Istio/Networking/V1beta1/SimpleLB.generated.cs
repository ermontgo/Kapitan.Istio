using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class SimpleLB : WrappedString
    {
        public SimpleLB(string value = default) : base(value) { }

        public static implicit operator string(SimpleLB v)
        {
            return v.Value;
        }

        public static implicit operator SimpleLB(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new SimpleLB(v);
        }

        public static readonly SimpleLB ROUND_ROBIN = "ROUND_ROBIN";
        public static readonly SimpleLB LEAST_CONN = "LEAST_CONN";
        public static readonly SimpleLB RANDOM = "RANDOM";
        public static readonly SimpleLB PASSTHROUGH = "PASSTHROUGH";
    }
}