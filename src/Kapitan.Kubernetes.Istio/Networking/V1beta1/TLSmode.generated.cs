using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class TLSmode : WrappedString
    {
        public TLSmode(string value = default) : base(value) { }

        public static implicit operator string(TLSmode v)
        {
            return v.Value;
        }

        public static implicit operator TLSmode(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new TLSmode(v);
        }

        public static readonly TLSmode PASSTHROUGH = "PASSTHROUGH";
        public static readonly TLSmode SIMPLE = "SIMPLE";
        public static readonly TLSmode MUTUAL = "MUTUAL";
        public static readonly TLSmode AUTO_PASSTHROUGH = "AUTO_PASSTHROUGH";
        public static readonly TLSmode ISTIO_MUTUAL = "ISTIO_MUTUAL";
    }
}