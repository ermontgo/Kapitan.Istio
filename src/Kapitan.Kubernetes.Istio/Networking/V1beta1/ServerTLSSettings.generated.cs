using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class ServerTLSSettings
    {
        /** <summary>TLS modes enforced by the proxy</summary> */
        public TLSmode mode { get; set; }
        /** <summary>REQUIRED if mode is `SIMPLE` or `MUTUAL`. The path to the file holding the server's private key.</summary> */
        public string privateKey { get; set; }
        /** <summary>REQUIRED if mode is `MUTUAL`. The path to a file containing certificate authority certificates to use in verifying a presented client side certificate.</summary> */
        public string caCertificates { get; set; }
        /** <summary>For gateways running on Kubernetes, the name of the secret that holds the TLS certs including the CA certificates. Applicable only on Kubernetes, and only if the dynamic credential fetching feature is enabled in the proxy by setting `ISTIO_META_USER_SDS` metadata variable. The secret (of type `generic`) should contain the following keys and values: `key: <privateKey>` and `cert: <serverCert>`. For mutual TLS, `cacert: <CACertificate>` can be provided in the same secret or a separate secret named `<secret>-cacert`. Secret of type tls for server certificates along with ca.crt key for CA certificates is also supported. Only one of server certificates and CA certificate or credentialName can be specified.</summary> */
        public string credentialName { get; set; }
        /** <summary>A list of alternate names to verify the subject identity in the certificate presented by the client.</summary> */
        public IEnumerable<string> subjectAltNames { get; set; }
        /** <summary>If set to true, the load balancer will send a 301 redirect for all http connections, asking the clients to use HTTPS.</summary> */
        public bool httpsRedirect { get; set; }
        /** <summary>REQUIRED if mode is `SIMPLE` or `MUTUAL`. The path to the file holding the server-side TLS certificate to use.</summary> */
        public string serverCertificate { get; set; }
        /** <summary>An optional list of base64-encoded SHA-256 hashes of the SKPIs of authorized client certificates. Note: When both verify_certificate_hash and verify_certificate_spki are specified, a hash matching either value will result in the certificate being accepted.</summary> */
        public IEnumerable<string> verifyCertificateSpki { get; set; }
        /** <summary>An optional list of hex-encoded SHA-256 hashes of the authorized client certificates. Both simple and colon separated formats are acceptable. Note: When both verify_certificate_hash and verify_certificate_spki are specified, a hash matching either value will result in the certificate being accepted.</summary> */
        public IEnumerable<string> verifyCertificateHash { get; set; }
        /** <summary>TLS protocol versions.</summary> */
        public TLSProtocol minProtocolVersion { get; set; }
        /** <summary>TLS protocol versions.</summary> */
        public TLSProtocol maxProtocolVersion { get; set; }
        /** <summary>Optional: If specified, only support the specified cipher list. Otherwise default to the default cipher list supported by Envoy.</summary> */
        public IEnumerable<string> cipherSuites { get; set; }
    }
}