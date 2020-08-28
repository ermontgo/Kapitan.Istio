using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class Resolution : WrappedString
    {
        public Resolution(string value = default) : base(value) { }

        public static implicit operator string(Resolution v)
        {
            return v.Value;
        }

        public static implicit operator Resolution(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new Resolution(v);
        }

        public static readonly Resolution NONE = "NONE";
        public static readonly Resolution STATIC = "STATIC";
        public static readonly Resolution DNS = "DNS";
    }
}