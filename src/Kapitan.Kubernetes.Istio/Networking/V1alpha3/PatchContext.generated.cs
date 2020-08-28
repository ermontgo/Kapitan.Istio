using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class PatchContext : WrappedString
    {
        public PatchContext(string value = default) : base(value) { }

        public static implicit operator string(PatchContext v)
        {
            return v.Value;
        }

        public static implicit operator PatchContext(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new PatchContext(v);
        }

        public static readonly PatchContext ANY = "ANY";
        public static readonly PatchContext SIDECAR_INBOUND = "SIDECAR_INBOUND";
        public static readonly PatchContext SIDECAR_OUTBOUND = "SIDECAR_OUTBOUND";
        public static readonly PatchContext GATEWAY = "GATEWAY";
    }
}