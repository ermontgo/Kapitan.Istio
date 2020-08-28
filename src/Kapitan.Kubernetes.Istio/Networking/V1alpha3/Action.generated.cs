using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class Action : WrappedString
    {
        public Action(string value = default) : base(value) { }

        public static implicit operator string(Action v)
        {
            return v.Value;
        }

        public static implicit operator Action(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new Action(v);
        }

        public static readonly Action ANY = "ANY";
        public static readonly Action ROUTE = "ROUTE";
        public static readonly Action REDIRECT = "REDIRECT";
        public static readonly Action DIRECT_RESPONSE = "DIRECT_RESPONSE";
    }
}