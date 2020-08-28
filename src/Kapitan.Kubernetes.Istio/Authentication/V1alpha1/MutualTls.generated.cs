using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authentication.V1alpha1
{
    public partial class MutualTls
    {
        /** <summary>Deprecated. Please use mode = PERMISSIVE instead. If set, will translate to `TLS_PERMISSIVE` mode. Set this flag to true to allow regular TLS (i.e without client x509 certificate). If request carries client certificate, identity will be extracted and used (set to peer identity). Otherwise, peer identity will be left unset. When the flag is false (default), request must have client certificate.</summary> */
        public bool allowTls { get; set; }
        /** <summary>Defines the acceptable connection TLS mode.</summary> */
        public Mode mode { get; set; }
    }
}