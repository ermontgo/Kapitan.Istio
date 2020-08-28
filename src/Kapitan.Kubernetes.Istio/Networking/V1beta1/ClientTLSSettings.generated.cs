using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class ClientTLSSettings
    {
        /** <summary>TLS connection mode</summary> */
        public TLSmode mode { get; set; }
        /** <summary>REQUIRED if mode is `MUTUAL`. The path to the file holding the client-side TLS certificate to use. Should be empty if mode is `ISTIO_MUTUAL`.</summary> */
        public string clientCertificate { get; set; }
        /** <summary>REQUIRED if mode is `MUTUAL`. The path to the file holding the client's private key. Should be empty if mode is `ISTIO_MUTUAL`.</summary> */
        public string privateKey { get; set; }
        /** <summary>OPTIONAL: The path to the file containing certificate authority certificates to use in verifying a presented server certificate. If omitted, the proxy will not verify the server's certificate. Should be empty if mode is `ISTIO_MUTUAL`.</summary> */
        public string caCertificates { get; set; }
        /** <summary>The name of the secret that holds the TLS certs for the client including the CA certificates. Secret must exist in the same namespace with the proxy using the certificates. The secret (of type `generic`)should contain the following keys and values: `key: <privateKey>`, `cert: <serverCert>`, `cacert: <CACertificate>`. Secret of type tls for client certificates along with ca.crt key for CA certificates is also supported. Only one of client certificates and CA certificate or credentialName can be specified.</summary> */
        public string credentialName { get; set; }
        /** <summary>A list of alternate names to verify the subject identity in the certificate. If specified, the proxy will verify that the server certificate's subject alt name matches one of the specified values. If specified, this list overrides the value of subject_alt_names from the ServiceEntry.</summary> */
        public IEnumerable<string> subjectAltNames { get; set; }
        /** <summary>SNI string to present to the server during TLS handshake.</summary> */
        public string sni { get; set; }
    }
}