using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class CaptureMode : WrappedString
    {
        public CaptureMode(string value = default) : base(value) { }

        public static implicit operator string(CaptureMode v)
        {
            return v.Value;
        }

        public static implicit operator CaptureMode(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new CaptureMode(v);
        }

        public static readonly CaptureMode DEFAULT = "DEFAULT";
        public static readonly CaptureMode IPTABLES = "IPTABLES";
        public static readonly CaptureMode NONE = "NONE";
    }
}