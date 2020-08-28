using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authentication.V1alpha1
{
    public partial class Policy : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "authentication.istio.io/v1alpha1";
        [JsonProperty("kind")]
        public string Kind => "Policy";

        /** <summary>Deprecated. Only mesh-level and namespace-level policies are supported. List rules to select workloads that the policy should be applied on. If empty, policy will be used on all workloads in the same namespace.</summary> */
        public IEnumerable<Authentication.V1alpha1.TargetSelector> targets { get; set; }
        /** <summary>Deprecated. Please use security/v1beta1/PeerAuthentication instead. List of authentication methods that can be used for peer authentication. They will be evaluated in order; the first validate one will be used to set peer identity (source.user) and other peer attributes. If none of these methods pass, request will be rejected with authentication failed error (401). Leave the list empty if peer authentication is not required</summary> */
        public IEnumerable<Authentication.V1alpha1.PeerAuthenticationMethod> peers { get; set; }
        /** <summary>Deprecated. Should set mTLS to PERMISSIVE instead. Set this flag to true to accept request (for peer authentication perspective), even when none of the peer authentication methods defined above satisfied. Typically, this is used to delay the rejection decision to next layer (e.g authorization). This flag is ignored if no authentication defined for peer (peers field is empty).</summary> */
        public bool peerIsOptional { get; set; }
        /** <summary>Deprecated. Please use security/v1beta1/RequestAuthentication instead. List of authentication methods that can be used for origin authentication. Similar to peers, these will be evaluated in order; the first validate one will be used to set origin identity and attributes (i.e request.auth.user, request.auth.issuer etc). If none of these methods pass, request will be rejected with authentication failed error (401). A method may be skipped, depends on its trigger rule. If all of these methods are skipped, origin authentication will be ignored, as if it is not defined. Leave the list empty if origin authentication is not required.</summary> */
        public IEnumerable<Authentication.V1alpha1.OriginAuthenticationMethod> origins { get; set; }
        /** <summary>Deprecated. Please use security/v1beta1/RequestAuthentication instead. Set this flag to true to accept request (for origin authentication perspective), even when none of the origin authentication methods defined above satisfied. Typically, this is used to delay the rejection decision to next layer (e.g authorization). This flag is ignored if no authentication defined for origin (origins field is empty).</summary> */
        public bool originIsOptional { get; set; }
        /** <summary>Deprecated. When using security/v1beta1/RequestAuthentication, the request principal always comes from request authentication (i.e JWT). Associates authentication with request principal.</summary> */
        public Authentication.V1alpha1.PrincipalBinding principalBinding { get; set; }
    }
}