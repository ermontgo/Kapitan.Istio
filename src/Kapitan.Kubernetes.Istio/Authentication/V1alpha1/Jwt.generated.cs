using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authentication.V1alpha1
{
    public partial class Jwt
    {
        /** <summary>Identifies the issuer that issued the JWT. See [issuer](https://tools.ietf.org/html/rfc7519#section-4.1.1) Usually a URL or an email address.</summary> */
        public string issuer { get; set; }
        /** <summary>The list of JWT [audiences](https://tools.ietf.org/html/rfc7519#section-4.1.3). that are allowed to access. A JWT containing any of these audiences will be accepted.</summary> */
        public IEnumerable<string> audiences { get; set; }
        /** <summary>URL of the provider's public key set to validate signature of the JWT. See [OpenID Discovery](https://openid.net/specs/openid-connect-discovery-1_0.html#ProviderMetadata).</summary> */
        public string jwksUri { get; set; }
        /** <summary>JSON Web Key Set of public keys to validate signature of the JWT. See https://auth0.com/docs/jwks.</summary> */
        public string jwks { get; set; }
        /** <summary>JWT is sent in a request header. `header` represents the header name.</summary> */
        public IEnumerable<string> jwtHeaders { get; set; }
        /** <summary>JWT is sent in a query parameter. `query` represents the query parameter name.</summary> */
        public IEnumerable<string> jwtParams { get; set; }
        /** <summary>List of trigger rules to decide if this JWT should be used to validate the request. The JWT validation happens if any one of the rules matched. If the list is not empty and none of the rules matched, authentication will skip the JWT validation. Leave this empty to always trigger the JWT validation.</summary> */
        public IEnumerable<TriggerRule> triggerRules { get; set; }
    }
}