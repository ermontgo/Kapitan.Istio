using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1beta1
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

        public static readonly Mode REGISTRY_ONLY = "REGISTRY_ONLY";
        public static readonly Mode ALLOW_ANY = "ALLOW_ANY";
    }
}