using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes
{
    public partial class JWTRule
    {
        /** <summary>Identifies the issuer that issued the JWT. See [issuer](https://tools.ietf.org/html/rfc7519#section-4.1.1) A JWT with different `iss` claim will be rejected.</summary> */
        public string issuer { get; set; }
        /** <summary>The list of JWT [audiences](https://tools.ietf.org/html/rfc7519#section-4.1.3). that are allowed to access. A JWT containing any of these audiences will be accepted.</summary> */
        public IEnumerable<string> audiences { get; set; }
        /** <summary>URL of the provider's public key set to validate signature of the JWT. See [OpenID Discovery](https://openid.net/specs/openid-connect-discovery-1_0.html#ProviderMetadata).</summary> */
        public string jwksUri { get; set; }
        /** <summary>JSON Web Key Set of public keys to validate signature of the JWT. See https://auth0.com/docs/jwks.</summary> */
        public string jwks { get; set; }
        /** <summary>List of header locations from which JWT is expected. For example, below is the location spec if JWT is expected to be found in `x-jwt-assertion` header, and have "Bearer " prefix: ``` fromHeaders: - name: x-jwt-assertion prefix: "Bearer " ```</summary> */
        public IEnumerable<JWTHeader> fromHeaders { get; set; }
        /** <summary>List of query parameters from which JWT is expected. For example, if JWT is provided via query parameter `my_token` (e.g /path?my_token=<JWT>), the config is: ``` fromParams: - "my_token" ```</summary> */
        public IEnumerable<string> fromParams { get; set; }
        /** <summary>This field specifies the header name to output a successfully verified JWT payload to the backend. The forwarded data is `base64_encoded(jwt_payload_in_JSON)`. If it is not specified, the payload will not be emitted.</summary> */
        public string outputPayloadToHeader { get; set; }
        /** <summary>If set to true, the orginal token will be kept for the ustream request. Default is false.</summary> */
        public bool forwardOriginalToken { get; set; }
    }
}