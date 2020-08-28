using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class Operation : WrappedString
    {
        public Operation(string value = default) : base(value) { }

        public static implicit operator string(Operation v)
        {
            return v.Value;
        }

        public static implicit operator Operation(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new Operation(v);
        }

        public static readonly Operation INVALID = "INVALID";
        public static readonly Operation MERGE = "MERGE";
        public static readonly Operation ADD = "ADD";
        public static readonly Operation REMOVE = "REMOVE";
        public static readonly Operation INSERT_BEFORE = "INSERT_BEFORE";
        public static readonly Operation INSERT_AFTER = "INSERT_AFTER";
        public static readonly Operation INSERT_FIRST = "INSERT_FIRST";
        public static readonly Operation REPLACE = "REPLACE";
    }
}