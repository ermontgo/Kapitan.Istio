using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class FilterClass : WrappedString
    {
        public FilterClass(string value = default) : base(value) { }

        public static implicit operator string(FilterClass v)
        {
            return v.Value;
        }

        public static implicit operator FilterClass(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new FilterClass(v);
        }

        public static readonly FilterClass UNSPECIFIED = "UNSPECIFIED";
        public static readonly FilterClass AUTHN = "AUTHN";
        public static readonly FilterClass AUTHZ = "AUTHZ";
        public static readonly FilterClass STATS = "STATS";
    }
}