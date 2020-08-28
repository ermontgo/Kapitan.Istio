using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes
{
    public partial class IstioCertificateRequest
    {
        /** <summary>PEM-encoded certificate request. The public key in the CSR is used to generate the certificate, and other fields in the generated certificate may be overwritten by the CA.</summary> */
        public string csr { get; set; }
        /** <summary>Optional: requested certificate validity period, in seconds.</summary> */
        public int validityDuration { get; set; }
        /** <summary>Optional: Opaque metadata provided by the XDS node to Istio. Supported metadata: WorkloadName, WorkloadIP, ClusterID</summary> */
        public object metadata { get; set; }
    }
}