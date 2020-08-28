using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class CorsPolicy : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "networking.istio.io/v1alpha3";
        [JsonProperty("kind")]
        public string Kind => "CorsPolicy";

        /** <summary>The list of origins that are allowed to perform CORS requests. The content will be serialized into the Access-Control-Allow-Origin header. Wildcard &#42; will allow all origins. $hide_from_docs</summary> */
        public IEnumerable<string> allowOrigin { get; set; }
        /** <summary>String patterns that match allowed origins. An origin is allowed if any of the string matchers match. If a match is found, then the outgoing Access-Control-Allow-Origin would be set to the origin as provided by the client.</summary> */
        public IEnumerable<Networking.V1alpha3.StringMatch> allowOrigins { get; set; }
        /** <summary>List of HTTP methods allowed to access the resource. The content will be serialized into the Access-Control-Allow-Methods header.</summary> */
        public IEnumerable<string> allowMethods { get; set; }
        /** <summary>List of HTTP headers that can be used when requesting the resource. Serialized to Access-Control-Allow-Headers header.</summary> */
        public IEnumerable<string> allowHeaders { get; set; }
        /** <summary>A list of HTTP headers that the browsers are allowed to access. Serialized into Access-Control-Expose-Headers header.</summary> */
        public IEnumerable<string> exposeHeaders { get; set; }
        /** <summary>Specifies how long the results of a preflight request can be cached. Translates to the `Access-Control-Max-Age` header.</summary> */
        public string maxAge { get; set; }
        /** <summary>Indicates whether the caller is allowed to send the actual request (not the preflight) using credentials. Translates to `Access-Control-Allow-Credentials` header.</summary> */
        public bool allowCredentials { get; set; }
    }
}