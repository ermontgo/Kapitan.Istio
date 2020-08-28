using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authentication.V1alpha1
{
    public partial class OriginAuthenticationMethod
    {
        /** <summary>Deprecated. Please use security/v1beta1/RequestAuthentication instead. JSON Web Token (JWT) token format for authentication as defined by [RFC 7519](https://tools.ietf.org/html/rfc7519). See [OAuth 2.0](https://tools.ietf.org/html/rfc6749) and [OIDC 1.0](http://openid.net/connect) for how this is used in the whole authentication flow.</summary> */
        public Authentication.V1alpha1.Jwt jwt { get; set; }
    }
}