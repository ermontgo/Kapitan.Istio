using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class ApplyTo : WrappedString
    {
        public ApplyTo(string value = default) : base(value) { }

        public static implicit operator string(ApplyTo v)
        {
            return v.Value;
        }

        public static implicit operator ApplyTo(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new ApplyTo(v);
        }

        public static readonly ApplyTo INVALID = "INVALID";
        public static readonly ApplyTo LISTENER = "LISTENER";
        public static readonly ApplyTo FILTER_CHAIN = "FILTER_CHAIN";
        public static readonly ApplyTo NETWORK_FILTER = "NETWORK_FILTER";
        public static readonly ApplyTo HTTP_FILTER = "HTTP_FILTER";
        public static readonly ApplyTo ROUTE_CONFIGURATION = "ROUTE_CONFIGURATION";
        public static readonly ApplyTo VIRTUAL_HOST = "VIRTUAL_HOST";
        public static readonly ApplyTo HTTP_ROUTE = "HTTP_ROUTE";
        public static readonly ApplyTo CLUSTER = "CLUSTER";
    }
}