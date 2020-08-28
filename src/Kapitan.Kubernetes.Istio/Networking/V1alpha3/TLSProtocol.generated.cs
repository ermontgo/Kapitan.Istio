using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class TLSProtocol : WrappedString
    {
        public TLSProtocol(string value = default) : base(value) { }

        public static implicit operator string(TLSProtocol v)
        {
            return v.Value;
        }

        public static implicit operator TLSProtocol(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new TLSProtocol(v);
        }

        public static readonly TLSProtocol TLS_AUTO = "TLS_AUTO";
        public static readonly TLSProtocol TLSV1_0 = "TLSV1_0";
        public static readonly TLSProtocol TLSV1_1 = "TLSV1_1";
        public static readonly TLSProtocol TLSV1_2 = "TLSV1_2";
        public static readonly TLSProtocol TLSV1_3 = "TLSV1_3";
    }
}