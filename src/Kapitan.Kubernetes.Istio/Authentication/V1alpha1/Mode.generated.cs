using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Authentication.V1alpha1
{
    public partial class Mode : WrappedString
    {
        public Mode(string value = default) : base(value) { }

        public static implicit operator string(Mode v)
        {
            return v.Value;
        }

        public static implicit operator Mode(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new Mode(v);
        }

        public static readonly Mode STRICT = "STRICT";
        public static readonly Mode PERMISSIVE = "PERMISSIVE";
    }
}