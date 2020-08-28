using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;
using Kapitan.Core;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class H2UpgradePolicy : WrappedString
    {
        public H2UpgradePolicy(string value = default) : base(value) { }

        public static implicit operator string(H2UpgradePolicy v)
        {
            return v.Value;
        }

        public static implicit operator H2UpgradePolicy(string v)
        {
            if (string.IsNullOrEmpty(v)) return null;

            return new H2UpgradePolicy(v);
        }

        public static readonly H2UpgradePolicy DEFAULT = "DEFAULT";
        public static readonly H2UpgradePolicy DO_NOT_UPGRADE = "DO_NOT_UPGRADE";
        public static readonly H2UpgradePolicy UPGRADE = "UPGRADE";
    }
}