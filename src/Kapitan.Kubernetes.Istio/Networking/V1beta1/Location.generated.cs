using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class Location : WrappedString
    {
        public Location(string value = default) : base(value) { }

        public static implicit operator string(Location v)
        {
            return v.Value;
        }

        public static implicit operator Location(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new Location(v);
        }

        public static readonly Location MESH_EXTERNAL = "MESH_EXTERNAL";
        public static readonly Location MESH_INTERNAL = "MESH_INTERNAL";
    }
}