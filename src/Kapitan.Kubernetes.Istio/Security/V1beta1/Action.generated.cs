using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Security.V1beta1
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

        public static readonly Action ALLOW = "ALLOW";
        public static readonly Action DENY = "DENY";
        public static readonly Action AUDIT = "AUDIT";
    }
}