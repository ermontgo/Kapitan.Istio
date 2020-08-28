using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Authentication.V1alpha1
{
    public partial class PrincipalBinding : WrappedString
    {
        public PrincipalBinding(string value = default) : base(value) { }

        public static implicit operator string(PrincipalBinding v)
        {
            return v.Value;
        }

        public static implicit operator PrincipalBinding(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new PrincipalBinding(v);
        }

        public static readonly PrincipalBinding USE_PEER = "USE_PEER";
        public static readonly PrincipalBinding USE_ORIGIN = "USE_ORIGIN";
    }
}