using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Security.V1beta1
{
    public partial class Source
    {
        /** <summary>Optional. A list of source peer identities (i.e. service account), which matches to the "source.principal" attribute. This field requires mTLS enabled.</summary> */
        public IEnumerable<string> principals { get; set; }
        /** <summary>Optional. A list of negative match of source peer identities.</summary> */
        public IEnumerable<string> notPrincipals { get; set; }
        /** <summary>Optional. A list of request identities (i.e. "iss/sub" claims), which matches to the "request.auth.principal" attribute.</summary> */
        public IEnumerable<string> requestPrincipals { get; set; }
        /** <summary>Optional. A list of negative match of request identities.</summary> */
        public IEnumerable<string> notRequestPrincipals { get; set; }
        /** <summary>Optional. A list of namespaces, which matches to the "source.namespace" attribute. This field requires mTLS enabled.</summary> */
        public IEnumerable<string> namespaces { get; set; }
        /** <summary>Optional. A list of negative match of namespaces.</summary> */
        public IEnumerable<string> notNamespaces { get; set; }
        /** <summary>Optional. A list of IP blocks, which matches to the "source.ip" attribute. Single IP (e.g. "1.2.3.4") and CIDR (e.g. "1.2.3.0/24") are supported.</summary> */
        public IEnumerable<string> ipBlocks { get; set; }
        /** <summary>Optional. A list of negative match of IP blocks.</summary> */
        public IEnumerable<string> notIpBlocks { get; set; }
    }
}